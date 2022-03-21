using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AutomatedTellerMachine
{
    public partial class withdrawForm : Form
    {
        decimal balance = 0, option=0;
        String name = "", accountNumber = "", pin = "";
        string choice = "";

        //Connect to the database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4RQCFAD;Initial Catalog=atmP;User ID=admin;Password=12345");
        public withdrawForm()
        {
            InitializeComponent();
            con.Open();
        }

        public void fromMenu(string name, decimal balance, string accountNumber, string pin) {
            this.name = name;
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.pin = pin;
        }

        private void num_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            choice = button.Text;

            switch (choice) {

                case "1":
                    if (balance >= 20) {
                        option = 20;
                        withdrawQuery(option);
                    }
                    break;
                case "2":
                    if (balance >= 40) {
                        option = 40;
                        withdrawQuery(option);
                    }
                        break;
                case "3":
                    if (balance >= 60) {
                        option = 60;
                        withdrawQuery(option);
                    }
                    break;
                case "4":
                    if (balance >= 80) {
                        option = 80;
                        withdrawQuery(option);
                    }
                    break;
                case "5":
                    if (balance >= 100){
                        option = 100;
                        withdrawQuery(option);
                    }
                    break;
                case "6":
                    if (balance >= 200){
                        option = 200;
                        withdrawQuery(option);
                    }
                    break;
                case "7":
                    break;
                case "8":
                    this.Hide();
                    menuForm menuF = new menuForm();
                    menuF.fromLogIn(name, balance, accountNumber, pin);
                    menuF.ShowDialog();
                    con.Close();
                    this.Close();
                    break;
                default:
                    break;


            } 
        }

        public void withdrawQuery(decimal option) {
            string withQuery = "Update userTable SET Balance = Balance - '" + option + "' WHERE  AccNumber='" + accountNumber + "' AND AccPinNumber='" + pin + "'";
            SqlCommand cmd = new SqlCommand(withQuery,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) { 
                this.balance = decimal.Parse(dr["Balance"].ToString());
            }
            con.Close();


            this.Hide();
            withdrawAfterForm waF = new withdrawAfterForm();
            waF.fromWithdraw(name, balance, accountNumber, pin, option);
            waF.ShowDialog();
            con.Close();
            this.Close();
        }
    }
}
