using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementPlacement
{
    //Класс, отображающий пользователю элементы проекта
    public partial class ElementsOfProject : Form
    {
        public ElementsOfProject(InputData inputData)
        {
            InitializeComponent();
            InputData = inputData;
            GetElementData();
        }
        InputData InputData;

        public void GetElementData()
        {
            ElementsOfProjectLabel.Text = "";

            for (int i = 0; i < InputData.ProjectElementsList.Count; i++)
            {
                ElementsOfProjectLabel.Text += $"Маркировка: {InputData.ProjectElementsList[i].marking} Название: {InputData.ProjectElementsList[i].name} Длина: {InputData.ProjectElementsList[i].length} Ширина: {InputData.ProjectElementsList[i].width} Высота: {InputData.ProjectElementsList[i].thickness} Максимальная температура: {InputData.ProjectElementsList[i].maxT} Поз. обозначение: {InputData.ProjectElementsList[i].referenceDesignation} \n";
            }
        }

        private void ElementsOfProjectOKbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
