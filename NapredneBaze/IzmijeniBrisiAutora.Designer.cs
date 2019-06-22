namespace NapredneBaze
{
    partial class IzmijeniBrisiAutora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmijeniBrisiAutora));
            this.dataGridViewAutori = new System.Windows.Forms.DataGridView();
            this.buttonIzmijeniAutora = new System.Windows.Forms.Button();
            this.buttonBrisiAutora = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutori)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAutori
            // 
            this.dataGridViewAutori.AllowUserToAddRows = false;
            this.dataGridViewAutori.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewAutori.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAutori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutori.Location = new System.Drawing.Point(79, 28);
            this.dataGridViewAutori.Name = "dataGridViewAutori";
            this.dataGridViewAutori.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = " ";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutori.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAutori.RowHeadersWidth = 100;
            this.dataGridViewAutori.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewAutori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAutori.Size = new System.Drawing.Size(302, 219);
            this.dataGridViewAutori.TabIndex = 2;
            // 
            // buttonIzmijeniAutora
            // 
            this.buttonIzmijeniAutora.BackColor = System.Drawing.Color.Sienna;
            this.buttonIzmijeniAutora.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonIzmijeniAutora.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonIzmijeniAutora.Location = new System.Drawing.Point(79, 310);
            this.buttonIzmijeniAutora.Name = "buttonIzmijeniAutora";
            this.buttonIzmijeniAutora.Size = new System.Drawing.Size(149, 44);
            this.buttonIzmijeniAutora.TabIndex = 15;
            this.buttonIzmijeniAutora.Text = "Izmijeni podatke";
            this.buttonIzmijeniAutora.UseVisualStyleBackColor = false;
            this.buttonIzmijeniAutora.Click += new System.EventHandler(this.buttonIzmijeniAutora_Click);
            // 
            // buttonBrisiAutora
            // 
            this.buttonBrisiAutora.BackColor = System.Drawing.Color.Sienna;
            this.buttonBrisiAutora.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonBrisiAutora.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBrisiAutora.Location = new System.Drawing.Point(79, 394);
            this.buttonBrisiAutora.Name = "buttonBrisiAutora";
            this.buttonBrisiAutora.Size = new System.Drawing.Size(149, 44);
            this.buttonBrisiAutora.TabIndex = 16;
            this.buttonBrisiAutora.Text = "Briši autora";
            this.buttonBrisiAutora.UseVisualStyleBackColor = false;
            this.buttonBrisiAutora.Click += new System.EventHandler(this.buttonBrisiAutora_Click);
            // 
            // IzmijeniBrisiAutora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.buttonBrisiAutora);
            this.Controls.Add(this.buttonIzmijeniAutora);
            this.Controls.Add(this.dataGridViewAutori);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzmijeniBrisiAutora";
            this.Text = "Izmijeni/briši autora";
            this.Load += new System.EventHandler(this.IzmijeniBrisiAutora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAutori;
        private System.Windows.Forms.Button buttonIzmijeniAutora;
        private System.Windows.Forms.Button buttonBrisiAutora;
    }
}