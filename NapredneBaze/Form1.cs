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
            Knjiga.PrikaziKnjige(dataGridView1);
            panelKnjige.Visible = true;
            panelAutor.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panelAdmin.Visible = false;
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

        private void buttonDodajAutora_Click(object sender, EventArgs e)
        {
            DodajAutora form = new DodajAutora();
            form.ShowDialog();
        }

        private void buttonNazadA_Click(object sender, EventArgs e)
        {
            panelAutor.Visible = false;
            panelKnjige.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            panelAdmin.Visible = false;
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

        private void buttonIzmijeniKnjigu_Click(object sender, EventArgs e)
        {
            IzmijeniBrisiKnjigu form = new IzmijeniBrisiKnjigu(false);
            form.ShowDialog();
        }

        private void buttonBrisiKnjigu_Click(object sender, EventArgs e)
        {
            IzmijeniBrisiKnjigu form = new IzmijeniBrisiKnjigu(true);
            form.ShowDialog();
        }

        private void buttonIzmijeniAutora_Click(object sender, EventArgs e)
        {
            IzmijeniBrisiAutora form = new IzmijeniBrisiAutora(false);
            form.ShowDialog();
        }

        private void buttonBrisiAutora_Click(object sender, EventArgs e)
        {
            IzmijeniBrisiAutora form = new IzmijeniBrisiAutora(true);
            form.ShowDialog();
        }
    }
}
