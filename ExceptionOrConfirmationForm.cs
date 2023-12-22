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
    public partial class ExceptionOrConfirmationForm : Form
    {
        //Класс, выводящий сообщение об ошибке/исключении/изменении данных
        public ExceptionOrConfirmationForm(string text)
        {
            InitializeComponent();
            ExceptionLabel.Text = text;
        }

        private void Exceptionbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
