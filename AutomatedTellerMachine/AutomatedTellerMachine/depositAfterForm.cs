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
    public partial class depositAfterForm : Form
    {
        string accountNumber = "", pin = "";
        public depositAfterForm()
        {
            InitializeComponent();
        }

        public void from(string accNumber, string pin) { 
            this.accountNumber = accNumber; 
            this.pin = pin;
        }

        //Return to menu
        private void enter_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm menuF = new menuForm();
            menuF.fromLogIn(this.accountNumber, this.pin);
            menuF.ShowDialog();
            this.Close();
        }

        //Exit system
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            exitForm exitF = new exitForm();
            exitF.ShowDialog();
            this.Close();
        }
    }
}
