namespace NapredneBaze
{
    partial class IzmijeniBrisiKnjigu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmijeniBrisiKnjigu));
            this.dataGridViewKnjige = new System.Windows.Forms.DataGridView();
            this.buttonIzmijeniKnjigu = new System.Windows.Forms.Button();
            this.buttonBrisiKnjigu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKnjige
            // 
            this.dataGridViewKnjige.AllowUserToAddRows = false;
            this.dataGridViewKnjige.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewKnjige.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKnjige.Location = new System.Drawing.Point(73, 24);
            this.dataGridViewKnjige.Name = "dataGridViewKnjige";
            this.dataGridViewKnjige.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = " ";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKnjige.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewKnjige.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewKnjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKnjige.Size = new System.Drawing.Size(643, 219);
            this.dataGridViewKnjige.TabIndex = 1;
            // 
            // buttonIzmijeniKnjigu
            // 
            this.buttonIzmijeniKnjigu.BackColor = System.Drawing.Color.Sienna;
            this.buttonIzmijeniKnjigu.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonIzmijeniKnjigu.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonIzmijeniKnjigu.Location = new System.Drawing.Point(175, 321);
            this.buttonIzmijeniKnjigu.Name = "buttonIzmijeniKnjigu";
            this.buttonIzmijeniKnjigu.Size = new System.Drawing.Size(149, 44);
            this.buttonIzmijeniKnjigu.TabIndex = 14;
            this.buttonIzmijeniKnjigu.Text = "Izmijeni podatke";
            this.buttonIzmijeniKnjigu.UseVisualStyleBackColor = false;
            this.buttonIzmijeniKnjigu.Click += new System.EventHandler(this.buttonIzmijeniKnjigu_Click);
            // 
            // buttonBrisiKnjigu
            // 
            this.buttonBrisiKnjigu.BackColor = System.Drawing.Color.Sienna;
            this.buttonBrisiKnjigu.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonBrisiKnjigu.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBrisiKnjigu.Location = new System.Drawing.Point(448, 321);
            this.buttonBrisiKnjigu.Name = "buttonBrisiKnjigu";
            this.buttonBrisiKnjigu.Size = new System.Drawing.Size(149, 44);
            this.buttonBrisiKnjigu.TabIndex = 15;
            this.buttonBrisiKnjigu.Text = "Briši knjigu";
            this.buttonBrisiKnjigu.UseVisualStyleBackColor = false;
            this.buttonBrisiKnjigu.Click += new System.EventHandler(this.buttonBrisiKnjigu_Click);
            // 
            // IzmijeniBrisiKnjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBrisiKnjigu);
            this.Controls.Add(this.buttonIzmijeniKnjigu);
            this.Controls.Add(this.dataGridViewKnjige);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzmijeniBrisiKnjigu";
            this.Text = "Izmijeni/briši knjigu";
            this.Load += new System.EventHandler(this.IzmijeniBrisiKnjigu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKnjige)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKnjige;
        private System.Windows.Forms.Button buttonIzmijeniKnjigu;
        private System.Windows.Forms.Button buttonBrisiKnjigu;
    }
}