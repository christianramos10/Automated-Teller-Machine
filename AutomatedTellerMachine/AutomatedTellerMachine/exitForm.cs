using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedTellerMachine
{
    public partial class exitForm : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public exitForm()
        {
            InitializeComponent();
        }

        //Start timer when form loads
        private void exitForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 4000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        //Timer to close app
        private void timer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
