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
    public partial class withdrawForm : Form
    {
        decimal balance = 0, option=0;
        string accountNumber = "", pin = "";
        string choice = "";     
        //Connect to the database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4RQCFAD;Initial Catalog=atmP;User ID=admin;Password=12345");

        public withdrawForm()
        {
            InitializeComponent();
            errorLabel.Text = "";
        }

        //Recieve parameters from Menu
        public void fromMenu(string accountNumber, string pin) {
            this.accountNumber = accountNumber;
            this.pin = pin;
            checkBalance(this.accountNumber, this.pin); 
        }

        //Check option clicked for withdrawal
        private void num_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            choice = button.Text;
            switch (choice) {
                case "1":
                    if (balance >= 20)
                    {
                        option = 20;
                        withdrawQuery(option);
                    }
                    else {
                        errorLabel.Text = "Insuficient funds!";
                    }
                    break;
                case "2":
                    if (balance >= 40) {
                        option = 40;
                        withdrawQuery(option);
                    }
                    else
                    {
                        errorLabel.Text = "Insuficient funds!";
                    }
                    break;
                case "3":
                    if (balance >= 60) {
                        option = 60;
                        withdrawQuery(option);
                    }
                    else
                    {
                        errorLabel.Text = "Insuficient funds!";
                    }
                    break;
                case "4":
                    if (balance >= 100) {
                        option = 100;
                        withdrawQuery(option);
                    }
                    else
                    {
                        errorLabel.Text = "Insuficient funds!";
                    }
                    break;
                case "5":
                    if (balance >= 200){
                        option = 200;
                        withdrawQuery(option);
                    }
                    else
                    {
                        errorLabel.Text = "Insuficient funds!";
                    }
                    break;
                case "6":
                    this.Hide();
                    menuForm menuF = new menuForm();
                    menuF.fromLogIn(accountNumber, pin);
                    menuF.ShowDialog();
                    con.Close();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        //Query for updating table and balance value
        public void withdrawQuery(decimal option) {
            con.Open();
            string withQuery = "Update userTable SET Balance = Balance - '" + option + "' WHERE  AccNumber='" + accountNumber + "' AND AccPinNumber='" + pin + "'";
            SqlCommand cmd = new SqlCommand(withQuery,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) { 
                this.balance = decimal.Parse(dr["Balance"].ToString());
            }
            dr.Close();
            this.Hide();
            withdrawAfterForm waF = new withdrawAfterForm();
            waF.fromWithdraw(accountNumber, pin, option);
            waF.ShowDialog();
            con.Close();
            this.Close();
        }

        //Check balance
        private void checkBalance(string acc, string pin)
        {
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
