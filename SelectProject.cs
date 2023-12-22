using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementPlacement
{
    public partial class SelectProject : Form
    {
        //Класс, осуществляющий выбор проекта
        InputData inputData { get; set; }
        string[] strings;
        public int ProjectID;
        public int PCBID;
        public string DbPath;

        public SelectProject()
        {
            InitializeComponent();
        }



        private void OpenDbButton_Click(object sender, EventArgs e)
        {
            if (openDbDialog.ShowDialog() == DialogResult.Cancel)
                return;
            DbPath = openDbDialog.FileName;
            DbOfExProjectPathLabel.Text = DbPath;
            GetProjectData();
        }

        private void GetProjectData() //Получение данных о проектах из БД
        {
            Database database = new Database(Path.GetFileNameWithoutExtension(DbPath), Path.GetDirectoryName(DbPath));
            inputData = new InputData(database, ProjectID);
            strings = new string[inputData.ListOfProjects.Count];

            for (int i = 0; i < inputData.ListOfProjects.Count; i++)
            {
                if (inputData.ListOfProjects[i].ProjectID != int.MaxValue)
                {
                    strings[i] = $"Код проекта: {inputData.ListOfProjects[i].ProjectID} Название проекта: {inputData.ListOfProjects[i].ProjectName} Код ПП: {inputData.ListOfProjects[i].PCBID}";
                }
                else
                {
                    strings[i] = $"Код проекта: {inputData.ListOfProjects[i].ProjectID} Название проекта: {inputData.ListOfProjects[i].ProjectName} Код ПП: Отсутствует";
                }
            }

            SelectProjectlistBox.Items.AddRange(strings);

        }

        private void SelectProjectlistBox_SelectedIndexChanged(object sender, EventArgs e) //Выбор необходимого проекта
        {
            string SelectedProject = SelectProjectlistBox.SelectedItem.ToString();
            for (int i = 0; i < inputData.ListOfProjects.Count; i++)
            {
                if (SelectedProject == strings[i])
                {
                    ProjectID = inputData.ListOfProjects[i].ProjectID;
                    PCBID = inputData.ListOfProjects[i].PCBID;
                }
            }

        }

        private void SelectProjectOKbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
