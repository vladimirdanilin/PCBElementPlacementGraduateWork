using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SQLite;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ElementPlacement.Placement;

namespace ElementPlacement
{
    public class InputData
    {
        //Метод, реализующий получение данных из БД

        public List<Element> AllElementsList = new List<Element>(); //Список, хранящий все элементы БД
        public List<Element> ProjectElementsList = new List<Element>(); //Список, хранящий все элементы проекта
        public class Project
        {
            public int ProjectID; //Код проекта
            public string ProjectName; //Название проекта
            public int PCBID; //Код ПП
        }

        public class PCB //Класс ПП
        {
            public int PCBID;
            public string PCBName;
            public double PCBLength;
            public double PCBWidth;
        }
        public List<Project> ListOfProjects = new List<Project>();
        public List<PCB> ListOfPCBs = new List<PCB>();

        public string DBFullPath { get; set; }

        public string PCBTableName { get; set; }

        public int ProjectID { get; set; }

        Database DataBase;

        public InputData(Database database, int projectID)
        {
            DataBase = database;
            DBFullPath = DataBase.FullPath;
            ProjectID = projectID;
            GetElementSizes();
            GetPCBData();
            GetProjectsData();
            if (ProjectID != 0)
            {
                GetProjectFullElementData();
            }
        }


        private void GetProjectFullElementData() //Получение данных обо всех элементах проекта
        {
            string str = @$"URI=file:{DBFullPath}";

            using var con = new SQLiteConnection(str);
            con.Open();

            string stm = $"SELECT * FROM ЭлементыПроекта";

            using var cmd = new SQLiteCommand(stm, con);
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            using var cmd1 = new SQLiteCommand(stm, con);
            using SQLiteDataReader rdr1 = cmd1.ExecuteReader();

            int i = 0;
            while (rdr.Read())
            {
                if (rdr.GetInt32(0) == ProjectID)
                {
                    Element newElement = new Element();
                    //newElement.position = AllElementsList.Find(p => p.marking == rdr.GetString(1)).position;
                    newElement.thickness = AllElementsList.Find(p => p.marking == rdr.GetString(1)).thickness;
                    newElement.width = AllElementsList.Find(p => p.marking == rdr.GetString(1)).width;
                    newElement.name = AllElementsList.Find(p => p.marking == rdr.GetString(1)).name;
                    newElement.length = AllElementsList.Find(p => p.marking == rdr.GetString(1)).length;
                    newElement.marking = AllElementsList.Find(p => p.marking == rdr.GetString(1)).marking;
                    //newElement.rotated = AllElementsList.Find(p => p.marking == rdr.GetString(1)).rotated;
                    //newElement.CloseElements = AllElementsList.Find(p => p.marking == rdr.GetString(1)).CloseElements;
                    newElement.maxT = AllElementsList.Find(p => p.marking == rdr.GetString(1)).maxT;
                    newElement.referenceDesignation = rdr.GetString(2);
                    ProjectElementsList.Add(newElement);
                    i++;
                }
            }
        }

        private void GetElementSizes() //Получение параметров элементов из БД
        {
            string str = @$"URI=file:{DBFullPath}";

            using var con = new SQLiteConnection(str);
            con.Open();

            string stm = $"SELECT * FROM Элементы";

            using var cmd = new SQLiteCommand(stm, con);
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            int i = 0;
            while (rdr.Read()) 
            {
                Element element = new Element();
                element.marking = rdr.GetString(0);
                element.name = rdr.GetString(1);
                element.length = rdr.GetDouble(2);
                element.width = rdr.GetDouble(3);
                element.thickness = rdr.GetDouble(4);
                element.maxT = rdr.GetDouble(5);
                AllElementsList.Add(element);
            }

        }

        private void GetPCBData() //Получение параметров ПП
        {
            string str = @$"URI=file:{DBFullPath}";

            using var con = new SQLiteConnection(str);
            con.Open();

            string stm = $"SELECT * FROM ПечатнаяПлата";

            using var cmd = new SQLiteCommand(stm, con);
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                PCB pCB = new PCB();
                pCB.PCBID = Convert.ToInt32($"{rdr.GetInt32(0)}");
                pCB.PCBName = $"{rdr.GetString(1)}";
                pCB.PCBLength = Convert.ToDouble($"{rdr.GetDouble(2)}");
                pCB.PCBWidth = Convert.ToDouble($"{rdr.GetDouble(3)}");
                ListOfPCBs.Add(pCB);
            }
        }

        private void GetProjectsData() //Получение данных о проекте
        {
            string str = @$"URI=file:{DBFullPath}";

            using var con = new SQLiteConnection(str);
            con.Open();

            string stm = $"SELECT * FROM Проект";

            using var cmd = new SQLiteCommand(stm, con);
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Project project = new Project();
                project.ProjectID = Convert.ToInt32($"{rdr.GetInt32(0)}");
                project.ProjectName = $"{rdr.GetString(1)}";
                ListOfProjects.Add(project);

                int tempID = Convert.ToInt32($"{rdr.GetInt32(0)}");
                string tempName = $"{rdr.GetString(1)}";

                if (rdr[2].GetType() != typeof(DBNull))
                {
                    int tempPCB = Convert.ToInt32($"{rdr.GetInt32(2)}");
                    project.PCBID = Convert.ToInt32($"{rdr.GetInt32(2)}");
                }
                else
                {
                    project.PCBID = int.MaxValue;
                }
            }
        }
    }
}
