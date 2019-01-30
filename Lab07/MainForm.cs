using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07
{
    public partial class MainForm : Form
    {
        delegate double FunctionDelegate(double x1, double x2);

        FunctionDelegate funct;
        public MainForm()
        {
            InitializeComponent();
            funct = Function;
        }

        private double Function(double x1, double x2)
        {
            return 23 * ((1 + Math.Cos(2 * Math.Pow(x1, 3) * Math.Pow(x2, 5))) / 2) + 2 * x1;
        }

        private void ButtonGetResult_Click(object sender, EventArgs e)
        {
            double x1, x2;
            if (double.TryParse(textBoxX1.Text, out x1) && double.TryParse(textBoxX2.Text, out x2))
            {
                textBoxY.Text = String.Format("{0:N6}", funct(x1, x2));
            }
            else
            {
                MessageBox.Show("Заповніть поля Х1 та Х2");
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxX1.Text))
                textBoxX1.Clear();
            if (!string.IsNullOrEmpty(textBoxX2.Text))
                textBoxX2.Clear();
            if (!string.IsNullOrEmpty(textBoxY.Text))
                textBoxY.Clear();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
