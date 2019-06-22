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
    public partial class IzmijeniBrisiAutora : Form
    {
        public IzmijeniBrisiAutora(bool multiselect)
        {
            InitializeComponent();
            dataGridViewAutori.MultiSelect = multiselect;
        }

        private void IzmijeniBrisiAutora_Load(object sender, EventArgs e)
        {
            Autor.PrikaziAutore(dataGridViewAutori);
        }

        private void buttonIzmijeniAutora_Click(object sender, EventArgs e)
        {
            if (dataGridViewAutori.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite autora kog mijenjate!");
                return;
            }

            try
            {
                int id = Int32.Parse(dataGridViewAutori.SelectedRows[0].Cells["id"].Value.ToString());
                DodajAutora form = new DodajAutora(id);
                form.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show("Null pointer exception!\n" + err);
            }

            Autor.PrikaziAutore(dataGridViewAutori);
        }

        private void buttonBrisiAutora_Click(object sender, EventArgs e)
        {
            if (dataGridViewAutori.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite autora kog brišete!");
                return;
            }
            for (int i = 0; i < dataGridViewAutori.SelectedRows.Count; i++)
            {
                try
                {
                    int id = Int32.Parse(dataGridViewAutori.SelectedRows[i].Cells["id"].Value.ToString());
                    String ime = dataGridViewAutori.SelectedRows[i].Cells["ime"].Value.ToString();
                    String prezime = dataGridViewAutori.SelectedRows[i].Cells["prezime"].Value.ToString();
                    var confirmResult = MessageBox.Show("Jeste li sigurni?", "Potvrdite brisanje!",
                                MessageBoxButtons.OKCancel);
                    if (confirmResult == DialogResult.OK)
                    {
                        Knjiga.BrisanjeKnjigaKaskadno(id);
                        Autor.BrisanjeAutora(id);
                        String destPath = "../../Autori/" + ime + "" + prezime + ".jpg";
                        if (File.Exists(destPath))
                        {
                            File.Delete(destPath);
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Null pointer exception!\n" + err);
                }
            }
           
            Autor.PrikaziAutore(dataGridViewAutori);
        }
    }
}
