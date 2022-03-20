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
        bool accWrite = true;
        bool pinWrite = false;

        //Connect to the database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4RQCFAD;Initial Catalog=atmP;User ID=admin;Password=12345");
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
                MessageBox.Show("You are connected to the database!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not connect to the database!");
            }

        }

        //This method will add text when a number's button has been pressed.
        private void num_Clicked(object sender, EventArgs e)
        {
            //Number's button
            Button button = (Button)sender;

            //If we are writing on the acc text box: 
            if (accWrite)
            {
                if (accNumber_textBox.Text == "")
                {
                    accNumber_textBox.Text = button.Text;
                }

                else
                {
                    accNumber_textBox.Text += button.Text;
                }
            }

            //Else (we are writing on the pin text box):
            else {
                if (pinNumber_textBox.Text == "")
                {
                    pinNumber_textBox.Text = button.Text;
                }

                else
                {
                    pinNumber_textBox.Text += button.Text;
                }
            }
            
        }

        //This method will remove the last character of the number string
        private void backspace_button_Click(object sender, EventArgs e)
        {
            if (accWrite && accNumber_textBox.Text != "")
            {
                accNumber_textBox.Text = accNumber_textBox.Text.Remove(accNumber_textBox.Text.Length - 1);
            }
            else if (pinWrite && pinNumber_textBox.Text != "")
            {
                pinNumber_textBox.Text = pinNumber_textBox.Text.Remove(pinNumber_textBox.Text.Length - 1);
            }
        }

        //This method will clear the acc or pin numbers entried.
        private void clear_button_Click(object sender, EventArgs e)
        {
            if (accWrite)
            {
                accNumber_textBox.Text = "";
            }
            else if (pinWrite) {
                pinNumber_textBox.Text = "";
            }
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            if (accWrite && accNumber_textBox.Text != "")
            {
                accWrite = false;
                pinNumber_textBox.Focus();
                pinWrite = true;
            }

            //Check if acc and pin exists
            else {

                string qryUserName = "select * from userTable where AccNumber='" + accNumber_textBox.Text + "' AND AccPinNumber='" + pinNumber_textBox.Text + "'";
                SqlCommand cmd = new SqlCommand(qryUserName, con);
                SqlDataReader dr = cmd.ExecuteReader();
                String name = "";
                decimal balance = 0;

                while (dr.Read()) {
                    name = dr["UserName"].ToString();
                    balance = decimal.Parse(dr["Balance"].ToString());
                }
                dr.Close();

                //If exists go to the next form
                if (name != "") 
                {
                    this.Hide();
                    menuForm mForm = new menuForm();
                    mForm.fromLogIn(name, balance);
                    mForm.ShowDialog();
                    con.Close();
                    this.Close();                     
                }

                //If it doesn't exist, display error label.
                else {
                    errorLabel.Text = "Account not found! Please check the account or pin number.";
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
