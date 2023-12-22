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
    public partial class NewPCB : Form
    {
        //Класс, реализующий добавление новой ПП в БД
        public NewPCB()
        {
            InitializeComponent();
        }

        public int NewPCBID { get; set; } //Код ПП
        public string NewPCBName { get; set; } //Название ПП
        public string NewPCBDBName { get; set; } //Название БД
        public string NewPCBDBPath { get; set; } //Путь к БД
        public string NewPCBTableName { get; set; } //Название таблицы
        public double NewPCBLength { get; set; } // Длина ПП
        public double NewPCBWidth { get; set; } // Ширина ПП

        private void NewPCBIDInput_TextChanged(object sender, EventArgs e)
        {
            NewPCBID = Convert.ToInt32(NewPCBIDInput.Text);
        }

        private void NewPCBNameInput_TextChanged(object sender, EventArgs e)
        {
            NewPCBName = NewPCBNameInput.Text;
        }

        private void PCBDbInputBtn_Click(object sender, EventArgs e)
        {
            if (DbPcbFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            NewPCBDBPath = @DbPcbFileDialog.FileName;
            NewPCBDbPathLabel.Text = NewPCBDBPath;
            NewPCBDBName = Path.GetFileNameWithoutExtension(@DbPcbFileDialog.FileName);
        }

        private void NewPCBTableInput_TextChanged(object sender, EventArgs e)
        {
            NewPCBTableName = NewPCBTableInput.Text;
        }

        private void NewPCBLengthInput_TextChanged(object sender, EventArgs e)
        {
            NewPCBLength = Convert.ToDouble(NewPCBLengthInput.Text);
        }

        private void NewPCBWidthInput_TextChanged(object sender, EventArgs e)
        {
            NewPCBWidth = Convert.ToDouble(NewPCBWidthInput.Text);
        }

        private void NewPCBBtn_Click(object sender, EventArgs e) //Добавление новой ПП в БД
        {
            string str = @$"URI=file:{NewPCBDBPath}";

            using var con = new SQLiteConnection(str);
            con.Open();

            using var cmd = new SQLiteCommand(con);
            string NewPCBQuery = $"INSERT INTO {NewPCBTableName} (КодПП, НазваниеПП, ДлинаПП, ШиринаПП) VALUES(" + NewPCBID + ", '" + NewPCBName + "', " + NewPCBLength + ", " + NewPCBWidth + ")";

            cmd.CommandText = NewPCBQuery;

            cmd.ExecuteNonQuery();

            Close();
        }


    }
}
