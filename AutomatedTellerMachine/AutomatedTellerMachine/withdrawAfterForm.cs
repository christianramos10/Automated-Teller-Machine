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
    public partial class withdrawAfterForm : Form
    {
        decimal balance = 0, option = 0;
        String accountNumber = "", pin = "";
        bool cashTaken = false;

        //Recieve parameters from Withdraw Form
        public void fromWithdraw(string accountNumber, string pin, decimal option)
        {
            this.accountNumber = accountNumber;
            this.pin = pin;
            this.option = option;
            checkBalance(this.accountNumber, this.pin);
        }
        private void widthdrawAfterForm_Load(object sender, EventArgs e)
        {
            widthdrawnLabel.Text += " $" + option.ToString();
            balanceLabel.Text += " $" + balance.ToString();
            cashButton.BackColor = Color.Green;
        }

        public withdrawAfterForm()
        {
            InitializeComponent();
        }

        //User has taken cash
        private void cashButton_Click(object sender, EventArgs e)
        {
            cashTaken = true;
            cashButton.BackColor = default(Color);
        }

        //Return to menu
        private void enter_button_Click(object sender, EventArgs e)
        {
            if (cashTaken)
            {
                this.Hide();
                menuForm menuF = new menuForm();
                menuF.fromLogIn(accountNumber, pin);
                menuF.ShowDialog();
                this.Close();
            }
        }

        //Cancel transaction
        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (cashTaken)
            {
                this.Hide();
                exitForm exitF = new exitForm();
                exitF.ShowDialog();
                this.Close();
            }
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
