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
    public partial class balanceForm : Form
    {
        decimal balance = 0;
        String name = "", accountNumber = "", pin = "";
        public balanceForm()
        {
            InitializeComponent();
        }

        //Receive user info
        public void fromMenu(string name, decimal balance, string accountNumber, string pin) {
            this.name = name;
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.pin = pin;
        }

        //Show balance
        private void balanceForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text += " " + this.name;
            balanceLabel.Text += " " + this.balance.ToString("0.00");
        }

        //Return to menu
        private void enter_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm menuF = new menuForm();
            menuF.fromLogIn(name,balance,accountNumber,pin);
            menuF.ShowDialog();
            this.Close();
        }

        //Cancel transaction
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            cancelForm cancelF = new cancelForm();
            cancelF.ShowDialog();
            this.Close();
        }
    }
}
