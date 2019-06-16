namespace NapredneBaze
{
    partial class DodajAutora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajAutora));
            this.buttonDodajDA = new System.Windows.Forms.Button();
            this.textBoxPrezimeDA = new System.Windows.Forms.TextBox();
            this.textBoxBiografijaDA = new System.Windows.Forms.TextBox();
            this.textBoxImeDA = new System.Windows.Forms.TextBox();
            this.labelPrezimeDA = new System.Windows.Forms.Label();
            this.labelBiografijaDA = new System.Windows.Forms.Label();
            this.labelImeDA = new System.Windows.Forms.Label();
            this.buttonDodajFotografiju = new System.Windows.Forms.Button();
            this.openFileDialogPicture = new System.Windows.Forms.OpenFileDialog();
            this.buttonIzmijeniDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodajDA
            // 
            this.buttonDodajDA.BackColor = System.Drawing.Color.Sienna;
            this.buttonDodajDA.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonDodajDA.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDodajDA.Location = new System.Drawing.Point(563, 151);
            this.buttonDodajDA.Name = "buttonDodajDA";
            this.buttonDodajDA.Size = new System.Drawing.Size(152, 43);
            this.buttonDodajDA.TabIndex = 21;
            this.buttonDodajDA.Text = "Dodaj autora";
            this.buttonDodajDA.UseVisualStyleBackColor = false;
            this.buttonDodajDA.Click += new System.EventHandler(this.buttonDodajDA_Click);
            // 
            // textBoxPrezimeDA
            // 
            this.textBoxPrezimeDA.Location = new System.Drawing.Point(212, 95);
            this.textBoxPrezimeDA.Name = "textBoxPrezimeDA";
            this.textBoxPrezimeDA.Size = new System.Drawing.Size(155, 20);
            this.textBoxPrezimeDA.TabIndex = 18;
            // 
            // textBoxBiografijaDA
            // 
            this.textBoxBiografijaDA.Location = new System.Drawing.Point(212, 151);
            this.textBoxBiografijaDA.Multiline = true;
            this.textBoxBiografijaDA.Name = "textBoxBiografijaDA";
            this.textBoxBiografijaDA.Size = new System.Drawing.Size(216, 166);
            this.textBoxBiografijaDA.TabIndex = 19;
            // 
            // textBoxImeDA
            // 
            this.textBoxImeDA.Location = new System.Drawing.Point(212, 41);
            this.textBoxImeDA.Name = "textBoxImeDA";
            this.textBoxImeDA.Size = new System.Drawing.Size(155, 20);
            this.textBoxImeDA.TabIndex = 17;
            // 
            // labelPrezimeDA
            // 
            this.labelPrezimeDA.AutoSize = true;
            this.labelPrezimeDA.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelPrezimeDA.ForeColor = System.Drawing.Color.Sienna;
            this.labelPrezimeDA.Location = new System.Drawing.Point(108, 95);
            this.labelPrezimeDA.Name = "labelPrezimeDA";
            this.labelPrezimeDA.Size = new System.Drawing.Size(68, 18);
            this.labelPrezimeDA.TabIndex = 16;
            this.labelPrezimeDA.Text = "Prezime:";
            // 
            // labelBiografijaDA
            // 
            this.labelBiografijaDA.AutoSize = true;
            this.labelBiografijaDA.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelBiografijaDA.ForeColor = System.Drawing.Color.Sienna;
            this.labelBiografijaDA.Location = new System.Drawing.Point(108, 161);
            this.labelBiografijaDA.Name = "labelBiografijaDA";
            this.labelBiografijaDA.Size = new System.Drawing.Size(80, 18);
            this.labelBiografijaDA.TabIndex = 14;
            this.labelBiografijaDA.Text = "Biografija:";
            // 
            // labelImeDA
            // 
            this.labelImeDA.AutoSize = true;
            this.labelImeDA.BackColor = System.Drawing.Color.Transparent;
            this.labelImeDA.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImeDA.ForeColor = System.Drawing.Color.Sienna;
            this.labelImeDA.Location = new System.Drawing.Point(108, 41);
            this.labelImeDA.Name = "labelImeDA";
            this.labelImeDA.Size = new System.Drawing.Size(38, 18);
            this.labelImeDA.TabIndex = 13;
            this.labelImeDA.Text = "Ime:";
            // 
            // buttonDodajFotografiju
            // 
            this.buttonDodajFotografiju.BackColor = System.Drawing.Color.Sienna;
            this.buttonDodajFotografiju.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonDodajFotografiju.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDodajFotografiju.Location = new System.Drawing.Point(212, 373);
            this.buttonDodajFotografiju.Name = "buttonDodajFotografiju";
            this.buttonDodajFotografiju.Size = new System.Drawing.Size(155, 35);
            this.buttonDodajFotografiju.TabIndex = 20;
            this.buttonDodajFotografiju.Text = "Dodaj fotografiju";
            this.buttonDodajFotografiju.UseVisualStyleBackColor = false;
            this.buttonDodajFotografiju.Click += new System.EventHandler(this.buttonDodajFotografiju_Click_1);
            // 
            // openFileDialogPicture
            // 
            this.openFileDialogPicture.FileName = "openFileDialog1";
            // 
            // buttonIzmijeniDA
            // 
            this.buttonIzmijeniDA.BackColor = System.Drawing.Color.Sienna;
            this.buttonIzmijeniDA.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonIzmijeniDA.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonIzmijeniDA.Location = new System.Drawing.Point(563, 152);
            this.buttonIzmijeniDA.Name = "buttonIzmijeniDA";
            this.buttonIzmijeniDA.Size = new System.Drawing.Size(152, 41);
            this.buttonIzmijeniDA.TabIndex = 23;
            this.buttonIzmijeniDA.Text = "Izmijeni podatke";
            this.buttonIzmijeniDA.UseVisualStyleBackColor = false;
            this.buttonIzmijeniDA.Click += new System.EventHandler(this.buttonIzmijeniDA_Click);
            // 
            // DodajAutora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIzmijeniDA);
            this.Controls.Add(this.buttonDodajFotografiju);
            this.Controls.Add(this.buttonDodajDA);
            this.Controls.Add(this.textBoxPrezimeDA);
            this.Controls.Add(this.textBoxBiografijaDA);
            this.Controls.Add(this.textBoxImeDA);
            this.Controls.Add(this.labelPrezimeDA);
            this.Controls.Add(this.labelBiografijaDA);
            this.Controls.Add(this.labelImeDA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajAutora";
            this.Text = "Dodaj/Izmijeni autora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDodajDA;
        private System.Windows.Forms.TextBox textBoxPrezimeDA;
        private System.Windows.Forms.TextBox textBoxBiografijaDA;
        private System.Windows.Forms.TextBox textBoxImeDA;
        private System.Windows.Forms.Label labelPrezimeDA;
        private System.Windows.Forms.Label labelBiografijaDA;
        private System.Windows.Forms.Label labelImeDA;
        private System.Windows.Forms.Button buttonDodajFotografiju;
        private System.Windows.Forms.OpenFileDialog openFileDialogPicture;
        private System.Windows.Forms.Button buttonIzmijeniDA;
    }
}