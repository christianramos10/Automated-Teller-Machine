using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public logInForm()
        {
            InitializeComponent();
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
            if (accWrite && accNumber_textBox.Text != "")
            {
                accWrite = false;
                pinNumber_textBox.Focus();
                pinWrite = true;
            }
            else { 
                
            }
        }

        //This method will cancel the transaction and return to login page
        private void cancel_button_Click(object sender, EventArgs e)
        {  
            this.Hide();
            cancelForm cancelF = new cancelForm();
            cancelF.ShowDialog();
            this.Close();        
        }
    }
}
