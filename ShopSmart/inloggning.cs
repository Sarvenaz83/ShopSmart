using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopSmart
{
    public partial class FrmLogin : Form
    {
        ConnectionToDB connToDB = new ConnectionToDB();
        MySqlCommand cmd = new MySqlCommand();
        DataTable dataTable = new DataTable();
        MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        MySqlDataReader dataReader;
        DataSet dataSet = new DataSet();
        string sqlQuery;
        MySqlConnection connection;

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
            ConnectionToDB.serverInfo();
            connToDB.connOpen();
            MySqlCommand cmd = new MySqlCommand("sp_login", ConnectionToDB.conMaster);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("$userName", MySqlDbType.VarChar).Value = txtBoxUsername.Text;
            cmd.Parameters.Add("$pass", MySqlDbType.VarChar).Value=txtBoxPassword.Text;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                connToDB.connOpen();
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password, Try Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
