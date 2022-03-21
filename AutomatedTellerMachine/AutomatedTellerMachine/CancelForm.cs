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
        string accountNumber = "", pin = "";
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public cancelForm()
        {
            InitializeComponent();
        }

        //Receive user info
        public void from(string accountNumber, string pin)
        {
            this.accountNumber = accountNumber;
            this.pin = pin;
        }

        //Start timer when form loads
        private void CancelForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 4000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();           
        }

        //Timer to close app
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Tick -= new EventHandler(timer_Tick);
            this.Hide();
            menuForm mForm = new menuForm();
            mForm.fromLogIn(accountNumber, pin);
            mForm.ShowDialog();  
            this.Close();              
        }
    }
}
