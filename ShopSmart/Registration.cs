using MySql.Data.MySqlClient;
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
    public partial class FrmRegistration : Form
    {
        ConnectionToDB conToDb = new ConnectionToDB();
        MySqlCommand cmd = new MySqlCommand();
        DataTable dataTable = new DataTable();
        MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        MySqlDataReader dataReader;
        DataSet dataSet = new DataSet();
        string sqlQuery;
        public FrmRegistration()
        {
            InitializeComponent();
        }
        private void informationUpload()
        {
            ConnectionToDB.serverInfo();
            conToDb.connOpen();
            cmd.CommandText = "SELECT * From shopsmart";
            dataReader = cmd.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            conToDb.connClose();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblHaveAnAccount_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                conToDb.connOpen();
                string firstName = txtBoxFirstname.Text;
                string lastName = textBoxLastname.Text;
                string userName = textBoxUserName.Text;
                string password = txtBoxPassword.Text;
                string email = textBoxEmail.Text;
                string city = textBoxCity.Text;
                int postCode = Convert.ToInt32(textBoxPostCode.Text);
                sqlQuery = $"CALL shopsmart.sp_register ('{firstName}', '{lastName}', '{userName}', '{password}', '{email}', '{city}','{postCode}');";
                cmd = new MySqlCommand(sqlQuery, ConnectionToDB.conMaster);
                dataReader = cmd.ExecuteReader();
                conToDb.connClose();
                MessageBox.Show("Your Registraion Is Succesfully! Please Login Now", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBoxShowPass_MouseEnter(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
        }

        private void pictureBoxShowPass_MouseLeave(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar= false;
        }
    }
}
