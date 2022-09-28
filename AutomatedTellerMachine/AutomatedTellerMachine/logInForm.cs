using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedTellerMachine
{
    public partial class logInForm : Form
    {
        int stage = 0;

        //Connect to the database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ETTN470;Initial Catalog=atmP;User ID=admin;Password=12345");
        public logInForm()
        {
            InitializeComponent();
        }

        //Connect to the database at start
        private void logInForm_Load(object sender, EventArgs e)
        {         
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This method will add text when a number's button has been pressed.
        private void num_Clicked(object sender, EventArgs e)
        {
            //Number's button
            Button button = (Button)sender;

            //If we are writing on the acc text box: 
            if (stage==0)
            {
                accNumber_textBox.Text += button.Text;
              
            }

            //Else (we are writing on the pin text box):
            else {      
                pinNumber_textBox.Text += button.Text;
            }      
        }

        //This method will remove the last character of the number string
        private void backspace_button_Click(object sender, EventArgs e)
        {
            if ((stage==0 && accNumber_textBox.Text.Length != 0) || (stage==1 && pinNumber_textBox.Text.Length != 0)) 
            {
                    accNumber_textBox.Text = accNumber_textBox.Text.Remove(accNumber_textBox.Text.Length - 1);
            }          
        }

        //This method will clear the acc or pin numbers entried.
        private void clear_button_Click(object sender, EventArgs e)
        {
            if (stage==0)
            {
                accNumber_textBox.Text = "";
            }
            else if (stage==1) {
                pinNumber_textBox.Text = "";
            }
        }

        //Change focused textbox or search for account in database
        private void enter_button_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            if (stage==0 && accNumber_textBox.Text.Length != 0)
            {
                stage = 1;
                pinNumber_textBox.Focus();          
            }

            //Check if acc and pin exists
            else {
                string qryUserName = "select * from userTable where AccNumber='" + accNumber_textBox.Text + "' AND AccPinNumber='" + pinNumber_textBox.Text + "'";
                SqlCommand cmd = new SqlCommand(qryUserName, con);
                SqlDataReader dr = cmd.ExecuteReader();
                String name = "", accountNumber = "", pin="";               
                decimal balance = 0;
                while (dr.Read()) {
                    name = dr["UserName"].ToString();
                    balance = decimal.Parse(dr["Balance"].ToString());
                    accountNumber = dr["AccNumber"].ToString();
                    pin = dr["AccPinNumber"].ToString();
                }
                dr.Close();

                //If exists go to the next form
                if (name != "") 
                {
                    this.Hide();
                    menuForm mForm = new menuForm();
                    mForm.fromLogIn(accountNumber, pin);
                    mForm.ShowDialog();
                    con.Close();
                    this.Close();                     
                }

                //If it doesn't exist, display error label.
                else {
                    errorLabel.Text = "Account not found! Please check the account or pin number.";
                    accNumber_textBox.Text = "";
                    pinNumber_textBox.Text = "";
                    accNumber_textBox.Focus();
                    stage = 0;
                }
            }
        }

        //This method will cancel the transaction and close the program
        private void cancel_button_Click(object sender, EventArgs e)
        {  
            this.Hide();
            cancelForm cancelF = new cancelForm();
            cancelF.ShowDialog();
            this.Close();        
        }

        
    }
}
