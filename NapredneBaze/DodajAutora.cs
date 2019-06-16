using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NapredneBaze.Model;

namespace NapredneBaze
{
    public partial class DodajAutora : Form
    {

        int id;

        public DodajAutora()
        {
            InitializeComponent();
            buttonIzmijeniDA.Visible = false;
            buttonDodajDA.Visible = true;
        }

        public DodajAutora(int id)
        {
            InitializeComponent();
            this.id = id;
            buttonIzmijeniDA.Visible = true;
            buttonDodajDA.Visible = false;
        }

        private void buttonDodajFotografiju_Click_1(object sender, EventArgs e)
        {
            if (textBoxImeDA.Text == "" || textBoxPrezimeDA.Text == "")
            {
                MessageBox.Show("Unesite ime i prezime autora!");
                return;
            }

            openFileDialogPicture.FileName = "";
            openFileDialogPicture.Filter = "jpg files (*.jpg)|*.jpg";
            
            openFileDialogPicture.Title = "Odaberite fotografiju";


            if (openFileDialogPicture.ShowDialog() == DialogResult.OK)
            {
                String filePath = openFileDialogPicture.FileName; // citava putanja do fajla

                String destPath = "../../Autori/" + textBoxImeDA.Text + "" + textBoxPrezimeDA.Text + ".jpg";
                FileInfo fi = new FileInfo(filePath);

                fi.CopyTo(destPath);
            }
        }

        private void buttonDodajDA_Click(object sender, EventArgs e)
        {
            if (textBoxImeDA.Text == "" || textBoxPrezimeDA.Text == "" || textBoxBiografijaDA.Text == "")
            {
                MessageBox.Show("Sva polja moraju biti popunjena!\n");
                return;
            }

            Autor autor = new Autor(textBoxImeDA.Text, textBoxPrezimeDA.Text, textBoxBiografijaDA.Text);
            autor.UnosAutora();

            this.Close();
        }

        private void buttonIzmijeniDA_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = DBConnection.getConnection();
            MySqlCommand command = new MySqlCommand();

            String query = "select ime, prezime, biografija from autor where id=@idParam";
            string ime, prezime, biografija;

            try
            {
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.Add("idParam", MySqlDbType.Int32);
                command.Parameters["idParam"].Value = id;

                MySqlDataReader reader = command.ExecuteReader();

                reader.Read();

                ime = reader["ime"].ToString();
                prezime = reader["prezime"].ToString();
                biografija = reader["biografija"].ToString();

                reader.Close();

                String destPath1 = "../../Autori/" + ime + "" + prezime + ".jpg";

                int changed = 0;

                if (textBoxImeDA.Text != "")
                {
                    ime = textBoxImeDA.Text;
                    changed = 1;
                }
                if (textBoxPrezimeDA.Text != "")
                {
                    prezime = textBoxPrezimeDA.Text;
                    changed = 1;
                }
                if (textBoxBiografijaDA.Text != "")
                {
                    biografija = textBoxBiografijaDA.Text;
                }

                if (changed == 1)
                {
                    if (File.Exists(destPath1))
                    {
                        String destPath2 = "../../Autori/" + ime + "" + prezime + ".jpg";
                        File.Copy(destPath1, destPath2, true);
                        File.Delete(destPath1);
                    }
                }

                Autor autor = new Autor(ime, prezime, biografija);
                autor.IzmjenaAutora(this.id);
                this.Close();
            }
            catch (Exception err)
            {

            }

        }
    }
}
