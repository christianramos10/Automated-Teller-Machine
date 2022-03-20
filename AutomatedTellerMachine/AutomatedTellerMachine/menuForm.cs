using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutomatedTellerMachine
{
    public partial class menuForm : Form
    {
        decimal balance = 0;
        String name = "", accountNumber = "", pin = "";
        string choice = "";

        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }

        public void fromLogIn(string name, decimal balance, string accountNumber, string pin) {
            welcome_label.Text += " " + name;
            this.name = name; 
            this.balance = balance;
            this.accountNumber = accountNumber; 
            this.pin = pin; 
        }

        //This method will cancel the transaction and close the program
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            cancelForm cancelF = new cancelForm();
            cancelF.ShowDialog();
            this.Close();
        }

        //Open the form selected
        private void num_Clicked(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            choice = button.Text;

            switch (choice) {
                case "1":
                    this.Hide();
                    balanceForm balanceF = new balanceForm();
                    balanceF.fromMenu(name, balance, accountNumber, pin);
                    balanceF.ShowDialog();
                    this.Close();
                    break;
                case "2":
                    this.Hide();
                    withdrawForm withdrawF = new withdrawForm();
                    withdrawF.ShowDialog();
                    this.Close();
                    break;
                case "3":
                    this.Hide();
                    depositForm depositF = new depositForm();
                    depositF.ShowDialog();
                    this.Close();
                    break;
                case "4":
                    this.Hide();
                    exitForm exitF = new exitForm();
                    exitF.ShowDialog();
                    this.Close();
                    break;
                default:
                    break;
                
            }

          
        }
    }
}
