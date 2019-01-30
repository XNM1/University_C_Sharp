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
    public partial class CarForm : Form
    {
        Lab06.Car car;
        public CarForm(Lab06.Car car)
        {
            InitializeComponent();
            this.car = car;
            comboBoxModel.DataSource = Enum.GetValues(typeof(Lab06.Car.AutoModel));
            comboBoxCountry.DataSource = Enum.GetValues(typeof(Lab06.Car.Countries));
            carBindingSource.DataSource = car;
            carBindingSource.BindingComplete += CarBindingSource_BindingComplete;
            textBoxNumber.TextChanged += TextBoxNumber_TextChanged;
        }

        private void TextBoxNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNumber.Text))
            {
                comboBoxCountry.Enabled = true;
            }
            else
            {
                comboBoxCountry.Enabled = false;
            }
        }

        private void CarBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteState != BindingCompleteState.Success)
            {
                MessageBox.Show(e.ErrorText);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(car.Number) && !string.IsNullOrEmpty(car.Color))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Fields are empty");
            }
        }
    }
}
