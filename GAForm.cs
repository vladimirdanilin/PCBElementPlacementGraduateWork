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
    public partial class GAForm : Form
    {
        //Класс, позволяющий пользователю вводить настроки генетического алгоритма
        public GAForm()
        {
            InitializeComponent();
        }
        
        public int NumOfSpeciesInitial { get; set; }
        public int MutationPercentage { get; set; }
        public int FitnessStNum { get; set; }

        private void NumOfSpeciesTextbox_TextChanged(object sender, EventArgs e)
        {
            NumOfSpeciesInitial = Convert.ToInt32(NumOfSpeciesTextbox.Text);
        }

        private void MutationTextbox_TextChanged(object sender, EventArgs e)
        {
            MutationPercentage = Convert.ToInt32(MutationTextbox.Text);
        }

        private void FitnessStTextbox_TextChanged(object sender, EventArgs e)
        {
            FitnessStNum = Convert.ToInt32(FitnessStTextbox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
