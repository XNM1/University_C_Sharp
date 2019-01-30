using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridViewCars.AutoGenerateColumns = false;
            FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ви точно бажаєте вийти?", "Запитання",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void ToolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Lab06.Car car = new Lab06.Car();
            CarForm carForm = new CarForm(car);
            if (carForm.ShowDialog() == DialogResult.OK)
            {
                carBindingSource.Add(car);
            }
        }

        private void ToolStripButtonClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте очистити?", "Запитання",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                carBindingSource.Clear();
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити запис?", "Запитання",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                carBindingSource.RemoveCurrent();
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            Lab06.Car car = carBindingSource.List[carBindingSource.Position] as Lab06.Car;
            if (car != null)
            {
                CarForm carForm = new CarForm(car);
                if (carForm.ShowDialog() == DialogResult.OK)
                {
                    carBindingSource.List[carBindingSource.Position] = car;
                }
            }
        }
    }
}
