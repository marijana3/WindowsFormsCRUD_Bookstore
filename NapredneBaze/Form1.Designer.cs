﻿namespace NapredneBaze
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.panelAutor = new System.Windows.Forms.Panel();
            this.pictureBoxAutor = new System.Windows.Forms.PictureBox();
            this.buttonBackA = new System.Windows.Forms.Button();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelPrezimeSelected = new System.Windows.Forms.Label();
            this.labelImeSelected = new System.Windows.Forms.Label();
            this.labelBiografijaA = new System.Windows.Forms.Label();
            this.labelImeA = new System.Windows.Forms.Label();
            this.labelPrezimeA = new System.Windows.Forms.Label();
            this.comboBoxAutori = new System.Windows.Forms.ComboBox();
            this.textBoxBiografijaSelected = new System.Windows.Forms.TextBox();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.buttonIzmijeniAutora = new System.Windows.Forms.Button();
            this.buttonBrisiKnjigu = new System.Windows.Forms.Button();
            this.buttonIzmijeniKnjigu = new System.Windows.Forms.Button();
            this.buttonNazadA = new System.Windows.Forms.Button();
            this.buttonDodajAutora = new System.Windows.Forms.Button();
            this.buttonDodajKnjigu = new System.Windows.Forms.Button();
            this.panelKnjige = new System.Windows.Forms.Panel();
            this.textBoxOpisK = new System.Windows.Forms.TextBox();
            this.buttonBackK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.buttonKnjige = new System.Windows.Forms.Button();
            this.buttonAutori = new System.Windows.Forms.Button();
            this.buttonNazadKor = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBrisiAutora = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panelAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutor)).BeginInit();
            this.panelAdmin.SuspendLayout();
            this.panelKnjige.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Controls.Add(this.btnLogIn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(526, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 497);
            this.panel2.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Sienna;
            this.btnRegister.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegister.Location = new System.Drawing.Point(39, 229);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(159, 43);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Učlani se";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Sienna;
            this.btnLogIn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.Location = new System.Drawing.Point(39, 129);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(159, 43);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Uloguj se";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // panelAutor
            // 
            this.panelAutor.BackColor = System.Drawing.Color.BurlyWood;
            this.panelAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAutor.Controls.Add(this.pictureBoxAutor);
            this.panelAutor.Controls.Add(this.buttonBackA);
            this.panelAutor.Controls.Add(this.labelOpis);
            this.panelAutor.Controls.Add(this.labelPrezimeSelected);
            this.panelAutor.Controls.Add(this.labelImeSelected);
            this.panelAutor.Controls.Add(this.labelBiografijaA);
            this.panelAutor.Controls.Add(this.labelImeA);
            this.panelAutor.Controls.Add(this.labelPrezimeA);
            this.panelAutor.Controls.Add(this.comboBoxAutori);
            this.panelAutor.Controls.Add(this.textBoxBiografijaSelected);
            this.panelAutor.Location = new System.Drawing.Point(0, 0);
            this.panelAutor.Name = "panelAutor";
            this.panelAutor.Size = new System.Drawing.Size(761, 497);
            this.panelAutor.TabIndex = 4;
            this.panelAutor.Visible = false;
            // 
            // pictureBoxAutor
            // 
            this.pictureBoxAutor.Location = new System.Drawing.Point(310, 24);
            this.pictureBoxAutor.Name = "pictureBoxAutor";
            this.pictureBoxAutor.Size = new System.Drawing.Size(258, 144);
            this.pictureBoxAutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAutor.TabIndex = 9;
            this.pictureBoxAutor.TabStop = false;
            // 
            // buttonBackA
            // 
            this.buttonBackA.BackColor = System.Drawing.Color.Sienna;
            this.buttonBackA.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackA.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBackA.Location = new System.Drawing.Point(47, 412);
            this.buttonBackA.Name = "buttonBackA";
            this.buttonBackA.Size = new System.Drawing.Size(108, 36);
            this.buttonBackA.TabIndex = 8;
            this.buttonBackA.Text = "Nazad";
            this.buttonBackA.UseVisualStyleBackColor = false;
            this.buttonBackA.Click += new System.EventHandler(this.buttonBackA_Click);
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis.ForeColor = System.Drawing.Color.Snow;
            this.labelOpis.Location = new System.Drawing.Point(27, 24);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(128, 18);
            this.labelOpis.TabIndex = 7;
            this.labelOpis.Text = "Odaberite autora:";
            // 
            // labelPrezimeSelected
            // 
            this.labelPrezimeSelected.AutoSize = true;
            this.labelPrezimeSelected.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelPrezimeSelected.ForeColor = System.Drawing.Color.Sienna;
            this.labelPrezimeSelected.Location = new System.Drawing.Point(212, 155);
            this.labelPrezimeSelected.Name = "labelPrezimeSelected";
            this.labelPrezimeSelected.Size = new System.Drawing.Size(58, 18);
            this.labelPrezimeSelected.TabIndex = 5;
            this.labelPrezimeSelected.Text = "prezime";
            this.labelPrezimeSelected.Visible = false;
            // 
            // labelImeSelected
            // 
            this.labelImeSelected.AutoSize = true;
            this.labelImeSelected.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImeSelected.ForeColor = System.Drawing.Color.Sienna;
            this.labelImeSelected.Location = new System.Drawing.Point(212, 112);
            this.labelImeSelected.Name = "labelImeSelected";
            this.labelImeSelected.Size = new System.Drawing.Size(31, 18);
            this.labelImeSelected.TabIndex = 4;
            this.labelImeSelected.Text = "ime";
            this.labelImeSelected.Visible = false;
            // 
            // labelBiografijaA
            // 
            this.labelBiografijaA.AutoSize = true;
            this.labelBiografijaA.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelBiografijaA.ForeColor = System.Drawing.Color.Snow;
            this.labelBiografijaA.Location = new System.Drawing.Point(60, 207);
            this.labelBiografijaA.Name = "labelBiografijaA";
            this.labelBiografijaA.Size = new System.Drawing.Size(69, 17);
            this.labelBiografijaA.TabIndex = 3;
            this.labelBiografijaA.Text = "Biografija:";
            this.labelBiografijaA.Visible = false;
            // 
            // labelImeA
            // 
            this.labelImeA.AutoSize = true;
            this.labelImeA.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImeA.ForeColor = System.Drawing.Color.Snow;
            this.labelImeA.Location = new System.Drawing.Point(60, 112);
            this.labelImeA.Name = "labelImeA";
            this.labelImeA.Size = new System.Drawing.Size(33, 17);
            this.labelImeA.TabIndex = 2;
            this.labelImeA.Text = "Ime:";
            this.labelImeA.Visible = false;
            // 
            // labelPrezimeA
            // 
            this.labelPrezimeA.AutoSize = true;
            this.labelPrezimeA.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelPrezimeA.ForeColor = System.Drawing.Color.Snow;
            this.labelPrezimeA.Location = new System.Drawing.Point(60, 155);
            this.labelPrezimeA.Name = "labelPrezimeA";
            this.labelPrezimeA.Size = new System.Drawing.Size(59, 17);
            this.labelPrezimeA.TabIndex = 1;
            this.labelPrezimeA.Text = "Prezime:";
            this.labelPrezimeA.Visible = false;
            // 
            // comboBoxAutori
            // 
            this.comboBoxAutori.DropDownHeight = 110;
            this.comboBoxAutori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAutori.FormattingEnabled = true;
            this.comboBoxAutori.IntegralHeight = false;
            this.comboBoxAutori.Location = new System.Drawing.Point(27, 47);
            this.comboBoxAutori.Name = "comboBoxAutori";
            this.comboBoxAutori.Size = new System.Drawing.Size(222, 21);
            this.comboBoxAutori.TabIndex = 0;
            this.comboBoxAutori.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutori_SelectedIndexChanged);
            // 
            // textBoxBiografijaSelected
            // 
            this.textBoxBiografijaSelected.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxBiografijaSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBiografijaSelected.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxBiografijaSelected.ForeColor = System.Drawing.Color.Sienna;
            this.textBoxBiografijaSelected.Location = new System.Drawing.Point(215, 203);
            this.textBoxBiografijaSelected.Multiline = true;
            this.textBoxBiografijaSelected.Name = "textBoxBiografijaSelected";
            this.textBoxBiografijaSelected.Size = new System.Drawing.Size(390, 218);
            this.textBoxBiografijaSelected.TabIndex = 6;
            this.textBoxBiografijaSelected.Visible = false;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.BurlyWood;
            this.panelAdmin.Controls.Add(this.buttonBrisiAutora);
            this.panelAdmin.Controls.Add(this.buttonIzmijeniAutora);
            this.panelAdmin.Controls.Add(this.buttonBrisiKnjigu);
            this.panelAdmin.Controls.Add(this.buttonIzmijeniKnjigu);
            this.panelAdmin.Controls.Add(this.buttonNazadA);
            this.panelAdmin.Controls.Add(this.buttonDodajAutora);
            this.panelAdmin.Controls.Add(this.buttonDodajKnjigu);
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(761, 497);
            this.panelAdmin.TabIndex = 9;
            this.panelAdmin.Visible = false;
            // 
            // buttonIzmijeniAutora
            // 
            this.buttonIzmijeniAutora.BackColor = System.Drawing.Color.Sienna;
            this.buttonIzmijeniAutora.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIzmijeniAutora.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonIzmijeniAutora.Location = new System.Drawing.Point(495, 176);
            this.buttonIzmijeniAutora.Name = "buttonIzmijeniAutora";
            this.buttonIzmijeniAutora.Size = new System.Drawing.Size(142, 43);
            this.buttonIzmijeniAutora.TabIndex = 13;
            this.buttonIzmijeniAutora.Text = "Izmijeni autora";
            this.buttonIzmijeniAutora.UseVisualStyleBackColor = false;
            this.buttonIzmijeniAutora.Click += new System.EventHandler(this.buttonIzmijeniAutora_Click);
            // 
            // buttonBrisiKnjigu
            // 
            this.buttonBrisiKnjigu.BackColor = System.Drawing.Color.Sienna;
            this.buttonBrisiKnjigu.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBrisiKnjigu.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBrisiKnjigu.Location = new System.Drawing.Point(107, 272);
            this.buttonBrisiKnjigu.Name = "buttonBrisiKnjigu";
            this.buttonBrisiKnjigu.Size = new System.Drawing.Size(142, 43);
            this.buttonBrisiKnjigu.TabIndex = 12;
            this.buttonBrisiKnjigu.Text = "Briši knjigu";
            this.buttonBrisiKnjigu.UseVisualStyleBackColor = false;
            this.buttonBrisiKnjigu.Click += new System.EventHandler(this.buttonBrisiKnjigu_Click);
            // 
            // buttonIzmijeniKnjigu
            // 
            this.buttonIzmijeniKnjigu.BackColor = System.Drawing.Color.Sienna;
            this.buttonIzmijeniKnjigu.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIzmijeniKnjigu.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonIzmijeniKnjigu.Location = new System.Drawing.Point(107, 176);
            this.buttonIzmijeniKnjigu.Name = "buttonIzmijeniKnjigu";
            this.buttonIzmijeniKnjigu.Size = new System.Drawing.Size(142, 43);
            this.buttonIzmijeniKnjigu.TabIndex = 11;
            this.buttonIzmijeniKnjigu.Text = "Izmijeni knjigu";
            this.buttonIzmijeniKnjigu.UseVisualStyleBackColor = false;
            this.buttonIzmijeniKnjigu.Click += new System.EventHandler(this.buttonIzmijeniKnjigu_Click);
            // 
            // buttonNazadA
            // 
            this.buttonNazadA.BackColor = System.Drawing.Color.Sienna;
            this.buttonNazadA.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonNazadA.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonNazadA.Location = new System.Drawing.Point(310, 392);
            this.buttonNazadA.Name = "buttonNazadA";
            this.buttonNazadA.Size = new System.Drawing.Size(142, 43);
            this.buttonNazadA.TabIndex = 5;
            this.buttonNazadA.Text = "Odjavi se";
            this.buttonNazadA.UseVisualStyleBackColor = false;
            this.buttonNazadA.Click += new System.EventHandler(this.buttonNazadA_Click);
            // 
            // buttonDodajAutora
            // 
            this.buttonDodajAutora.BackColor = System.Drawing.Color.Sienna;
            this.buttonDodajAutora.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonDodajAutora.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDodajAutora.Location = new System.Drawing.Point(495, 74);
            this.buttonDodajAutora.Name = "buttonDodajAutora";
            this.buttonDodajAutora.Size = new System.Drawing.Size(142, 43);
            this.buttonDodajAutora.TabIndex = 1;
            this.buttonDodajAutora.Text = "Dodaj autora";
            this.buttonDodajAutora.UseVisualStyleBackColor = false;
            this.buttonDodajAutora.Click += new System.EventHandler(this.buttonDodajAutora_Click);
            // 
            // buttonDodajKnjigu
            // 
            this.buttonDodajKnjigu.BackColor = System.Drawing.Color.Sienna;
            this.buttonDodajKnjigu.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajKnjigu.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDodajKnjigu.Location = new System.Drawing.Point(107, 74);
            this.buttonDodajKnjigu.Name = "buttonDodajKnjigu";
            this.buttonDodajKnjigu.Size = new System.Drawing.Size(142, 43);
            this.buttonDodajKnjigu.TabIndex = 0;
            this.buttonDodajKnjigu.Text = "Dodaj knjigu";
            this.buttonDodajKnjigu.UseVisualStyleBackColor = false;
            this.buttonDodajKnjigu.Click += new System.EventHandler(this.buttonDodajKnjigu_Click);
            // 
            // panelKnjige
            // 
            this.panelKnjige.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelKnjige.Controls.Add(this.textBoxOpisK);
            this.panelKnjige.Controls.Add(this.buttonBackK);
            this.panelKnjige.Controls.Add(this.dataGridView1);
            this.panelKnjige.Location = new System.Drawing.Point(0, 0);
            this.panelKnjige.Name = "panelKnjige";
            this.panelKnjige.Size = new System.Drawing.Size(761, 497);
            this.panelKnjige.TabIndex = 4;
            this.panelKnjige.Visible = false;
            // 
            // textBoxOpisK
            // 
            this.textBoxOpisK.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxOpisK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOpisK.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxOpisK.ForeColor = System.Drawing.Color.Sienna;
            this.textBoxOpisK.Location = new System.Drawing.Point(63, 272);
            this.textBoxOpisK.Multiline = true;
            this.textBoxOpisK.Name = "textBoxOpisK";
            this.textBoxOpisK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOpisK.Size = new System.Drawing.Size(305, 134);
            this.textBoxOpisK.TabIndex = 2;
            this.textBoxOpisK.Visible = false;
            // 
            // buttonBackK
            // 
            this.buttonBackK.BackColor = System.Drawing.Color.Sienna;
            this.buttonBackK.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonBackK.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBackK.Location = new System.Drawing.Point(63, 427);
            this.buttonBackK.Name = "buttonBackK";
            this.buttonBackK.Size = new System.Drawing.Size(92, 38);
            this.buttonBackK.TabIndex = 1;
            this.buttonBackK.Text = "Nazad";
            this.buttonBackK.UseVisualStyleBackColor = false;
            this.buttonBackK.Click += new System.EventHandler(this.buttonBackK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = " ";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBanner.BackgroundImage = global::NapredneBaze.Properties.Resources.background3;
            this.pictureBoxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBanner.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(529, 152);
            this.pictureBoxBanner.TabIndex = 0;
            this.pictureBoxBanner.TabStop = false;
            // 
            // buttonKnjige
            // 
            this.buttonKnjige.BackColor = System.Drawing.Color.Sienna;
            this.buttonKnjige.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKnjige.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonKnjige.Location = new System.Drawing.Point(572, 87);
            this.buttonKnjige.Name = "buttonKnjige";
            this.buttonKnjige.Size = new System.Drawing.Size(163, 60);
            this.buttonKnjige.TabIndex = 2;
            this.buttonKnjige.Text = "Knjige";
            this.buttonKnjige.UseVisualStyleBackColor = false;
            this.buttonKnjige.Click += new System.EventHandler(this.buttonKnjige_Click);
            // 
            // buttonAutori
            // 
            this.buttonAutori.BackColor = System.Drawing.Color.Sienna;
            this.buttonAutori.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonAutori.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAutori.Location = new System.Drawing.Point(572, 192);
            this.buttonAutori.Name = "buttonAutori";
            this.buttonAutori.Size = new System.Drawing.Size(163, 60);
            this.buttonAutori.TabIndex = 3;
            this.buttonAutori.Text = "Autori";
            this.buttonAutori.UseVisualStyleBackColor = false;
            this.buttonAutori.Click += new System.EventHandler(this.buttonAutori_Click);
            // 
            // buttonNazadKor
            // 
            this.buttonNazadKor.BackColor = System.Drawing.Color.Sienna;
            this.buttonNazadKor.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNazadKor.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonNazadKor.Location = new System.Drawing.Point(572, 410);
            this.buttonNazadKor.Name = "buttonNazadKor";
            this.buttonNazadKor.Size = new System.Drawing.Size(163, 36);
            this.buttonNazadKor.TabIndex = 4;
            this.buttonNazadKor.Text = "Odjavi se";
            this.buttonNazadKor.UseVisualStyleBackColor = false;
            this.buttonNazadKor.Click += new System.EventHandler(this.buttonNazadKor_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Sienna;
            this.labelWelcome.Location = new System.Drawing.Point(154, 192);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(234, 57);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Dobrodošli!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NapredneBaze.Properties.Resources.stepski_vuk_v;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(17, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 169);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::NapredneBaze.Properties.Resources.delfi_igraj_igraj_igraj_haruki_murakami;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(382, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 169);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::NapredneBaze.Properties.Resources._1984_v;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(198, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 169);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelWelcome);
            this.panel1.Controls.Add(this.buttonNazadKor);
            this.panel1.Controls.Add(this.buttonAutori);
            this.panel1.Controls.Add(this.buttonKnjige);
            this.panel1.Controls.Add(this.pictureBoxBanner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 497);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // buttonBrisiAutora
            // 
            this.buttonBrisiAutora.BackColor = System.Drawing.Color.Sienna;
            this.buttonBrisiAutora.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBrisiAutora.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBrisiAutora.Location = new System.Drawing.Point(495, 272);
            this.buttonBrisiAutora.Name = "buttonBrisiAutora";
            this.buttonBrisiAutora.Size = new System.Drawing.Size(142, 43);
            this.buttonBrisiAutora.TabIndex = 14;
            this.buttonBrisiAutora.Text = "Briši autora";
            this.buttonBrisiAutora.UseVisualStyleBackColor = false;
            this.buttonBrisiAutora.Click += new System.EventHandler(this.buttonBrisiAutora_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NapredneBaze.Properties.Resources.bck4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 497);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelAutor);
            this.Controls.Add(this.panelKnjige);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Knjižara";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panelAutor.ResumeLayout(false);
            this.panelAutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutor)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.panelKnjige.ResumeLayout(false);
            this.panelKnjige.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panelAutor;
        private System.Windows.Forms.ComboBox comboBoxAutori;
        private System.Windows.Forms.Label labelPrezimeSelected;
        private System.Windows.Forms.Label labelImeSelected;
        private System.Windows.Forms.Label labelBiografijaA;
        private System.Windows.Forms.Label labelImeA;
        private System.Windows.Forms.Label labelPrezimeA;
        private System.Windows.Forms.TextBox textBoxBiografijaSelected;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button buttonBackA;
        private System.Windows.Forms.Button buttonDodajAutora;
        private System.Windows.Forms.Button buttonDodajKnjigu;
        private System.Windows.Forms.PictureBox pictureBoxAutor;
        private System.Windows.Forms.Button buttonNazadA;
        private System.Windows.Forms.Panel panelKnjige;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBackK;
        private System.Windows.Forms.TextBox textBoxOpisK;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.Button buttonKnjige;
        private System.Windows.Forms.Button buttonAutori;
        private System.Windows.Forms.Button buttonNazadKor;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonIzmijeniKnjigu;
        private System.Windows.Forms.Button buttonBrisiKnjigu;
        private System.Windows.Forms.Button buttonIzmijeniAutora;
        private System.Windows.Forms.Button buttonBrisiAutora;
    }
}

