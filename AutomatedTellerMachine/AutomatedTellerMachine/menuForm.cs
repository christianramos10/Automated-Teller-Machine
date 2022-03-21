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

        //Recieve parameters from Log In
        public void fromLogIn(string accountNumber, string pin) {
            welcome_label.Text += " " + name;
            this.accountNumber = accountNumber; 
            this.pin = pin; 
            checkBalance(this.accountNumber, this.pin);
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
           
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
                    balanceF.fromMenu(accountNumber, pin);
                    balanceF.ShowDialog();
                    this.Close();
                    break;
                case "2":
                    this.Hide();
                    withdrawForm withdrawF = new withdrawForm();
                    withdrawF.fromMenu(accountNumber, pin);
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
        //Check balance
        private void checkBalance(string acc, string pin) {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4RQCFAD;Initial Catalog=atmP;User ID=admin;Password=12345");
                con.Open(); 
                string qryUserName = "select * from userTable where AccNumber='" + acc + "' AND AccPinNumber='" + pin + "'";
                SqlCommand cmd = new SqlCommand(qryUserName, con);
                SqlDataReader dr = cmd.ExecuteReader();           
                while (dr.Read())
                {       
                    this.balance = decimal.Parse(dr["Balance"].ToString());
                }
                dr.Close();
                con.Close();           
        }
    }
}
