using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NapredneBaze.Model
{
    class Knjiga
    {
        int autorID;
        string naziv;
        string opis;
        double cijena;
        string zanr;

        public Knjiga(int autorID, string naziv, string opis, double cijena, string zanr)
        {
            this.autorID = autorID;
            this.naziv = naziv;
            this.opis = opis;
            this.cijena = cijena;
            this.zanr = zanr;
        }

        public static int nadjiID(string naziv)
        {
            String query = "select id from knjiga where naziv=@nazivParam";
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();
            try
            {
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.Add("nazivParam", MySqlDbType.VarChar);
                command.Parameters["nazivParam"].Value = naziv;

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

        public static void listaKnjiga(ComboBox cb)
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();
            String query = "select naziv from knjiga";

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cb.Items.Add(reader["naziv"].ToString());
                }

                reader.Close();
            }
            catch (Exception err)
            {

            }
        }

        public bool UnosKnjige()
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();

            string query = "INSERT INTO knjiga(autorID, naziv, opis, cijena, zanr)"
                         + "VALUES(@autorParam, @nazivParam, @opisParam, @cijenaParam, @zanrParam)";

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.Add("autorParam", MySqlDbType.Int32);
                command.Parameters.Add("nazivParam", MySqlDbType.VarChar);
                command.Parameters.Add("opisParam", MySqlDbType.VarChar);
                command.Parameters.Add("cijenaParam", MySqlDbType.Double);
                command.Parameters.Add("zanrParam", MySqlDbType.VarChar);

                command.Parameters["autorParam"].Value = this.autorID;
                command.Parameters["nazivParam"].Value = this.naziv;
                command.Parameters["opisParam"].Value = this.opis;
                command.Parameters["cijenaParam"].Value = this.cijena;
                command.Parameters["zanrParam"].Value = this.zanr;

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

        public bool IzmjenaKnjige(int id)
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();

            string query = "UPDATE knjiga " +
                           "SET autorID=@idParam, naziv=@nazivParam, opis=@opisParam, cijena=@cijenaParam, zanr=@zanrParam " +
                           "WHERE id=@idParam";

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.Add("autorParam", MySqlDbType.Int32);
                command.Parameters.Add("nazivParam", MySqlDbType.VarChar);
                command.Parameters.Add("opisParam", MySqlDbType.VarChar);
                command.Parameters.Add("cijenaParam", MySqlDbType.Double);
                command.Parameters.Add("zanrParam", MySqlDbType.VarChar);
                command.Parameters.Add("idParam", MySqlDbType.Int32);

                command.Parameters["autorParam"].Value = this.autorID;
                command.Parameters["nazivParam"].Value = this.naziv;
                command.Parameters["opisParam"].Value = this.opis;
                command.Parameters["cijenaParam"].Value = this.cijena;
                command.Parameters["zanrParam"].Value = this.zanr;
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

        public static void BrisanjeKnjige(int id)
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();

            string query = "DELETE FROM knjiga WHERE id=@idParam";

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.Add("idParam", MySqlDbType.Int32);
                command.Parameters["idParam"].Value = id;

                command.ExecuteNonQuery();
                MessageBox.Show("Uspjesno brisanje!");

            }
            catch (Exception err)
            {
                MessageBox.Show("Greska pri brisanju " + err);
              
            }

        }

        public static void BrisanjeKnjiga(int[] niz, int n) 
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();

            string query = "DELETE FROM knjiga WHERE id=@idParam";

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.Add("idParam", MySqlDbType.Int32);

                for (int i = 0; i < n; i++)
                {
                    command.Parameters["idParam"].Value = niz[i];

                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspjesno brisanje!");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Greska pri brisanju " + err);

            }

        }

        public static void BrisanjeKnjigaKaskadno(int idAutora)
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT id FROM knjiga WHERE autorID=@autorIDParam";
            int i = 0;
            int[] niz = new int[5000];

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.Add("autorIDParam", MySqlDbType.Int32);
                command.Parameters["autorIDParam"].Value = idAutora;

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int idKnjige = Int32.Parse(reader["id"].ToString());
                    niz[i] = idKnjige;
                    i++;
                }

                reader.Close();

                BrisanjeKnjiga(niz, i);
            }
            catch (Exception err)
            {
               
            }
        }

        public static void PrikaziKnjige(DataGridView dgv)
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM knjiga, autor " +
                           "WHERE knjiga.autorID = autor.id";
            DataTable tabela = new DataTable();

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(tabela);
                dgv.DataSource = tabela;
                dgv.Columns["id"].Visible = false;
                dgv.Columns["autorID"].Visible = false;
                dgv.Columns["id1"].Visible = false;
                dgv.Columns["biografija"].Visible = false;
            }
            catch
            {

            }
        }
    }
}
