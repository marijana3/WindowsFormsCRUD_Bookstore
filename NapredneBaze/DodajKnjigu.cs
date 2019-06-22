using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NapredneBaze.Model;

namespace NapredneBaze
{
    public partial class DodajKnjigu : Form
    {

        int id;

        public DodajKnjigu()
        {
            InitializeComponent();
            comboBoxAutorDK.Items.Clear();
            buttonIzmijeniDK.Visible = false;
            buttonDodajDK.Visible = true;
            Autor.listaAutora(comboBoxAutorDK);
        }

        public DodajKnjigu(int id)
        {
            InitializeComponent();
            Autor.listaAutora(comboBoxAutorDK);
            this.id = id;
            buttonIzmijeniDK.Visible = true;
            buttonDodajDK.Visible = false;
        }

        private void buttonDodajDK_Click(object sender, EventArgs e)
        {
            if (textBoxNazivDK.Text == "" || textBoxOpisDK.Text == "" || textBoxCijenaDK.Text == "" || textBoxZanrDK.Text == "" || comboBoxAutorDK.Text == "")
            {
                MessageBox.Show("Sva polja moraju biti popunjena!\n");
                return;
            }

            string[] arr = comboBoxAutorDK.Text.Split(' ');
            string ime = arr[0];
            string prezime = arr[1];
            int id = Autor.nadjiID(ime, prezime);

            Knjiga knjiga = new Knjiga(id, textBoxNazivDK.Text, textBoxOpisDK.Text, Double.Parse(textBoxCijenaDK.Text), textBoxZanrDK.Text); 

            knjiga.UnosKnjige();

            this.Close();
        }

        private void buttonIzmijeniDK_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();

            String query = "select autorID, naziv, opis, cijena, zanr from knjiga where id=@idParam";
            string naziv, opis, zanr;
            double cijena;
            int autorID;

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.Add("idParam", MySqlDbType.Int32);
                command.Parameters["idParam"].Value = id;

                MySqlDataReader reader = command.ExecuteReader();

                reader.Read();

                naziv = reader["naziv"].ToString();
                opis = reader["opis"].ToString();
                zanr = reader["zanr"].ToString();
                autorID = Int32.Parse(reader["autorID"].ToString());
                cijena = Double.Parse(reader["cijena"].ToString());

                reader.Close();

                if (textBoxNazivDK.Text != "") naziv = textBoxNazivDK.Text;
                if (textBoxOpisDK.Text != "") opis = textBoxOpisDK.Text;
                if (textBoxZanrDK.Text != "") zanr = textBoxZanrDK.Text;
                if (textBoxCijenaDK.Text != "") cijena = Double.Parse(textBoxCijenaDK.Text);
                if (comboBoxAutorDK.Text != "")
                {
                    string[] arr = comboBoxAutorDK.Text.Split(' ');
                    string ime = arr[0];
                    string prezime = arr[1];
                    autorID = Autor.nadjiID(ime, prezime);
                }

                Knjiga knjiga = new Knjiga(autorID, naziv, opis, cijena, zanr);
                knjiga.IzmjenaKnjige(this.id);
                this.Close();
            }
            catch (Exception err)
            {

            }

        }
    }
}
