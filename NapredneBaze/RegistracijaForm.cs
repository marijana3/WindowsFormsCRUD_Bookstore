using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NapredneBaze.Model;

namespace NapredneBaze
{
    public partial class RegistracijaForm : Form
    {

        public RegistracijaForm()
        {
            InitializeComponent();
        }

        private void checkBoxPopust_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxPopust.Checked)
            {
                textBoxKod.Visible = true;
                labelKod.Visible = true;
            }
            else
            {
                textBoxKod.Visible = false;
                labelKod.Visible = false
;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxIme.Text == "" || textBoxPrezime.Text == "" || textBoxGrad.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Sva polja moraju biti popunjena!\n");
                return;
            }

            string kod = "0000";
            if (checkBoxPopust.Checked) kod = textBoxKod.Text;
            Clan clan = new Clan(textBoxIme.Text, textBoxPrezime.Text, textBoxGrad.Text, textBoxUsername.Text, textBoxPassword.Text, kod);

            int postojiUser = clan.ProvjeriUsername(textBoxUsername.Text);
            
            if (postojiUser == 2)
            {
                return;
            }
            if (postojiUser == 1)
            {
                MessageBox.Show("Vec postoji korisnik sa ovim username-om!");
                return;
            }

            clan.UnosClana();

            this.Close();
        }


    }
}
