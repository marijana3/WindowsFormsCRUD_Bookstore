using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NapredneBaze
{
    class DBConnection
    {
        static MySqlConnection connection = null;

        public static bool connect() {
            if (connection != null) {
                return true;
            }

            String connectionString = "Server = localhost; Database = knjizara; uid = root; password = brusnica; IntegratedSecurity = True;";

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Konekcija nije uspjesna!");
                return false;
            }
        }

        public static MySqlConnection getConnection()
        {
            if (connect())
            {
                //MessageBox.Show("Uspjesno konektovanje na bazu!");
                return connection;
            }

            return null;
        }
    }
}
