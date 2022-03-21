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
    public partial class withdrawAfterForm : Form
    {
        decimal balance = 0, option = 0;
        String name = "", accountNumber = "", pin = "";
        public void fromWithdraw(string name, decimal balance, string accountNumber, string pin, decimal option)
        {
            this.name = name;
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.pin = pin;
            this.option = option;
        }
        private void widthdrawAfterForm_Load(object sender, EventArgs e)
        {
            widthdrawnLabel.Text += " $" + option.ToString();
            balanceLabel.Text += " $" + balance.ToString();
        }

        public withdrawAfterForm()
        {
            InitializeComponent();
        }


        //Return to menu
        private void enter_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm menuF = new menuForm();
            menuF.fromLogIn(name, balance, accountNumber, pin);
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
