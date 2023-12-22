using System;
using System.Windows.Forms;

namespace ElementPlacement
{
    public partial class NewDatabaseForm : Form
    {
        public NewDatabaseForm() //Создание новой БД
        {
            InitializeComponent();
        }

        public string DBName { get; set; }
        public string DBPath { get; set; }
        string dBName = "";


        private void NewDBNameInput_TextChanged_1(object sender, EventArgs e) //Название НОВОЙ БД
        {
            dBName = NewDBNameInput.Text;
        }


        private void DBPathbtn_Click(object sender, EventArgs e) //Указание пути к БД (новой/существующей)
        {
            if (DBPathBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;
            DBPath = DBPathBrowserDialog.SelectedPath;
            DBPathLabel.Text = DBPath;
        }

        private void DbDataSave_Click(object sender, EventArgs e) //Нажатие на кнопку ОК
        {
            DBName = dBName;
            Database database = new Database(DBName, DBPath);
            database.CreateDatabase();
            Close();

        }
    }
}
