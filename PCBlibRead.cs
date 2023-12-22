using OriginalCircuit.AltiumSharp;
using OriginalCircuit.AltiumSharp.BasicTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementPlacement
{
    public partial class PCBlibRead : Form
    {
        //Класс, дополняющий информацию об элементах, загруженных из PCBlib
        public string ElementName { get; set; } //Название элемента
        public double ElementHeight { get; set; } //Высота элемента
        public double ElementMaxT { get; set; } //Максимальная температура элемента

        public PCBlibRead(string elementMarking, double elementLength, double elementWidth)
        {
            InitializeComponent();
            NameOfCurrentElement.Text = "Маркировка элемента: " + elementMarking;
            LengthOfCurrentElement.Text = "Длина элемента: " + elementLength.ToString();
            WidthOfCurrentElement.Text = "Ширина элемента: " + elementWidth.ToString();
        }

        private void PCBlibElementMarkingTextBox_TextChanged(object sender, EventArgs e)
        {
            ElementName = PCBlibElementNameTextBox.Text;
        }

        private void PCBlibElementHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            ElementHeight = Convert.ToDouble(PCBlibElementHeightTextBox.Text);
        }

        private void PCBlibElementTTextBox_TextChanged(object sender, EventArgs e)
        {
            ElementMaxT = Convert.ToDouble(PCBlibElementTTextBox.Text);
        }

        private void PCBlibFormOKbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
