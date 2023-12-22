using System;
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

namespace ElementPlacement
{
    public partial class NewElement : Form
    {
        //Добавление нового элемента в БД
        public NewElement(string dataBasePath)
        {
            InitializeComponent();
            DataBasePath = dataBasePath;
        }

        public string DataBasePath { get; set; } //Путь к БД
        public string NewElementMarking { get; set; } //Маркировка элемента
        public string NewElementName { get; set; } //Название элемента
        public double NewElementLength { get; set; } //Длина элемента
        public double NewElementWidth { get; set; } //Ширина элемента
        public double NewElementThickness { get; set; } //Высота элемента
        public double NewElementMaxTemp { get; set; } //Максимальная температура элемента

        private void NewElementNameInput_TextChanged(object sender, EventArgs e)
        {
            NewElementName = NewElementNameInput.Text;
        }

        private void NewElementLengthInput_TextChanged(object sender, EventArgs e)
        {
            NewElementLength = Convert.ToDouble(NewElementLengthInput.Text);
        }

        private void NewElementWidthInput_TextChanged(object sender, EventArgs e)
        {
            NewElementWidth = Convert.ToDouble(NewElementWidthInput.Text);
        }

        private void NewElementHeightInput_TextChanged(object sender, EventArgs e)
        {
            NewElementThickness = Convert.ToDouble(NewElementHeightInput.Text);
        }

        private void NewElementTempInput_TextChanged(object sender, EventArgs e)
        {
            NewElementMaxTemp = Convert.ToDouble(NewElementTempInput.Text);
        }

        private void NewElementMarkInput_TextChanged(object sender, EventArgs e)
        {
            NewElementMarking = NewElementMarkInput.Text;
        }

        private void NewElementBtn_Click(object sender, EventArgs e) // Добавление нового элемента в БД
        {
            string str = @$"URI=file:{DataBasePath}";

            using var con = new SQLiteConnection(str);
            con.Open();

            using var cmd = new SQLiteCommand(con);
            string NewElementsQuery = $"INSERT INTO Элементы (МаркировкаЭлемента, НазваниеЭлемента, ДлинаЭлемента, ШиринаЭлемента, ВысотаЭлемента, МаксимальнаяТемператураЭлемента) VALUES('" + NewElementMarking + "', '" + NewElementName + "', " + NewElementLength + ", " + NewElementWidth + ", " + NewElementThickness + ", " + NewElementMaxTemp + ")";
            //cmd.CommandText = $"INSERT INTO {NewElementTableName} (Name, Length, Width, Thickness, MaxTemp) VALUES({NewElementName}, {NewElementLength}, {NewElementWidth}, {NewElementThickness}, {NewElementMaxTemp})";
            //cmd.CommandText = $"INSERT INTO {NewElementTableName} (Name, Length, Width, Thickness, MaxTemp) VALUES('" + NewElementName + "', " + NewElementLength + ", " + NewElementWidth + ", " + NewElementThickness + ", " + NewElementMaxTemp + ")";
            cmd.CommandText = NewElementsQuery;

            cmd.ExecuteNonQuery();

            Close();
        }


    }
}
