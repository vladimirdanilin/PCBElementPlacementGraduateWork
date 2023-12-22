using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.SQLite;


namespace ElementPlacement
{
    public class Database
    {
        //Класс, позволяющий создать БД
        public string DataBaseName { get; set; }
        public string DataBasePath { get; set; }
        public string FullPath { get; set; }

        public Database(string dataBaseName, string dataBasePath)
        {
            DataBaseName = dataBaseName;
            DataBasePath = dataBasePath;
            FullPath = Path.Combine(DataBasePath, DataBaseName + ".db");
        }

        public void CreateDatabase() //Создание БД
        {

            if (!File.Exists(@FullPath))
            {
                SQLiteConnection.CreateFile(@FullPath); 
            }
                        
        }
       
    }
}
