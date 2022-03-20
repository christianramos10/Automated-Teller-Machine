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
    public partial class cancelForm : Form
    {
        public cancelForm()
        {
            InitializeComponent();
        }

        private void CancelForm_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        //Timer to go back to login page
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            logInForm logInF = new logInForm();
            logInF.ShowDialog();
            this.Close();
            Close();
        }


    }
}
