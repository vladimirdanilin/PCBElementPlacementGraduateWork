using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ElementPlacement.Placement;

namespace ElementPlacement
{
    internal class Fitness
    {
        //Класс, рассчитывающий значение целевой функции
        public int[,] adjacencyMatrix;
        public double[,] heatmatrix;
        List<string> elementsSequenceList;

        public void GetAdjacencyMatrix(string DBPath) //Получение матрицы смежности элементов
        {
            string str = @$"URI=file:{DBPath}";

            using (var connection = new SQLiteConnection(str))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Межсоединения", connection);
                var reader = command.ExecuteReader();

                var chains = new Dictionary<string, List<string>>();
                var elements = new HashSet<string>();

                while (reader.Read())
                {
                    var chainId = reader["НомерЦепи"].ToString();
                    var elementId = reader["ПозиционноеОбозначениеЭлемента"].ToString();

                    elements.Add(elementId);

                    if (!chains.ContainsKey(chainId))
                    {
                        chains[chainId] = new List<string>();
                    }

                    chains[chainId].Add(elementId);
                }

                adjacencyMatrix = new int[elements.Count, elements.Count];
                elementsSequenceList = elements.ToList();

                foreach (var chain in chains.Values)
                {
                    for (int i = 0; i < chain.Count; i++)
                    {
                        for (int j = i + 1; j < chain.Count; j++)
                        {
                            var element1Index = elementsSequenceList.IndexOf(chain[i]);
                            var element2Index = elementsSequenceList.IndexOf(chain[j]);

                            adjacencyMatrix[element1Index, element2Index]++;
                            adjacencyMatrix[element2Index, element1Index]++;
                        }
                    }
                }

                // Вывод матрицы смежности
                /*for (int i = 0; i < elements.Count; i++)
                {
                    for (int j = 0; j < elements.Count; j++)
                    {
                        System.Console.Write(adjacencyMatrix[i, j] + " ");
                    }
                    System.Console.WriteLine();
                }*/
            }
        }

        public double CountDistanceCriteria(List<Element> listOfElements, string DBPath)
        { //Подсчет значения функции пригодности каждой особи
            GetAdjacencyMatrix(DBPath);
            double Sum = 0;

            List<Element> orderedListOfElements = elementsSequenceList
                .Select(id => listOfElements.FirstOrDefault(e => e.referenceDesignation == id))
                .Where(e => e != null)
                .ToList();

            for (int i = 0; i < Math.Sqrt(adjacencyMatrix.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(adjacencyMatrix.Length); j++)
                {
                    if ((adjacencyMatrix[i, j] != 0))
                    {
                        Sum += Math.Sqrt(Math.Pow((orderedListOfElements[i].position.x + (orderedListOfElements[i].length / 2)) - (orderedListOfElements[j].position.x + (orderedListOfElements[j].length / 2)), 2) + Math.Pow((orderedListOfElements[i].position.y + (orderedListOfElements[i].width / 2)) - (orderedListOfElements[j].position.y + (orderedListOfElements[j].width / 2)), 2)) * adjacencyMatrix[i, j];
                        adjacencyMatrix[j, i] = 0; //Исключаем симметричность
                    }

                }
            }
            Sum = Math.Round(Sum, 3);

            return Sum;
        }

        public double CountThermalCriteria(List<Element> listOfElements, List<Element> elementsExtra)
        { //Подсчет значения функции пригодности каждой особи
            int NumOfElements = listOfElements.Count;
            FindCloseElements(listOfElements, NumOfElements);
            double Sum = 0;
            double Pi = 3.1415;
            double с0 = 5.67;

            heatmatrix = new double[NumOfElements, 1];
            for (int i = 0; i < NumOfElements; i++)
            {
                heatmatrix[i, 0] = elementsExtra[i].maxT;
            }

            for (int i = 0; i < NumOfElements; i++)
            {
                for (int j = 0; j < NumOfElements; j++)
                {
                    if ((i != j) && (listOfElements[i].CloseElements.Contains(j)))
                    {
                        double x1 = 0; //X координата первого элемента
                        double y1 = 0; //Y координата первого элемента
                        double l1 = 0; //Длина первого элемента
                        double w1 = 0; //Ширина первого элемента
                        double x2 = 0; //X координата второго элемента
                        double y2 = 0; //Y координата второго элемента
                        double l2 = 0; //Длина второго элемента
                        double w2 = 0; //Ширина второго элемента
                        x1 = listOfElements[i].position.x + listOfElements[i].length / 2;
                        y1 = listOfElements[i].position.y + listOfElements[i].width / 2;
                        l1 = listOfElements[i].length;
                        w1 = listOfElements[i].width;
                        x2 = listOfElements[j].position.x + listOfElements[j].length / 2;
                        y2 = listOfElements[j].position.y + listOfElements[j].width / 2;
                        l2 = listOfElements[j].length;
                        w2 = listOfElements[j].width;

                        double Length = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)) * 0.001;
                        double angleOfVisibility = (FindAngle(x1, y1, l1, w1, x2, y2) *
                            FindAngle(x2, y2, l2, w2, x1, y1)) / (Pi * Math.Pow(Length, 2));
                        //Console.WriteLine("ANGLE = " + angleOfVisibility);
                        double AreaOfHeatingSurface = 0;
                        Rectangle rect1 = new Rectangle((int)listOfElements[i].position.x, (int)listOfElements[i].position.y, (int)listOfElements[i].length, (int)listOfElements[i].width);
                        Rectangle rect2 = new Rectangle((int)listOfElements[j].position.x, (int)listOfElements[j].position.y, (int)listOfElements[j].length, (int)listOfElements[j].width);

                        if ((FindOrientation(x1, y1, x1 - l1 / 2, y1 + w1 / 2, x2, y2) && FindOrientation(x1, y1, x1 + l1 / 2, y1 + w1 / 2, x2, y2)) ||
                            ((FindOrientation(x1, y1, x1 - l1 / 2, y1 + w1 / 2, x2, y2) == false) && (FindOrientation(x1, y1, x1 + l1 / 2, y1 + w1 / 2, x2, y2) == false)))
                        {
                            AreaOfHeatingSurface = listOfElements[i].length * listOfElements[i].thickness;
                        }
                        else
                        {
                            AreaOfHeatingSurface = listOfElements[i].width * listOfElements[i].thickness;
                        }
                        
                        double Area = AreaOfHeatingSurface * 0.00001;
                        int index1 = elementsExtra.FindIndex(x => x.referenceDesignation == listOfElements[i].referenceDesignation);
                        int index2 = elementsExtra.FindIndex(x => x.referenceDesignation == listOfElements[j].referenceDesignation);
                        Sum += с0 * Area * Math.Pow(((heatmatrix[index1, 0] - heatmatrix[index2, 0]) / 100), 4) * angleOfVisibility;
                        //Console.WriteLine("SUM = " + Sum);
                    }

                }
            }
            Sum = Math.Round(Sum, 4);

            return Sum;

        }

        private void FindCloseElements(List<Element> listOfElements, int numOfElements) //Определение элементов, расположенных рядом с данным
        {
            double Length = 0;
            double[] LengthArray;
            for (int i = 0; i < numOfElements; i++)
            {
                LengthArray = new double[listOfElements.Count];
                for (int j = 0; j < numOfElements; j++)
                {
                    if ((i != j))
                    {
                        Length = Math.Sqrt(Math.Pow((listOfElements[i].position.x + (listOfElements[i].length / 2)) -
                            (listOfElements[j].position.x + (listOfElements[j].length / 2)), 2) +
                            Math.Pow((listOfElements[i].position.y + (listOfElements[i].width / 2)) -
                            (listOfElements[j].position.y + (listOfElements[j].width / 2)), 2));
                        LengthArray[j] = Length;
                        LengthArray[i] = int.MaxValue; //Расстояние от элемента до самого себя максимально
                    }

                }

                for (int j = 0; j < 4; j++)
                {
                    int m = Array.IndexOf(LengthArray, LengthArray.Min());
                    LengthArray[m] = int.MaxValue;
                    listOfElements[i].CloseElements[j] = m;
                }

            }
        }


        //Расчет косинусов углов
        private double FindAngle(double x1, double y1, double l1, double w1, double x2, double y2)
        {
            if ((FindOrientation(x1, y1, x1 - l1 / 2, y1 + w1 / 2, x2, y2) && FindOrientation(x1, y1, x1 + l1 / 2, y1 + w1 / 2, x2, y2)) ||
                ((FindOrientation(x1, y1, x1 - l1 / 2, y1 + w1 / 2, x2, y2) == false) && (FindOrientation(x1, y1, x1 + l1 / 2, y1 + w1 / 2, x2, y2) == false)))
            {
                double vectx = Math.Abs(x2 - x1);
                double vecty = Math.Abs(y2 - y1);
                double normx = 0; //Задаем вектор нормали. В данном случае он сонаправлен с осью ординат
                double normy = 1;
                double skalar = vectx * normx + vecty * normy;
                double cosAlpha = skalar / (Math.Sqrt(Math.Pow(vectx, 2) + Math.Pow(vecty, 2)) * Math.Sqrt(Math.Pow(normx, 2) + Math.Pow(normy, 2)));
                cosAlpha = Math.Round(cosAlpha, 4);
                return cosAlpha;
            }
            else
            {
                double vectx = Math.Abs(x2 - x1);
                double vecty = Math.Abs(y2 - y1);
                double normx = 1; //Задаем вектор нормали. В данном случае он сонаправлен с осью абсцисс
                double normy = 0;
                double skalar = vectx * normx + vecty * normy;
                double cosAlpha = skalar / ((Math.Sqrt(Math.Pow(vectx, 2) + Math.Pow(vecty, 2)) * Math.Sqrt(Math.Pow(normx, 2) + Math.Pow(normy, 2))));
                cosAlpha = Math.Round(cosAlpha, 4);
                return cosAlpha;
            }

        }

        //Выражаем критерий через каноническое уравнение прямой на плоскости
        private bool FindOrientation(double xOfPoint1Border, double yOfPoint1Border, double xOfPoint2Border, double yOfPoint2Border, double xOfElement, double yOfElement)
        {
            double Criteria = ((yOfElement - yOfPoint1Border) / (yOfPoint2Border - yOfPoint1Border)) - ((xOfElement - xOfPoint1Border) / (xOfPoint2Border - xOfPoint1Border));
            if (Criteria > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
