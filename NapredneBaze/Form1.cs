using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using MySql.Data.MySqlClient;
using NapredneBaze.Model;

namespace NapredneBaze
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = DBConnection.getConnection();
            Autor.listaAutora(comboBoxAutoriA);
            Knjiga.listaKnjiga(comboBoxKnjigeA);
            Autor.listaAutora(comboBoxAutoriBrisi);
            Knjiga.listaKnjiga(comboBoxKnjigeBrisi);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm(panelAutor, panelKnjige, panel1, panel2, panelAdmin);
            form.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistracijaForm form = new RegistracijaForm();
            form.Show();
        }

        private void buttonAutori_Click(object sender, EventArgs e)
        {
            Autor.listaAutora(comboBoxAutori);
            panelAutor.Visible = true;
            panelKnjige.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panelAdmin.Visible = false;
        }

        private void buttonKnjige_Click(object sender, EventArgs e)
        {
            panelKnjige.Visible = true;
            panelAutor.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panelAdmin.Visible = false;
            Knjiga.PrikaziKnjige(dataGridView1);
        }

        private void buttonBackA_Click(object sender, EventArgs e)
        {
            panelAutor.Visible = false;
            panelKnjige.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            panelAdmin.Visible = false;
            comboBoxAutori.SelectedIndex = -1;
            comboBoxAutori.Items.Clear();
            labelImeA.Visible = false;
            labelPrezimeA.Visible = false;
            labelBiografijaA.Visible = false;
            pictureBoxAutor.Visible = false;
            labelImeSelected.Visible = false;
            labelPrezimeSelected.Visible = false;
            textBoxBiografijaSelected.Visible = false;
        }

        private void buttonBackK_Click(object sender, EventArgs e)
        {
            panelAutor.Visible = false;
            panelKnjige.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            panelAdmin.Visible = false;
            textBoxOpisK.Visible = false;
        }

        private void buttonDodajKnjigu_Click(object sender, EventArgs e)
        {
            DodajKnjigu form = new DodajKnjigu();
            form.ShowDialog();
            comboBoxKnjigeA.Items.Clear();
            comboBoxKnjigeBrisi.Items.Clear();
            Knjiga.listaKnjiga(comboBoxKnjigeA);
            Knjiga.listaKnjiga(comboBoxKnjigeBrisi);
        }

        private void comboBoxAutori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAutori.Text == "") return;
            string[] arr = comboBoxAutori.Text.Split(' ');
            string ime = arr[0];
            string prezime = arr[1];
            labelImeA.Visible = true;
            labelPrezimeA.Visible = true;
            labelBiografijaA.Visible = true;
            Autor.detaljiOAutoru(ime, prezime, labelImeSelected, labelPrezimeSelected, textBoxBiografijaSelected, pictureBoxAutor);
        }

        private void comboBoxKnjigeA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKnjigeA.SelectedIndex == -1) return;
            string naziv = comboBoxKnjigeA.Text;
            int id = Knjiga.nadjiID(naziv);
            DodajKnjigu form = new DodajKnjigu(id);
            form.ShowDialog();
            comboBoxKnjigeA.SelectedIndex = -1;
            comboBoxKnjigeA.Items.Clear();
            comboBoxKnjigeBrisi.Items.Clear();
            Knjiga.listaKnjiga(comboBoxKnjigeA);
            Knjiga.listaKnjiga(comboBoxKnjigeBrisi);
        }

        private void buttonDodajAutora_Click(object sender, EventArgs e)
        {
            DodajAutora form = new DodajAutora();
            form.ShowDialog();
            comboBoxAutoriA.Items.Clear();
            comboBoxAutoriBrisi.Items.Clear();
            Autor.listaAutora(comboBoxAutoriA);
            Autor.listaAutora(comboBoxAutoriBrisi);
        }

        private void comboBoxAutoriA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAutoriA.SelectedIndex == -1) return;
            string[] arr = comboBoxAutoriA.Text.Split(' ');
            string ime = arr[0];
            string prezime = arr[1];
            int id = Autor.nadjiID(ime, prezime);
            DodajAutora form = new DodajAutora(id);
            form.ShowDialog();
            comboBoxAutoriA.SelectedIndex = -1;
            comboBoxAutoriA.Items.Clear();
            comboBoxAutoriBrisi.Items.Clear();
            Autor.listaAutora(comboBoxAutoriA);
            Autor.listaAutora(comboBoxAutoriBrisi);
        }

        private void buttonNazadA_Click(object sender, EventArgs e)
        {
            panelAutor.Visible = false;
            panelKnjige.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            panelAdmin.Visible = false;
            comboBoxKnjigeA.SelectedIndex = -1;
            comboBoxAutoriA.SelectedIndex = -1;
            comboBoxKnjigeBrisi.SelectedIndex = -1;
            comboBoxAutoriBrisi.SelectedIndex = -1;
        }

        private void comboBoxKnjigeBrisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKnjigeBrisi.SelectedIndex == -1) return;
            var confirmResult = MessageBox.Show("Jeste li sigurni?", "Potvrdite brisanje!",
                                MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                string naziv = comboBoxKnjigeBrisi.Text;
                int id = Knjiga.nadjiID(naziv);
                Knjiga.BrisanjeKnjige(id);
                comboBoxKnjigeBrisi.SelectedIndex = -1;
                comboBoxKnjigeA.Items.Clear();
                comboBoxKnjigeBrisi.Items.Clear();
                Knjiga.listaKnjiga(comboBoxKnjigeA);
                Knjiga.listaKnjiga(comboBoxKnjigeBrisi);
            }
            else
            {
                comboBoxKnjigeBrisi.SelectedIndex = -1;
            }
        }

        private void comboBoxAutoriBrisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAutoriBrisi.SelectedIndex == -1) return;

            var confirmResult = MessageBox.Show("Jeste li sigurni?", "Potvrdite brisanje!",
                                MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                string[] arr = comboBoxAutoriBrisi.Text.Split(' ');
                string ime = arr[0];
                string prezime = arr[1];
                int id = Autor.nadjiID(ime, prezime);
                Knjiga.BrisanjeKnjigaKaskadno(id);
                Autor.BrisanjeAutora(id);
                comboBoxAutoriBrisi.SelectedIndex = -1;
                comboBoxAutoriA.Items.Clear();
                comboBoxAutoriBrisi.Items.Clear();
                Autor.listaAutora(comboBoxAutoriA);
                Autor.listaAutora(comboBoxAutoriBrisi);
                comboBoxKnjigeA.Items.Clear();
                comboBoxKnjigeBrisi.Items.Clear();
                Knjiga.listaKnjiga(comboBoxKnjigeA);
                Knjiga.listaKnjiga(comboBoxKnjigeBrisi);

                String destPath = "../../Autori/" + ime + "" + prezime + ".jpg";
                if (File.Exists(destPath))
                {
                    File.Delete(destPath);
                }
            }
            else
            {
                comboBoxAutoriBrisi.SelectedIndex = -1;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewCell cell = (DataGridViewCell) dataGridView1.Rows[e.RowIndex].Cells[3];

            textBoxOpisK.Text = cell.Value.ToString();
            textBoxOpisK.Visible = true;
        }

        private void buttonNazadKor_Click(object sender, EventArgs e)
        {
            panelAutor.Visible = false;
            panelKnjige.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            panelAdmin.Visible = false;
        }
    }
}
