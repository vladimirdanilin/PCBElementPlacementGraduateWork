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
    public partial class PCBMargins : Form
        //Класс, задающий отступы от краев ПП
    {
        public PCBMargins()
        {
            InitializeComponent();
        }

        public double OffsetX; //Отступ по оси Х
        public double OffsetY; //Отступ по оси Y

        private void MarginXTextbox_TextChanged(object sender, EventArgs e)
        {
            OffsetX = Convert.ToDouble(MarginXTextbox.Text);
        }

        private void MarginYTextbox_TextChanged(object sender, EventArgs e)
        {
            OffsetY = Convert.ToDouble(MarginYTextbox.Text);
        }

        private void MarginsOkbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
