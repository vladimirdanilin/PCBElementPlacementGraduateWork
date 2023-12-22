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
    public partial class AddElementsToProject : Form
    {
        //Класс, реализующий добавление элементов к проекту
        public AddElementsToProject(InputData inputData)
        {
            InitializeComponent();
            InputData = inputData;
            GetElementData();
        }

        InputData InputData { get; set; }
        public string[] ElementsFullData;

        private void GetElementData() //Вывод пользователю данных об элементах
        {
            ElementsFullData = new string[InputData.AllElementsList.Count];
            int i = 0;
            foreach (var element in InputData.AllElementsList)
            {
                ElementsFullData[i] += $"Маркировка: {element.marking} Название: {element.name} Длина: {element.length} Ширина: {element.width} Высота: {element.thickness} Максимальная температура: {element.maxT} \n";
                i++;
            }
            SelectElementsForAddingListbox.Items.AddRange(ElementsFullData);
        }



        private void InsertElementsToProject() //Вставка элементов в текущий проект
        {
            string str = @$"URI=file:{InputData.DBFullPath}";

            using var con = new SQLiteConnection(str);
            con.Open();

            using var cmd = new SQLiteCommand(con);

            foreach (var item in SelectElementsForAddingListbox.SelectedItems)
            {
                int index = SelectElementsForAddingListbox.Items.IndexOf(item);
                AddElementReferenceDesignation addElementReferenceDesignation = new AddElementReferenceDesignation(ElementsFullData[index]);
                addElementReferenceDesignation.ShowDialog();
                var element = InputData.AllElementsList[index];
                element.referenceDesignation = addElementReferenceDesignation.ElementReferenceDesignation;
                InputData.ProjectElementsList.Add(element);

                string NewElementsQuery = $"INSERT INTO ЭлементыПроекта (КодПроекта, МаркировкаЭлемента, ПозиционноеОбозначениеЭлемента) VALUES(" + InputData.ProjectID + ", '" + InputData.AllElementsList[index].marking + "', '" + addElementReferenceDesignation.ElementReferenceDesignation + "')";
                cmd.CommandText = NewElementsQuery;
                cmd.ExecuteNonQuery();
            }

        }

        private void SelectProjectOKbtn_Click(object sender, EventArgs e)
        {
            InsertElementsToProject();
            Close();
        }

        private void SelectElementsForAddingListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
