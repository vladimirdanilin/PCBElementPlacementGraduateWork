using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementPlacement
{
    public partial class AddElementReferenceDesignation : Form
    {
        //Добавление позиционных обозначений элементам
        public AddElementReferenceDesignation(string elementFullData)
        {
            InitializeComponent();
            ElementFullData = elementFullData;
            CurrentElementDataLabel.Text = ElementFullData;
        }

        private string ElementFullData;
        public string ElementReferenceDesignation; //Позиционное обозначение

        private void ElementReferenceDesignationtextBox1_TextChanged(object sender, EventArgs e)
        {
            ElementReferenceDesignation = ElementReferenceDesignationtextBox1.Text;
        }

        private void ElementReferenceDesignationBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
