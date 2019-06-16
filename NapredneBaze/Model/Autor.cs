using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NapredneBaze.Model
{
    class Autor
    {
        string ime;
        string prezime;
        string biografija;

        public Autor(string ime, string prezime, string biografija)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.biografija = biografija;
        }

        public static void listaAutora(ComboBox cb)
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();
            String query = "select ime, prezime from autor";

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cb.Items.Add(reader["ime"].ToString() + " " + reader["prezime"].ToString());
                } 

                reader.Close();
            }
            catch(Exception err)
            {

            }
        }

        public static int nadjiID(string ime, string prezime)
        {
            String query = "select id from autor where ime=@imeParam and prezime=@prezimeParam";
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();
            try
            {
                command.CommandText = query;
                command.Connection = connection;
          
                command.Parameters.Add("imeParam", MySqlDbType.VarChar);
                command.Parameters["imeParam"].Value = ime;
                command.Parameters.Add("prezimeParam", MySqlDbType.VarChar);
                command.Parameters["prezimeParam"].Value = prezime;

                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();

                int id = Int32.Parse(reader["id"].ToString());
                reader.Close();

                return id;
            }
            catch (Exception err)
            {
                MessageBox.Show("Greska " + err);
                return -2; //ako pukne program
            }
        }

        public static void detaljiOAutoru(string ime, string prezime, Label l1, Label l2, TextBox t, PictureBox pb)
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();

            int id = nadjiID(ime, prezime);
            String query = "select ime, prezime, biografija from autor where id=@idParam";

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.Add("idParam", MySqlDbType.VarChar);
                command.Parameters["idParam"].Value = id;

                MySqlDataReader reader = command.ExecuteReader();

                reader.Read();

                l1.Text = reader["ime"].ToString();
                l1.Visible = true;
                l2.Text = reader["prezime"].ToString();
                l2.Visible = true;
                t.Text = reader["biografija"].ToString();
                t.Visible = true;
                pb.Image = Image.FromFile(@"../../Autori/" + l1.Text + "" + l2.Text + "" + ".jpg");
                pb.Visible = true;

                reader.Close();
            }
            catch (Exception err)
            {

            }
        }

        public bool UnosAutora()
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();

            string query = "INSERT INTO autor(ime, prezime, biografija)"
                         + "VALUES(@imeParam, @prezimeParam, @biografijaParam)";

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.Add("imeParam", MySqlDbType.VarChar);
                command.Parameters.Add("prezimeParam", MySqlDbType.VarChar);
                command.Parameters.Add("biografijaParam", MySqlDbType.VarChar);

                command.Parameters["imeParam"].Value = this.ime;
                command.Parameters["prezimeParam"].Value = this.prezime;
                command.Parameters["biografijaParam"].Value = this.biografija;
    
                command.ExecuteNonQuery();
                MessageBox.Show("Uspjesan unos u bazu");

                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Greska pri unosu korisnika " + err);
                return false;
            }

        }

        public bool IzmjenaAutora(int id)
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();

            string query = "UPDATE autor " +
                           "SET ime=@imeParam, prezime=@prezimeParam, biografija=@biografijaParam " +
                           "WHERE id=@idParam";

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.Add("imeParam", MySqlDbType.VarChar);
                command.Parameters.Add("prezimeParam", MySqlDbType.VarChar);
                command.Parameters.Add("biografijaParam", MySqlDbType.VarChar);
                command.Parameters.Add("idParam", MySqlDbType.Int32);

                command.Parameters["imeParam"].Value = this.ime;
                command.Parameters["prezimeParam"].Value = this.prezime;
                command.Parameters["biografijaParam"].Value = this.biografija;
                command.Parameters["idParam"].Value = id;

                command.ExecuteNonQuery();
                MessageBox.Show("Uspjesna izmjena!");

                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Greska pri unosu korisnika " + err);
                return false;
            }

        }

        public static bool BrisanjeAutora(int id)
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();

            string query = "DELETE FROM autor WHERE id=@idParam";

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.Add("idParam", MySqlDbType.Int32);
                command.Parameters["idParam"].Value = id;

                command.ExecuteNonQuery();
                MessageBox.Show("Uspjesno brisanje!");

                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Greska pri brisanju " + err);
                return false;
            }

        }
    }
}
