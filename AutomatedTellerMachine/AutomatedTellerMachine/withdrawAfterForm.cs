﻿using System;
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
    public partial class withdrawAfterForm : Form
    {
        decimal balance = 0, option = 0;
        String name = "", accountNumber = "", pin = "";
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
        }

        public withdrawAfterForm()
        {
            InitializeComponent();
        }


        //Return to menu
        private void enter_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm menuF = new menuForm();
            menuF.fromLogIn(accountNumber, pin);
            menuF.ShowDialog();
            this.Close();
        }

        //Cancel transaction
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            cancelForm cancelF = new cancelForm();
            cancelF.ShowDialog();
            this.Close();
        }

        //Check balance
        private void checkBalance(string acc, string pin)
        {
            //Connect to the database
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4RQCFAD;Initial Catalog=atmP;User ID=admin;Password=12345");
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
