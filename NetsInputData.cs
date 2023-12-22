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
    public partial class NetsInputData : Form
    {
        //Класс, получающий данные о межсоединениях из Netlist
        public NetsInputData()
        {
            InitializeComponent();
        }

        public string NetFilePath { get; set; }

        private void NetsInputSelectBtn_Click(object sender, EventArgs e)
        {
            if (openNetFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            NetFilePath = @openNetFileDialog.FileName;
            NetsInputPathLabel.Text = NetFilePath;
        }

        public void GetNetData(string DBPath, int ProjectID)
        {
            string str = @$"URI=file:{DBPath}";

            using var con = new SQLiteConnection(str);
            con.Open();

            using var cmd = new SQLiteCommand(con);


            using (StreamReader sr = new StreamReader(@NetFilePath, Encoding.UTF8)) //Чтение данных о межсоединениях
            {
                string line;
                string netCode = "";
                bool startReading = false;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("("))
                    {
                        netCode = "";
                        startReading = true;
                        continue;
                    }

                    if (line.StartsWith(")"))
                    {
                        startReading = false;
                        continue;
                    }

                    if (startReading && line.StartsWith("Net"))
                    {
                        netCode = line;
                        continue;
                    }

                    if (netCode == "" || !line.Contains('-'))
                        continue;

                    string[] parts = line.Split('-');
                    if (parts.Length < 2)
                        continue;

                    string elementCode = parts[0];
                    string pinNumber = parts[1];

                    if (elementCode.StartsWith("VCC"))
                        continue;


                    string NetDataQuery = $"INSERT INTO Межсоединения (КодПроекта, НомерЦепи, ПозиционноеОбозначениеЭлемента, НомерВывода) VALUES ({ProjectID}, '{netCode}', '{elementCode}', {pinNumber})";
                    cmd.CommandText = NetDataQuery;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void NetOkBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
