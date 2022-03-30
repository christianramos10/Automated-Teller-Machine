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
    public partial class balanceForm : Form
    {
        decimal balance = 0;
        String name = "", accountNumber = "", pin = "";
        public balanceForm()
        {
            InitializeComponent();
        }

        //Receive user info
        public void from(string accountNumber, string pin, String name) {
            this.accountNumber = accountNumber;
            this.pin = pin;
            checkBalance(this.accountNumber, this.pin);
            this.name = name;
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
            menuF.fromLogIn(accountNumber,pin);
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

        //Check balance
        private void checkBalance(string acc, string pin)
        {
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
