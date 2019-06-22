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
    public partial class IzmijeniBrisiKnjigu : Form
    {
        public IzmijeniBrisiKnjigu(bool multiselect)
        {
            InitializeComponent();
            dataGridViewKnjige.MultiSelect = multiselect;
        }

        private void IzmijeniBrisiKnjigu_Load(object sender, EventArgs e)
        {
            Knjiga.PrikaziKnjige(dataGridViewKnjige);
        }

        private void buttonIzmijeniKnjigu_Click(object sender, EventArgs e)
        {
            if (dataGridViewKnjige.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite knjigu koju mijenjate!");
                return;
            }
         
            try
            {
                int id = Int32.Parse(dataGridViewKnjige.SelectedRows[0].Cells["id"].Value.ToString());
                DodajKnjigu form = new DodajKnjigu(id);
                form.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show("Null pointer exception!\n" + err);
            }
            Knjiga.PrikaziKnjige(dataGridViewKnjige);
        }

        private void buttonBrisiKnjigu_Click(object sender, EventArgs e)
        {
            if (dataGridViewKnjige.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite knjigu koju brišete!");
                return;
            }
            for (int i = 0; i < dataGridViewKnjige.SelectedRows.Count; i++)
            {
                try
                {
                    int id = Int32.Parse(dataGridViewKnjige.SelectedRows[i].Cells["id"].Value.ToString());
                    var confirmResult = MessageBox.Show("Jeste li sigurni?", "Potvrdite brisanje!",
                                MessageBoxButtons.OKCancel);
                    if (confirmResult == DialogResult.OK)
                    {
                        Knjiga.BrisanjeKnjige(id);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Null pointer exception!\n" + err);
                }
            }
            
            Knjiga.PrikaziKnjige(dataGridViewKnjige);
        }
    }
}
