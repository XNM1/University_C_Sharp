using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Induvidual_Task
{
    public partial class LoadForm : Form
    {
        public Timer Timer { get; private set; }
        public LoadForm()
        {
            InitializeComponent();
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = this.BackColor;
            Timer = new Timer() { Interval = 1000 };
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Stop();
            Timer.Dispose();
            Close();
        }
    }
}
