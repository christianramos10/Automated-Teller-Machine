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
    public partial class depositForm : Form
    {
        string accountNumber = "", pin = "";
        decimal balance = "";
        //Connect to the database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4RQCFAD;Initial Catalog=atmP;User ID=admin;Password=12345");
        public depositForm()
        {
            InitializeComponent();
            errorLabel.Text = "";
        }
        public void from(string accNumber, string pin)
        {
            this.accountNumber = accNumber;
            this.pin = pin;
            checkBalance(this.accountNumber, this.pin);
        }
        private void num_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            depositTextbox.Text += button.Text;  
        }

        private void cancel_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            cancelForm cancelF = new cancelForm();
            cancelF.ShowDialog();
            this.Close();
        }

        //This method will remove the last character of the number string
        private void backspace_button_Click(object sender, EventArgs e)
        {
            depositTextbox.Text = depositTextbox.Text.Remove(depositTextbox.Text.Length- 1);
        }

        //This will clear the text box
        private void clear_button_Click(object sender, EventArgs e)
        {
            depositTextbox.Text = "";
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(depositTextbox.Text);
            if (amount % 20 == 0)
            {
                depositAmount(depositTextbox.Text);
                this.Hide();
                depositAfterForm depositAF = new depositAfterForm();
                depositAF.from(this.accountNumber, this.pin);
                depositAF.ShowDialog();
                this.Close();
            }
            else {
                errorLabel.Text = "Amount must be in multiples of 20!";
            }
        }

        //Deposit amount query
        private void depositAmount(string amount) { 
            decimal amountD = decimal.Parse(amount);

            con.Open();
            string depQuery = "Update userTable SET Balance = Balance + '" + amountD + "' WHERE  AccNumber='" + accountNumber + "' AND AccPinNumber='" + pin + "'";
            SqlCommand cmd = new SqlCommand(depQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.balance = decimal.Parse(dr["Balance"].ToString());
            }
            dr.Close();
            con.Close();
        }

        //Check balance query
        private void checkBalance(string acc, string pin)
        {
            con.Open();
            string qryUserName = "select * from userTable where AccNumber='" + acc + "' AND AccPinNumber='" + pin + "'";
            SqlCommand cmd = new SqlCommand(qryUserName, con);
            SqlDataReader dr = cmd.ExecuteReader();
            decimal balance = 0;
            while (dr.Read())
            {
                this.balance = decimal.Parse(dr["Balance"].ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}
