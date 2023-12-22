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
    public partial class NewProjectForm : Form
    {
        //Класс, позволяющий создать новый проект
        public NewProjectForm()
        {
            InitializeComponent();
        }

        public string DBProjectPath { get; set; }
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }

        private void DBProjectPathbtn_Click(object sender, EventArgs e)
        {
            if (ProjectDbFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            DBProjectPath = ProjectDbFileDialog.FileName;
            DBPathProjectLabel.Text = DBProjectPath;
        }

        private void ProjectIdTextbox_TextChanged(object sender, EventArgs e)
        {
            ProjectID = Convert.ToInt32(ProjectIdTextbox.Text);
        }

        private void NewProjectNameInput_TextChanged(object sender, EventArgs e)
        {
            ProjectName = NewProjectNameInput.Text;
        }

        private void NewProjectSave_Click(object sender, EventArgs e) //Сохранение данных о новом проекте в БД
        {
            string str = @$"URI=file:{DBProjectPath}";

            using var con = new SQLiteConnection(str);
            con.Open();

            using var cmd = new SQLiteCommand(con);
            string NewElementsQuery = $"INSERT INTO Проект (КодПроекта, НазваниеПроекта) VALUES(" + ProjectID + ", '" + ProjectName + "')";

            cmd.CommandText = NewElementsQuery;

            cmd.ExecuteNonQuery();
            Close();
        }
    }
}
