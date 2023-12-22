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
    //Класс, осуществляющий выбор ПП
    public partial class SelectPCB : Form
    {
        InputData InputData { get; set; }
        string SelectedPCB { get; set; }
        public int ProjectID { get; set; }
        public int PCBID { get; set; }
        string[] strings;

        public SelectPCB(InputData inputData, int projectID)
        {
            InputData = inputData;
            InitializeComponent();
            GetData();
            ProjectID = projectID;
        }

        void GetData() //Выведение списка ПП для пользователя
        {
            strings = new string[InputData.ListOfPCBs.Count];
            for (int i = 0; i < InputData.ListOfPCBs.Count; i++)
            {
                strings[i] = $"Код ПП: {InputData.ListOfPCBs[i].PCBID} Название ПП: {InputData.ListOfPCBs[i].PCBName} Длина: {InputData.ListOfPCBs[i].PCBLength} Ширина: {InputData.ListOfPCBs[i].PCBWidth}";
            }

            SelectPCBlistBox.Items.AddRange(strings);
        }
        private void SelectPCBlistBox_SelectedIndexChanged(object sender, EventArgs e) //Выбор пользователем необходимой ПП
        {
            SelectedPCB = SelectPCBlistBox.SelectedItem.ToString();
            for (int i = 0; i < InputData.ListOfPCBs.Count; i++)
            {
                if (SelectedPCB == strings[i])
                {
                    PCBID = InputData.ListOfPCBs[i].PCBID;
                }
            }
        }

        private void SelectPcbOKbtn_Click(object sender, EventArgs e) //Обновление кода ПП в проекте
        {
            string str = @$"URI=file:{InputData.DBFullPath}";

            using var con = new SQLiteConnection(str);
            con.Open();

            using var cmd = new SQLiteCommand(con);
            string NewPCBQuery = $"UPDATE Проект SET КодПП = " + PCBID + " WHERE КодПроекта = " + ProjectID + "";

            cmd.CommandText = NewPCBQuery;

            cmd.ExecuteNonQuery();
            InputData.ListOfProjects.Find(p => p.ProjectID == ProjectID).PCBID = PCBID;
            Close();
        }
    }
}
