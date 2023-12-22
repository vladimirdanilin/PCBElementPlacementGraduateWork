using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementPlacement
{
    public partial class NewTable : Form
    {
        //Класс, позволяющий создать новую таблицу в БД
        public string DBPath { get; set; }
        public string TableName { get; set; }
        public string Column1Name { get; set; }
        public string Column2Name { get; set; }
        public string Column3Name { get; set; }
        public string Column4Name { get; set; }
        public string Column5Name { get; set; }
        public string Column6Name { get; set; }
        public string Column1Type { get; set; }
        public string Column2Type { get; set; }
        public string Column3Type { get; set; }
        public string Column4Type { get; set; }
        public string Column5Type { get; set; }
        public string Column6Type { get; set; }
        string ForNewTableQuery { get; set; }
        public NewTable()
        {
            InitializeComponent();
        }

        private void TableFormChooseDBbtn_Click(object sender, EventArgs e)
        {
            if (ChooseDbForTable.ShowDialog() == DialogResult.Cancel)
                return;
            DBPath = ChooseDbForTable.FileName;
            ChooseDbPathForTableLabel.Text = DBPath;
        }

        private void NewTableName_TextChanged(object sender, EventArgs e)
        {
            TableName = NewTableName.Text;
        }

        private void Column1_TextChanged(object sender, EventArgs e)
        {
            Column1Name = Column1.Text;
        }

        private void Column2_TextChanged(object sender, EventArgs e)
        {
            Column2Name = Column2.Text;
        }

        private void Column3_TextChanged(object sender, EventArgs e)
        {
            Column3Name = Column3.Text;
        }

        private void Column4_TextChanged(object sender, EventArgs e)
        {
            Column4Name = Column4.Text;
        }

        private void Column5_TextChanged(object sender, EventArgs e)
        {
            Column5Name = Column5.Text;
        }

        private void Column6_TextChanged(object sender, EventArgs e)
        {
            Column6Name = Column6.Text;
        }

        private void Column1INT_CheckedChanged(object sender, EventArgs e)
        {
            Column1Type = "INTEGER";
        }

        private void Column1DOUBLE_CheckedChanged(object sender, EventArgs e)
        {
            Column1Type = "DOUBLE";
        }

        private void Column1STR_CheckedChanged(object sender, EventArgs e)
        {
            Column1Type = "TEXT";
        }

        private void Column2INT_CheckedChanged(object sender, EventArgs e)
        {
            Column2Type = "INTEGER";
        }

        private void Column2DOUBLE_CheckedChanged(object sender, EventArgs e)
        {
            Column2Type = "DOUBLE";
        }

        private void Column2STR_CheckedChanged(object sender, EventArgs e)
        {
            Column2Type = "TEXT";
        }

        private void Column3INT_CheckedChanged(object sender, EventArgs e)
        {
            Column3Type = "INTEGER";
        }

        private void Column3DOUBLE_CheckedChanged(object sender, EventArgs e)
        {
            Column3Type = "DOUBLE";
        }

        private void Column3STR_CheckedChanged(object sender, EventArgs e)
        {
            Column3Type = "TEXT";
        }

        private void Column4INT_CheckedChanged(object sender, EventArgs e)
        {
            Column4Type = "INTEGER";
        }

        private void Column4DOUBLE_CheckedChanged(object sender, EventArgs e)
        {
            Column4Type = "DOUBLE";
        }

        private void Column4STR_CheckedChanged(object sender, EventArgs e)
        {
            Column4Type = "TEXT";
        }

        private void Column5INT_CheckedChanged(object sender, EventArgs e)
        {
            Column5Type = "INTEGER";
        }

        private void Column5DOUBLE_CheckedChanged(object sender, EventArgs e)
        {
            Column5Type = "DOUBLE";
        }

        private void Column5STR_CheckedChanged(object sender, EventArgs e)
        {
            Column5Type = "TEXT";
        }

        private void Column6INT_CheckedChanged(object sender, EventArgs e)
        {
            Column6Type = "INTEGER";
        }

        private void Column6DOUBLE_CheckedChanged(object sender, EventArgs e)
        {
            Column6Type = "DOUBLE";
        }

        private void Column6STR_CheckedChanged(object sender, EventArgs e)
        {
            Column6Type = "TEXT";
        }

        private void NewTableCreateBtn_Click(object sender, EventArgs e)
        {
            ForNewTableQuery = $"CREATE TABLE {TableName}({Column1Name} {Column1Type} PRIMARY KEY";

            if (string.IsNullOrEmpty(Column2Name) == false)
            {
                ForNewTableQuery += $", {Column2Name} {Column2Type}";
            }

            if (string.IsNullOrEmpty(Column3Name) == false)
            {
                ForNewTableQuery += $", {Column3Name} {Column3Type}";
            }

            if (string.IsNullOrEmpty(Column4Name) == false)
            {
                ForNewTableQuery += $", {Column4Name} {Column4Type}";
            }

            if (string.IsNullOrEmpty(Column5Name) == false)
            {
                ForNewTableQuery += $", {Column5Name} {Column5Type}";
            }

            if (string.IsNullOrEmpty(Column6Name) == false)
            {
                ForNewTableQuery += $", {Column6Name} {Column6Type}";
            }
            ForNewTableQuery += ")";


            bool exception = false;
            try
            {
                string path = @$"URI=file:{DBPath}";
                using var connection = new SQLiteConnection(path);
                connection.Open();
                using var cmd = new SQLiteCommand(connection);

                cmd.CommandText = @ForNewTableQuery;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ExceptionOrConfirmationForm exceptionForm = new ExceptionOrConfirmationForm("Ошибка");
                exceptionForm.ShowDialog();
                exception = true;
            }
            finally
            {
                if (!exception)
                {
                    Close();
                }
            }

            
        }
    }
}
