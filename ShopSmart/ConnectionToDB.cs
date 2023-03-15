using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopSmart
{
    public class ConnectionToDB
    {
        //ConnectionToDB connectionToDb = new ConnectionToDB();
        MySqlCommand cmd = new MySqlCommand();
        DataTable dataTable = new DataTable();
        MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        MySqlDataReader dataReader;
        DataSet dataSet = new DataSet();
        string sqlQuery;
        MySqlConnection connection; 
        public static MySqlConnection conMaster = new MySqlConnection();

        public ConnectionToDB()
        { }
        public static MySqlConnection serverInfo()
        {
            string server = "localhost";
            string database = "shopsmart";
            string user = "root";
            string password = "Milad713$";
            string connectionString = $"SERVER={server};DATABASE={database};USER={user};PASSWORD={password};";
            conMaster = new MySqlConnection(connectionString);
            return conMaster;
        }
        public void connOpen()
        {
            connection= serverInfo();
            conMaster.Open();
        }
        public void connClose()
        {
            serverInfo();
            conMaster.Close();
        }
        public void inLogning(string userName, string password)
        {
            connOpen();

            sqlQuery = $"CALL shopsmart.sp_login ('{userName}', '{password}');";
            cmd= new MySqlCommand(sqlQuery, connection);
            dataReader = cmd.ExecuteReader();

            if(userName == null || password == null)
            {
                MessageBox.Show("Username Or Password unquirment. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(userName == sqlQuery && password == sqlQuery)
            {
                FrmLogin frmLogin = new FrmLogin();
                FrmMainPage frmMainPage = new FrmMainPage();
                frmMainPage.Show();
                frmLogin.Hide();
            }
            else
            {
                MessageBox.Show("Username Or Password Is Not Correct. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connClose();

        }

    }
}
