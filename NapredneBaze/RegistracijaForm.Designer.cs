namespace NapredneBaze
{
    partial class RegistracijaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistracijaForm));
            this.panelRegister = new System.Windows.Forms.Panel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelKod = new System.Windows.Forms.Label();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxGrad = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.checkBoxPopust = new System.Windows.Forms.CheckBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelGrad = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegister
            // 
            this.panelRegister.BackgroundImage = global::NapredneBaze.Properties.Resources.login2;
            this.panelRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegister.Controls.Add(this.buttonRegister);
            this.panelRegister.Controls.Add(this.labelKod);
            this.panelRegister.Controls.Add(this.textBoxKod);
            this.panelRegister.Controls.Add(this.textBoxPassword);
            this.panelRegister.Controls.Add(this.textBoxUsername);
            this.panelRegister.Controls.Add(this.textBoxGrad);
            this.panelRegister.Controls.Add(this.textBoxPrezime);
            this.panelRegister.Controls.Add(this.textBoxIme);
            this.panelRegister.Controls.Add(this.checkBoxPopust);
            this.panelRegister.Controls.Add(this.labelPassword);
            this.panelRegister.Controls.Add(this.labelUsername);
            this.panelRegister.Controls.Add(this.labelGrad);
            this.panelRegister.Controls.Add(this.labelPrezime);
            this.panelRegister.Controls.Add(this.labelIme);
            this.panelRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(547, 278);
            this.panelRegister.TabIndex = 0;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Sienna;
            this.buttonRegister.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRegister.Location = new System.Drawing.Point(224, 229);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(93, 37);
            this.buttonRegister.TabIndex = 13;
            this.buttonRegister.Text = "Učlani se!";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelKod
            // 
            this.labelKod.AutoSize = true;
            this.labelKod.BackColor = System.Drawing.Color.Transparent;
            this.labelKod.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelKod.ForeColor = System.Drawing.Color.Sienna;
            this.labelKod.Location = new System.Drawing.Point(318, 196);
            this.labelKod.Name = "labelKod";
            this.labelKod.Size = new System.Drawing.Size(120, 17);
            this.labelKod.TabIndex = 12;
            this.labelKod.Text = "Unesite promo kod!";
            this.labelKod.Visible = false;
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(224, 193);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.PasswordChar = '*';
            this.textBoxKod.Size = new System.Drawing.Size(70, 20);
            this.textBoxKod.TabIndex = 11;
            this.textBoxKod.UseSystemPasswordChar = true;
            this.textBoxKod.Visible = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(224, 152);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(156, 20);
            this.textBoxPassword.TabIndex = 10;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(224, 118);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(156, 20);
            this.textBoxUsername.TabIndex = 9;
            // 
            // textBoxGrad
            // 
            this.textBoxGrad.Location = new System.Drawing.Point(224, 89);
            this.textBoxGrad.Name = "textBoxGrad";
            this.textBoxGrad.Size = new System.Drawing.Size(156, 20);
            this.textBoxGrad.TabIndex = 8;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(224, 58);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(156, 20);
            this.textBoxPrezime.TabIndex = 7;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(224, 27);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(156, 20);
            this.textBoxIme.TabIndex = 6;
            // 
            // checkBoxPopust
            // 
            this.checkBoxPopust.AutoSize = true;
            this.checkBoxPopust.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPopust.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.checkBoxPopust.ForeColor = System.Drawing.Color.Sienna;
            this.checkBoxPopust.Location = new System.Drawing.Point(102, 196);
            this.checkBoxPopust.Name = "checkBoxPopust";
            this.checkBoxPopust.Size = new System.Drawing.Size(68, 21);
            this.checkBoxPopust.TabIndex = 5;
            this.checkBoxPopust.Text = "Popust";
            this.checkBoxPopust.UseVisualStyleBackColor = false;
            this.checkBoxPopust.CheckedChanged += new System.EventHandler(this.checkBoxPopust_CheckedChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelPassword.ForeColor = System.Drawing.Color.Sienna;
            this.labelPassword.Location = new System.Drawing.Point(99, 155);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(58, 17);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Lozinka:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUsername.ForeColor = System.Drawing.Color.Sienna;
            this.labelUsername.Location = new System.Drawing.Point(99, 121);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(97, 17);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Korisničko ime:";
            // 
            // labelGrad
            // 
            this.labelGrad.AutoSize = true;
            this.labelGrad.BackColor = System.Drawing.Color.Transparent;
            this.labelGrad.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelGrad.ForeColor = System.Drawing.Color.Sienna;
            this.labelGrad.Location = new System.Drawing.Point(99, 92);
            this.labelGrad.Name = "labelGrad";
            this.labelGrad.Size = new System.Drawing.Size(40, 17);
            this.labelGrad.TabIndex = 2;
            this.labelGrad.Text = "Grad:";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.BackColor = System.Drawing.Color.Transparent;
            this.labelPrezime.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrezime.ForeColor = System.Drawing.Color.Sienna;
            this.labelPrezime.Location = new System.Drawing.Point(99, 61);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(59, 17);
            this.labelPrezime.TabIndex = 1;
            this.labelPrezime.Text = "Prezime:";
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.BackColor = System.Drawing.Color.Transparent;
            this.labelIme.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIme.ForeColor = System.Drawing.Color.Sienna;
            this.labelIme.Location = new System.Drawing.Point(99, 30);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(33, 17);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime:";
            // 
            // RegistracijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 278);
            this.Controls.Add(this.panelRegister);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistracijaForm";
            this.Text = "RegistracijaForm";
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelGrad;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.CheckBox checkBoxPopust;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelKod;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxGrad;
    }
}