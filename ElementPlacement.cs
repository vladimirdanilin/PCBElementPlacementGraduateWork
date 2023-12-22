using Microsoft.Data.Sqlite;
using OriginalCircuit.AltiumSharp.BasicTypes;
using OriginalCircuit.AltiumSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ElementPlacement.Population;
using static ElementPlacement.Placement;
using OriginalCircuit.AltiumSharp.Drawing;
using System.Drawing.Printing;
using OriginalCircuit.AltiumSharp.Records;

namespace ElementPlacement
{
    public partial class ElementPlacement : Form
    {
        public ElementPlacement()
        {
            InitializeComponent();
        }

        InputData Data;


        private double X;
        private double Y;
        private int NumOfSpecies = 50; // Default
        private int MaxNumOfGenerationsStagnation = 5; //Default кол-во поколений, на протяжении которого значение функции пригодности неизменно
        private int Mutation = 100; // Default процент мутации
        private double PCBLength = 400; // Default длина платы
        private double PCBWidth = 400; // Default ширина платы
        private double PCBOffsetLength;
        private double PCBOffsetWidth;
        private int k; //Кол-во поколений, на котором работа программы останавливается
        private int ProjectID;
        private int PCBID;
        private string txt = "";

        public string DataBasePath { get; set; }
        public string DataBaseName { get; set; }
        public string PCBlibFilePath { get; set; }
        public string SCHlibFilePath { get; set; }

        ChooseCriterion chooseCriterion;
        NewDatabaseForm newDatabaseForm;
        NewProjectForm newProjectForm;
        SelectProject selectProject;
        Database database;
        GAForm gaForm;
        SelectPCB selectPCB;

        public Random rnd = new Random();
        public List<Chromosome> ListOfParentalSpecies; //Начальный список особей
        public List<Chromosome> ListOfOffspringSpecies; //Список особей-потомков
        public List<Chromosome> ListOfOffspringSpeciesMutated; //Список мутировавших особей-потомков
        public List<Chromosome> ListOfSpeciesUNITED; //Объединенный список особей-родителей и мутировавших особей-потомков
        public List<Chromosome> ListOfSpeciesSORTED = new List<Chromosome>(); //Сортированный список
        public List<Chromosome> BestSpecies = new List<Chromosome>();
        private List<Chromosome> BestSpeciesSorted = new List<Chromosome>();

        public List<Element> AllElementsList = new List<Element>();


        Placement placement;
        Fitness fitness = new Fitness();

        Graphics graphics;
        Bitmap BitmapForElements { get; set; }
        Brush brushForElement;
        Brush brushForText;
        Brush brushForPCB;
        Color colorForElement;
        Color colorForText = Color.Blue;
        Color colorForPCB = Color.Black;
        Pen penForLines = new Pen(Color.Black, 1);

        int scaleFactor = 10;
        double offsetX = 1;
        double offsetY = 1;

        private void запуститьРазмещениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataBasePath = null;
            RemoveAllElements(ListOfParentalSpecies);
            RemoveAllElements(ListOfOffspringSpecies);
            RemoveAllElements(ListOfOffspringSpeciesMutated);
            RemoveAllElements(ListOfSpeciesUNITED);
            RemoveAllElements(ListOfSpeciesSORTED);
            RemoveAllElements(BestSpecies);
            RemoveAllElements(BestSpeciesSorted);

            GetPCBData();
            FitnessStagnation();
            BestSpeciesSorted.AddRange(BestSpecies.OrderBy(x => x.Fitness).ToList());
            placement = new Placement();
            placement.PackageStart(Data.ProjectElementsList, BestSpeciesSorted[0].Genes, PCBOffsetLength, PCBOffsetWidth);
            FitnessFunctionLabel.Text += BestSpeciesSorted[0].Fitness.ToString() + " " + txt;
            if (PCBlibFilePath != null)
            {
                RenderElements(placement);
            }
            else
            {
                PrintElements();
            }
            SaveLocationData(placement);

        }


        private void SaveLocationData(Placement placement) //Сохранение результирующих данных в БД
        {
            string str = @$"URI=file:{DataBasePath}";

            using var con = new SQLiteConnection(str);
            con.Open();

            using var cmd = new SQLiteCommand(con);
            foreach (var element in placement.ElementsList)
            {
                string ElementLocationQuery = "UPDATE ЭлементыПроекта SET КоординатаX = " + element.position.x + ", КоординатаY = " + element.position.y + " WHERE ПозиционноеОбозначениеЭлемента = '" + element.referenceDesignation + "' AND КодПроекта = " + ProjectID;
                cmd.CommandText = ElementLocationQuery;
                cmd.ExecuteNonQuery();
            }
            string FitnessFunctionQuery = "UPDATE Проект SET ЗначениеЦелевойФункции = " + Math.Round(BestSpeciesSorted[0].Fitness, 2) + " WHERE КодПроекта = " + ProjectID;
            cmd.CommandText = FitnessFunctionQuery;
            cmd.ExecuteNonQuery();

        }

        private void GetPCBData() //Получение данных о ПП
        {
            PCBLength = 0; PCBWidth = 0;
            if (PCBID != int.MaxValue)
            {
                PCBLength = Data.ListOfPCBs.Find(p => p.PCBID == PCBID).PCBLength;
                PCBWidth = Data.ListOfPCBs.Find(p => p.PCBID == PCBID).PCBWidth;
                PCBLengthLabel.Text = $"Длина ПП = {PCBLength} мм Ширина ПП = {PCBWidth} мм";
                PCBOffsetLength = PCBLength - 2 * offsetX;
                PCBOffsetWidth = PCBWidth - 2 * offsetY;
            }
            selectPCB = null;
            selectProject = null;
        }

        private void PrintElements() //Метод, рисующий элементы
        {
            BitmapForElements = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            pictureBoxMain.Image = BitmapForElements;
            graphics = Graphics.FromImage(pictureBoxMain.Image);
            brushForPCB = new SolidBrush(colorForPCB);
            //graphics.FillRectangle(brushForPCB, 0, 0, (float)PCBLength, (float)PCBWidth);
            graphics.DrawRectangle(penForLines, 0, 0, (float)PCBLength * scaleFactor, (float)PCBWidth * scaleFactor);
            graphics.TranslateTransform((float)offsetX * scaleFactor, (float)offsetY * scaleFactor);


            foreach (var item in placement.ElementsList)
            {
                int index = placement.ElementsInitialList.FindIndex(X => X == item);
                string marking = placement.ElementsInitialList[index].marking;

                double k = item.maxT / 130;
                colorForElement = Color.FromArgb(Convert.ToInt32(k * 250), 0, Convert.ToInt32(k / 250));

                brushForElement = new SolidBrush(colorForElement);
                SolidBrush brushForElement1 = new SolidBrush(Color.Black);
                brushForText = new SolidBrush(colorForText);
                graphics.FillRectangle(brushForElement, (float)item.position.x * scaleFactor, (float)item.position.y * scaleFactor, (float)item.length * scaleFactor, (float)item.width * scaleFactor);
                graphics.DrawRectangle(penForLines, (float)item.position.x * scaleFactor, (float)item.position.y * scaleFactor, (float)item.length * scaleFactor, (float)item.width * scaleFactor);
                float xEl = (float)(item.position.x + (float)item.length / 2) * scaleFactor;
                float yEl = (float)(item.position.y + (float)item.width / 2) * scaleFactor;
                graphics.DrawString($"{item.referenceDesignation}", new Font("Arial", 1 * scaleFactor), brushForText, xEl - Font.Size / 2, yEl - Font.Size / 2);

            }
        }

        private void RenderElements(Placement placement) //Рендеринг изображений элементов из Altium
        {

            var renderer = new PcbLibRenderer();

            if (renderer != null)
            {
                using (var reader = new PcbLibReader())
                {
                    PcbLib pcbLib = new PcbLib();
                    pcbLib = reader.Read(@$"{PCBlibFilePath}");

                    var mainImage = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                    using (var mainGraphics = Graphics.FromImage(mainImage))
                    {
                        brushForPCB = new SolidBrush(colorForPCB);
                        brushForText = new SolidBrush(colorForText);

                        mainGraphics.DrawRectangle(penForLines, 0, 0, (float)PCBLength * scaleFactor, (float)PCBWidth * scaleFactor);
                        mainGraphics.TranslateTransform((float)offsetX * scaleFactor, (float)offsetY * scaleFactor);

                        PcbLibRenderer pcbLibRenderer = new PcbLibRenderer();

                        foreach (PcbComponent component in pcbLib)
                        {
                            foreach (var element in placement.ElementsList)
                            {
                                if (component.Pattern == element.marking)
                                {
                                    renderer.Component = component;

                                    PictureBox pictureBox = new PictureBox();
                                    pictureBox.Width = (int)element.length * scaleFactor;
                                    pictureBox.Height = (int)element.width * scaleFactor;
                                    var image = new Bitmap(pictureBox.Width, pictureBox.Height);

                                    using (graphics = Graphics.FromImage(image))
                                    {
                                        if (element.rotated == true)
                                        {
                                            graphics.TranslateTransform((float)pictureBox.Width / 2, (float)pictureBox.Height / 2);
                                            graphics.RotateTransform(90);
                                            graphics.TranslateTransform(-(float)pictureBox.Width / 2, -(float)pictureBox.Height / 2);
                                        }

                                        renderer.Render(graphics, pictureBox.Width, pictureBox.Height, true, false);
                                    }

                                    mainGraphics.DrawImage(image, (float)element.position.x * scaleFactor, (float)element.position.y * scaleFactor, (float)element.length * scaleFactor, (float)element.width * scaleFactor);
                                }
                            }

                        }

                        pictureBoxMain.Image = mainImage;
                    }
                }
            }
        }

        private void FitnessStagnation() //Работа генетического алгоритма при решении задачи размещения
        {
            if (gaForm != null)
            {
                NumOfSpecies = gaForm.NumOfSpeciesInitial;
                Mutation = gaForm.MutationPercentage;
                MaxNumOfGenerationsStagnation = gaForm.FitnessStNum;
            }

            int n = 0;
            bool Stagnation = false;
            Population population = new Population(NumOfSpecies);
            ListOfParentalSpecies = new List<Chromosome>();
            ListOfParentalSpecies.AddRange(population.GenerateInitialPopulation(Data.ProjectElementsList.Count));
            //PrinList(ListOfParentalSpecies, "ListOfParentalSpecies");
            while (Stagnation != true)
            {
                k++;
                List<Chromosome> TestList = new List<Chromosome>();
                GenerateNewGeneration(population);
                ListOfSpeciesSORTED.RemoveRange(0, ListOfSpeciesSORTED.Count);
                TestList.AddRange(ListOfSpeciesUNITED);
                ListOfSpeciesSORTED.AddRange(TestList.OrderBy(x => x.Fitness).ToList());
                ListOfSpeciesSORTED.RemoveRange(ListOfSpeciesSORTED.Count() / 2, ListOfSpeciesSORTED.Count() / 2);
                //PrinList(ListOfSpeciesSORTED, "ListOfSpeciesSORTED");
                BestSpecies.Add(ListOfSpeciesSORTED[0]);

                if (BestSpecies.Count >= MaxNumOfGenerationsStagnation)
                {
                    for (int i = BestSpecies.Count - 1; i >= BestSpecies.Count - MaxNumOfGenerationsStagnation; i--)
                    {
                        if (BestSpecies[i].Fitness == BestSpecies[BestSpecies.Count - 1].Fitness)
                        {
                            n++;
                        }
                    }

                    if (n >= MaxNumOfGenerationsStagnation)
                    {
                        Stagnation = true;
                    }
                    n = 0;
                }

                if (k == 500)
                {
                    Stagnation = true;
                }

            }

        }

        private void GenerateNewGeneration(Population population) //Генерация нового поколения
        {
            if (ListOfOffspringSpecies != null)
            {
                if (ListOfOffspringSpecies.Count != 0)
                {
                    ListOfParentalSpecies.RemoveRange(0, ListOfParentalSpecies.Count);
                    ListOfParentalSpecies.AddRange(ListOfSpeciesSORTED);
                }
            }

            ListOfOffspringSpecies = new List<Chromosome>();
            ListOfOffspringSpeciesMutated = new List<Chromosome>();
            ListOfSpeciesUNITED = new List<Chromosome>();
            ListOfOffspringSpecies.AddRange(population.Crossover(Data.ProjectElementsList.Count, ListOfParentalSpecies));
            ListOfOffspringSpeciesMutated.AddRange(population.Mutation(Data.ProjectElementsList.Count, ListOfOffspringSpecies, Mutation));
            ListOfSpeciesUNITED = new List<Chromosome>();
            ListOfSpeciesUNITED.AddRange(ListOfParentalSpecies);
            ListOfSpeciesUNITED.AddRange(ListOfOffspringSpeciesMutated);

            foreach (var item in ListOfSpeciesUNITED)
            {
                placement = new Placement();
                placement.PackageStart(Data.ProjectElementsList, item.Genes, PCBOffsetLength, PCBOffsetWidth);

                if (chooseCriterion.TypeOfFitnessFunction == 1) //Тепловой критерий
                {
                    FitnessFunctionLabel.Text = "Тепловыделение Q = ";
                    txt = "Вт";
                    item.Fitness = fitness.CountThermalCriteria(placement.ElementsList, placement.ElementsInitialList);
                }
                if (chooseCriterion.TypeOfFitnessFunction == 2) //Минимизация длины межсоединений
                {
                    FitnessFunctionLabel.Text = "Длина межсоединений L = ";
                    txt = "мм";


                    item.Fitness = fitness.CountDistanceCriteria(placement.ElementsList, DataBasePath);
                }
                if (chooseCriterion.TypeOfFitnessFunction == 3) //Свертка двух критериев
                {
                    FitnessFunctionLabel.Text = "Целевая функция (2 критерия) F = ";
                    item.Fitness = chooseCriterion.W1 * fitness.CountThermalCriteria(placement.ElementsList, placement.ElementsInitialList) + chooseCriterion.W2 * fitness.CountDistanceCriteria(placement.ElementsList, DataBasePath);
                }

                foreach (var item1 in placement.ElementsList)
                {
                    if (((item1.position.x + item1.length) > PCBOffsetLength) || ((item1.position.y + item1.width) > PCBOffsetWidth))
                    {
                        item.Fitness = double.MaxValue;
                    }
                }
            }
        }

        private void создатьПроектToolStripMenuItem_Click(object sender, EventArgs e) //Создание нового проекта
        {
            newProjectForm = new NewProjectForm();
            newProjectForm.ShowDialog();
            DbPathLabel.Text = "Путь к БД: " + newProjectForm.DBProjectPath;
            DataBasePath = newProjectForm.DBProjectPath;
            ProjectID = newProjectForm.ProjectID;
            ProjectIDLabel.Text = "Код проекта: " + ProjectID.ToString();
            выбратьПечатнуюПлатуToolStripMenuItem.Enabled = true;
            GetData();
            добавитьВБДНовыйЭлементToolStripMenuItem.Enabled = true;
            добавитьЭлементыВПроектToolStripMenuItem.Enabled = true;
            просмотрЭлементовПроектаToolStripMenuItem.Enabled = true;
            PCBlibFilePath = null;
            string textForNewProjectConfirmation = $"Проект {ProjectID} был успешно создан!";
            ExceptionOrConfirmationForm exceptionOrConfirmationForm = new ExceptionOrConfirmationForm(textForNewProjectConfirmation);
            exceptionOrConfirmationForm.ShowDialog();
            PCBLengthLabel.Text = "";
        }

        private void открытьПроектToolStripMenuItem_Click(object sender, EventArgs e) //Открытие проекта
        {
            selectProject = new SelectProject();
            selectProject.ShowDialog();
            DataBasePath = selectProject.DbPath;
            DbPathLabel.Text = "Путь к БД: " + selectProject.DbPath;
            ProjectID = selectProject.ProjectID;
            PCBID = selectProject.PCBID;
            ProjectIDLabel.Text = "Код проекта: " + ProjectID.ToString();
            выбратьПечатнуюПлатуToolStripMenuItem.Enabled = true;
            GetData();
            GetPCBData();
            добавитьВБДНовыйЭлементToolStripMenuItem.Enabled = true;
            добавитьЭлементыВПроектToolStripMenuItem.Enabled = true;
            просмотрЭлементовПроектаToolStripMenuItem.Enabled = true;
            PCBlibFilePath = null;
        }

        private void добавитьВБДНовыйЭлементToolStripMenuItem_Click(object sender, EventArgs e) //Добавление в БД нового элемента
        {
            NewElement newElement = new NewElement(DataBasePath);
            newElement.ShowDialog();
            string textForNewElementInDb = $"Новый элемент {newElement.Name} был успешно добавлен в БД!";
            ExceptionOrConfirmationForm exceptionOrConfirmationForm = new ExceptionOrConfirmationForm(textForNewElementInDb);
            exceptionOrConfirmationForm.ShowDialog();
        }

        private void GetData() //Получение исходных данных
        {
            if (DataBasePath != null)
            {
                database = new Database(Path.GetFileNameWithoutExtension(DataBasePath), Path.GetDirectoryName(DataBasePath));
            }
            else
            {
                database = new Database(newDatabaseForm.DBName, newDatabaseForm.DBPath);
            }
            Data = new InputData(database, ProjectID);
        }

        private void добавитьТаблицуВБДToolStripMenuItem_Click(object sender, EventArgs e) //Добавление таблицы в БД
        {
            NewTable newTable = new NewTable();
            newTable.ShowDialog();
            string textForNewTableInDb = $"Новая таблица {newTable.Name} была успешно добавлена в БД!";
            ExceptionOrConfirmationForm exceptionOrConfirmationForm = new ExceptionOrConfirmationForm(textForNewTableInDb);
            exceptionOrConfirmationForm.ShowDialog();
        }

        private void добавитьВБДНовуюППToolStripMenuItem_Click(object sender, EventArgs e) //Добавление ПП в БД
        {
            NewPCB newPCB = new NewPCB();
            newPCB.ShowDialog();
            string textForNewPCB = $"Новая ПП {newPCB.Name} была успешно добавлена в БД!";
            ExceptionOrConfirmationForm exceptionOrConfirmationForm = new ExceptionOrConfirmationForm(textForNewPCB);
            exceptionOrConfirmationForm.ShowDialog();
        }

        private void RemoveAllElements(List<Chromosome> list) //Удаление элементов из списка
        {
            if (list != null)
            {
                list.RemoveRange(0, list.Count);
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e) //Вывод справки
        {
            Info info = new Info();
            info.Show();
        }

        private void выбратьПечатнуюПлатуToolStripMenuItem_Click(object sender, EventArgs e) //Выбор ПП
        {
            selectPCB = new SelectPCB(Data, ProjectID);
            selectPCB.ShowDialog();
            PCBID = selectPCB.PCBID;
            GetPCBData();
        }



        private void создатьБДToolStripMenuItem_Click(object sender, EventArgs e) //Создание БД
        {
            newDatabaseForm = new NewDatabaseForm();
            newDatabaseForm.Show();
        }

        private void добавитьЭлементыВПроектToolStripMenuItem_Click(object sender, EventArgs e) //Добавление элементов в проект
        {
            AddElementsToProject addElementsToProject = new AddElementsToProject(Data);
            addElementsToProject.ShowDialog();
        }

        private void просмотрЭлементовПроектаToolStripMenuItem_Click(object sender, EventArgs e) //Просмотр элементов проекта
        {
            GetData();
            ElementsOfProject elementsOfProject = new ElementsOfProject(Data);
            elementsOfProject.ShowDialog();
        }


        private void настроитьГенетическийАлгоритмToolStripMenuItem_Click_1(object sender, EventArgs e) //Настройка генетического алгоритма
        {
            gaForm = new GAForm();
            gaForm.Show();
        }

        private void выбратьКритерийРазмещенияToolStripMenuItem_Click(object sender, EventArgs e) //Выбор критерия размещения
        {
            chooseCriterion = new ChooseCriterion();
            chooseCriterion.ShowDialog();
        }

        private void загрузитьЭлементыИзPCBlibToolStripMenuItem_Click(object sender, EventArgs e) //Метод, загружющий данные об элементах из PCBlib
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            if (openPCBlibFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            PCBlibFilePath = openPCBlibFileDialog.FileName;

            string path = @$"URI=file:{DataBasePath}";
            using var connection = new SQLiteConnection(path);
            connection.Open();

            using (var reader = new PcbLibReader())
            {
                PcbLib pcbLib = new PcbLib();
                // Read the file.
                pcbLib = reader.Read(@$"{PCBlibFilePath}");

                foreach (PcbComponent component in pcbLib) //Перебор каждого элемента
                {
                    CoordRect bounds = component.CalculateBounds();
                    Coord width = bounds.Width;
                    Coord height = bounds.Height;
                    string Marking = component.Pattern;
                    double LengthInMm = Math.Round(bounds.Width.ToMMs(), 2);
                    double WidthInMm = Math.Round(bounds.Height.ToMMs(), 2);
                    using var connection1 = new SQLiteConnection(path);
                    connection1.Open();
                    using var cmd1 = new SQLiteCommand(connection1);
                    PCBlibRead pCBlibRead = new PCBlibRead(Marking, LengthInMm, WidthInMm);
                    pCBlibRead.ShowDialog();

                    string NewElementsQuery = $"INSERT INTO Элементы (МаркировкаЭлемента, НазваниеЭлемента, ДлинаЭлемента, ШиринаЭлемента, ВысотаЭлемента, МаксимальнаяТемператураЭлемента) VALUES('" + Marking + "', '" + pCBlibRead.ElementName + "', " + LengthInMm + ", " + WidthInMm + ", " + pCBlibRead.ElementHeight + ", " + pCBlibRead.ElementMaxT + ")";

                    cmd1.CommandText = @NewElementsQuery;
                    cmd1.ExecuteNonQuery();
                }
            }
        }

        private void загрузитьИзображенияИзPCBlibToolStripMenuItem_Click(object sender, EventArgs e) //Загрузка графических изображений из Altium
        {
            if (openPCBlibFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            PCBlibFilePath = openPCBlibFileDialog.FileName;
        }

        private void загрузитьФайлСИнформациейОМежсоединенияхToolStripMenuItem_Click_1(object sender, EventArgs e) //Загрузка файла с информацией о межсоединениях
        {
            NetsInputData netsInputData = new NetsInputData();
            netsInputData.ShowDialog();
            netsInputData.GetNetData(DataBasePath, ProjectID);
        }

        private void SizeTrackBar_Scroll(object sender, EventArgs e) //Масштабирование
        {
            scaleFactor = SizeTrackBar.Value;
            if (PCBlibFilePath != null)
            {
                RenderElements(placement);
            }
            else
            {
                PrintElements();
            }
        }

        private void pictureBoxMain_Click(object sender, EventArgs e) //Вывод данных об элементе при нажатии на него
        {

            var mouseEventArgs = e as MouseEventArgs;
            if (mouseEventArgs != null)
            {
                X = mouseEventArgs.X;
                Y = mouseEventArgs.Y;
            }

            foreach (var item in placement.ElementsList)
            {
                int index = placement.ElementsInitialList.FindIndex(x => x == item);

                if (X >= (item.position.x * scaleFactor + offsetX * scaleFactor) && X <= ((item.position.x + item.length) * scaleFactor + offsetX * scaleFactor) && Y >= (item.position.y * scaleFactor + offsetY * scaleFactor) && Y <= ((item.position.y + item.width) * scaleFactor + offsetY * scaleFactor))
                {
                    SelectedElInfoLabel.Visible = true;
                    SelectedElementMarkingLabel.Text = item.marking;
                    SelectedElementRefDLabel.Text = item.referenceDesignation;
                    SelectedElementLength.Text = $"Длина: {item.length} мм";
                    SelectedElementWidth.Text = $"Ширина: {item.width} мм";
                    SelectedElementX.Text = $"X: {Math.Round(item.position.x, 2)}";
                    SelectedElementY.Text = $"Y: {Math.Round(item.position.y, 2)}";
                    ElementMaxTlabel.Text = $"T = {item.maxT}";
                }
            }
        }

        private void настроитьОтступыToolStripMenuItem_Click(object sender, EventArgs e) //Настройка отступов
        {
            PCBMargins pCBMargins = new PCBMargins();
            pCBMargins.ShowDialog();
            offsetX = pCBMargins.OffsetX;
            offsetY = pCBMargins.OffsetY;
        }
    }
}
