using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementPlacement
{
    public class Placement
    {
        public Placement()
        {

        }
        public class Node //Класс, необходимый для определения свободного пространства для размещения элемента
        {
            public Node right;
            public Node down;
            public double x;
            public double y;
            public double length;
            public double width;
            public bool used;
            public bool rotated;
        }

        public List<Element> ElementsList = new List<Element>(); //Хранит текущий порядок элементов
        public List<Element> ElementsInitialList = new List<Element>(); //Хранит исходный порядок элементов

        public class Element //Класс, содержащий параметры элементов
        {
            public string marking;
            public string name;
            public string referenceDesignation;
            public double width;
            public double length;
            public double thickness;
            public double maxT;
            public int[] CloseElements = new int[4];
            public Node position;
            public bool rotated;
        }

        private Node root;

        public void PackageStart(List<Element> elements, int[] sequenceOfElements, double PCBlength, double PCBwidth) //Запуск процедуры размещения
        {
            ElementsList.AddRange(elements);


            ElementsInitialList.AddRange(ElementsList);

            for (int i = 0; i < sequenceOfElements.Length; i++)
            {
                ElementsList[i] = ElementsInitialList[sequenceOfElements[i]];
            }

            Pack(PCBlength, PCBwidth);
        }

        private void Pack(double PCBlength, double PCBwidth) //Метод, решающий задачу плотной ортогональной упаковки
        {
            root = new Node { length = PCBlength, width = PCBwidth };

            foreach (var element in ElementsList)
            {
                var node = SearchForNode(root, element.length, element.width); //Проверяем, можно ли в root вместить элемент
                if (node != null)
                {
                    {
                        if (node.rotated)
                        {
                            double tmp = 0;
                            tmp = element.length;
                            element.length = element.width;
                            element.width = tmp;
                            element.rotated = true;
                        }
                    }
                    if (node != null)
                    {
                        element.position = GetSpace(node, element.length, element.width);   //Определение свободного пространства для последующего размещения элементов
                    }

                }
                else
                {
                    element.position = new Node { x = PCBlength + 10, y = PCBwidth + 10 };
                }
            }
        }

        private Node SearchForNode(Node root, double elength, double ewidth) //Поиск свободного пространства для размещения элемента
        {
            if (root.used)
            {
                var nextNode = SearchForNode(root.right, elength, ewidth);

                if (nextNode == null)
                {
                    //nextNode = SearchForNode(root.down, elength, ewidth);

                    nextNode = SearchForNode(root.right, ewidth, elength);
                    if (nextNode != null) { nextNode.rotated = true; }

                    if (nextNode == null)
                    {
                        nextNode = SearchForNode(root.down, elength, ewidth);
                    }

                }

                return nextNode;
            }
            else if (elength <= root.length && ewidth <= root.width)
            {
                return root;
            }
            else
            {
                return null;
            }
        }

        private Node GetSpace(Node currentNode, double elength, double ewidth) //Определение пространства для размещения последующих элементов
        {
            currentNode.used = true;
            currentNode.down = new Node { x = currentNode.x, y = currentNode.y + ewidth, length = currentNode.length, width = currentNode.width - ewidth };
            currentNode.right = new Node { x = currentNode.x + elength, y = currentNode.y, length = currentNode.length - elength, width = ewidth };
            return currentNode;
        }
    }
}
