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
    class ConnectionToDB
    {
       
        
        public static MySqlConnection conMaster = new MySqlConnection();
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
            serverInfo();
            conMaster.Open();
        }
        public void connClose()
        {
            serverInfo();
            conMaster.Close();
        }

    }
}
