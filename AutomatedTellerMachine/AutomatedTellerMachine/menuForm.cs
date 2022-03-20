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
        string accNumber = "";
        string accPin = "";

        //Connect to the database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4RQCFAD;Initial Catalog=atmP;User ID=admin;Password=12345");
        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }

        public void fromLogIn(string name, decimal balance) {
            welcome_label.Text += " " + name + " " + balance.ToString();
           
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
            Button button = new Button();
            string choice = button.Text;

            switch (choice) {
                case "1":
                    this.Hide();
                    balanceForm balanceF = new balanceForm();
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
