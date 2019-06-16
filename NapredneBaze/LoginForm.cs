using NapredneBaze.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NapredneBaze
{
    public partial class LoginForm : Form
    {
        Panel p1, p2, p3, p4, p5;

        public LoginForm(Panel p1, Panel p2, Panel p3, Panel p4, Panel p5)
        {
            InitializeComponent();
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
        }

        private void buttonLI_Click(object sender, EventArgs e)
        {
            Clan clan = new Clan();
            string username = textBoxUsernameLI.Text;
            string password = textBoxPasswordLI.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Polja ne mogu biti prazna");
                return;
            }
            else
            {
                int logRes = clan.LogIn(username, password);

                if (logRes == -1)
                {
                    this.Close();
                    RegistracijaForm form = new RegistracijaForm();
                    form.Show();
                }
                else if (logRes == 0)
                {
                    //korisnik
                    p1.Visible = false; //autor
                    p2.Visible = false; //knjige
                    p3.Visible = true; //1
                    p4.Visible = false; //2
                    p5.Visible = false; //admin
                    this.Close();
                }
                else if (logRes == 1)
                {
                    //admin
                    p1.Visible = false; //autor
                    p2.Visible = false; //knjige
                    p3.Visible = false; //1
                    p4.Visible = false; //2
                    p5.Visible = true; //admin
                    this.Close();
                }
                else if (logRes == -2)
                {
                    
                }
                else
                {
                    this.Close();
                }
               
            }
            
        }
    }
}
