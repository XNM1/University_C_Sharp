using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08
{
    public partial class MainForm : Form
    {
        BindingList<Lab06.Car> cars;
        public MainForm()
        {
            InitializeComponent();
            cars = new BindingList<Lab06.Car>();
            listBoxCars.DisplayMember = "ShortInfo";
            listBoxCars.DataSource = cars;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Lab06.Car car = new Lab06.Car();
            CarForm carForm = new CarForm(car);
            if (carForm.ShowDialog() == DialogResult.OK)
            {
                cars.Add(car);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви точно бажаєте вийти?", "Запитання", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}
