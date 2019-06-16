using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NapredneBaze.Model
{
    class Clan
    {
        string ime;
        string prezime;
        string grad;
        string username;
        string password;
        string popust;

        public Clan()
        {
        }

        public Clan(string ime, string prezime, string grad, string username, string password, string popust)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.grad = grad;
            this.username = username;
            this.password = password;
            this.popust = popust;
        }

        public int ProvjeriUsername(string username)
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();

            String query = "select count(*) as broj from clan where username=@userParam";
            
            try
            {
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.Add("userParam", MySqlDbType.VarChar);
                command.Parameters["userParam"].Value = username;

                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();

                int count = Int32.Parse(reader["broj"].ToString());
                reader.Close();

                return count; // ili 1 ili 0
            }
            catch (Exception err)
            {
                MessageBox.Show("Greska " + err);
                return 2; //ako pukne program
            }
        }

        public bool UnosClana()
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();

            string query = "INSERT INTO clan(ime, prezime, grad, username, password, popust)"
                         + "VALUES(@imeParam, @prezimeParam, @gradParam, @userParam, @passParam, @popustParam)";

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.Add("imeParam", MySqlDbType.VarChar);
                command.Parameters.Add("prezimeParam", MySqlDbType.VarChar);
                command.Parameters.Add("gradParam", MySqlDbType.VarChar);
                command.Parameters.Add("userParam", MySqlDbType.VarChar);
                command.Parameters.Add("passParam", MySqlDbType.VarChar);
                command.Parameters.Add("popustParam", MySqlDbType.VarChar);

                command.Parameters["imeParam"].Value = this.ime;
                command.Parameters["prezimeParam"].Value = this.prezime;
                command.Parameters["gradParam"].Value = this.prezime;
                command.Parameters["userParam"].Value = this.username;
                command.Parameters["passParam"].Value = this.password;
                command.Parameters["popustParam"].Value = this.popust;

                command.ExecuteNonQuery();
                MessageBox.Show("Uspjesan unos u bazu");

                return true;
            }
            catch(Exception err)
            {
                MessageBox.Show("Greska pri unosu korisnika " + err);
                return false;
            }

        }

        public int LogIn(string username, string password)
        {
            MySqlConnection connection = DBConnection.getConnection();

            int postoji = ProvjeriUsername(username);

            if (postoji == 0)
            {
                MessageBox.Show("Nalog ne postoji. Morate se prvo učlaniti!");
                return -1;
            }
            else if (postoji == 1)
            {
                String query = "select password,admin from clan where username=@userParam";
                MySqlCommand command = new MySqlCommand();
                try
                {
                    command.CommandText = query;
                    command.Connection = connection;

                    command.Parameters.Add("userParam", MySqlDbType.VarChar);
                    command.Parameters["userParam"].Value = username;

                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    string pass = reader["password"].ToString();
                    int admin = Int32.Parse(reader["admin"].ToString());

                    reader.Close();

                    if (pass != password)
                    {
                        MessageBox.Show("Neispravna lozinka!");
                        return -2;
                    }
                    return admin;
                }
                catch (Exception err)
                {
                    return -3;
                } 
            }
            else
            {
                return -3;
            }
        }
    }
}
