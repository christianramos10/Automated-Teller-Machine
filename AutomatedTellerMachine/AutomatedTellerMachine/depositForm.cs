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
    public partial class depositForm : Form
    {
        string accountNumber = "", pin = "";
        decimal balance = 0;
        bool cashInMultiples = false;

        //Connect to the database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ETTN470;Initial Catalog=atmP;User ID=admin;Password=12345");

        public depositForm()
        {
            InitializeComponent();
            errorLabel.Text = "";
        }

        //Recieve parameters
        public void from(string accNumber, string pin)
        {
            this.accountNumber = accNumber;
            this.pin = pin;
            checkBalance(this.accountNumber, this.pin);
        }

        //Read number key
        private void num_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!cashInMultiples) depositTextbox.Text += button.Text;
            
        }

        //Cancel transaction
        private void cancel_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            cancelForm cancelF = new cancelForm();
            cancelF.from(accountNumber, pin);
            cancelF.ShowDialog();
            con.Close();
            this.Close();
        }

        //This method will remove the last character of the number string
        private void backspace_button_Click(object sender, EventArgs e)
        {
            if(this.depositTextbox.Text.Length != 0 && !cashInMultiples) depositTextbox.Text = depositTextbox.Text.Remove(depositTextbox.Text.Length - 1);
            
        }

        //This will clear the text box
        private void clear_button_Click(object sender, EventArgs e)
        {
            if(!cashInMultiples) depositTextbox.Text = "";
        }

        //Deposit amount
        private void enter_button_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(depositTextbox.Text);
            if (amount > 0) {
                cashInMultiples = true;
                depositButton.BackColor = Color.Green;
                errorLabel.Text = "Please deposit up to 50 bills at a time.";    
               depositTextbox.Enabled = false;
            }
            else
            {
                errorLabel.Text = "Amount must be bigger than 0!";
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

        //Deposit button
        private void depositButton_Click(object sender, EventArgs e)
        {   if (cashInMultiples) {
                depositButton.BackColor = default(Color);
                depositAmount(depositTextbox.Text);
                this.Hide();
                depositAfterForm depositAF = new depositAfterForm();
                depositAF.from(this.accountNumber, this.pin);
                depositAF.ShowDialog();
                this.Close();
            }
        }

        //Check balance query
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
