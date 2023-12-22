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
    public partial class ChooseCriterion : Form
    {
        //Класс, осуществляющий выбор критерия размещения
        public ChooseCriterion()
        {
            InitializeComponent();
        }
        public int TypeOfFitnessFunction;
        public double W1; //Весовые коэффициенты
        public double W2;


        private void WarmthradioButton_CheckedChanged(object sender, EventArgs e)
        {
            TypeOfFitnessFunction = 1; //Тепловой критерий
        }

        private void LengthradioButton_CheckedChanged(object sender, EventArgs e)
        {
            TypeOfFitnessFunction = 2; //Критерий минимизации суммарной взвешенной длины межсоединений
        }

        private void BothCriteriaradioButton_CheckedChanged(object sender, EventArgs e)
        {
            TypeOfFitnessFunction = 3; //Аддитивная свертка критериев
        }

        private void w1TextBox_TextChanged(object sender, EventArgs e)
        {
            W1 = Convert.ToDouble(w1TextBox.Text);
        }

        private void w2TextBox_TextChanged(object sender, EventArgs e)
        {
            W2 = Convert.ToDouble(w1TextBox.Text);
        }

        private void ChooseCriterionOkBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
