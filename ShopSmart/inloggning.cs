﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopSmart
{
    public partial class FrmLogin : Form
    {
        ConnectionToDB connToDB = new ConnectionToDB();
        

        FrmMainPage mainPage = new FrmMainPage();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblDontHaveAccount_MouseEnter(object sender, EventArgs e)
        {
            lblDontHaveAccount.ForeColor = Color.LimeGreen;
        }

        private void lblDontHaveAccount_MouseLeave(object sender, EventArgs e)
        {
            lblDontHaveAccount.ForeColor= Color.SeaGreen;
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPassword.Checked)
            {
                txtBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar= false;
            }
        }

        private void lblDontHaveAccount_Click(object sender, EventArgs e)
        {
            FrmRegistration registration = new FrmRegistration();
            registration.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            string userName=txtBoxUsername.Text;
            string password=txtBoxPassword.Text;
            connectionToDB.inLogning(userName, password);
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
