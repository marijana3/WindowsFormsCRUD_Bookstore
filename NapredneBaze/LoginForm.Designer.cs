namespace NapredneBaze
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelUsernameLI = new System.Windows.Forms.Label();
            this.labelPasswordLI = new System.Windows.Forms.Label();
            this.textBoxUsernameLI = new System.Windows.Forms.TextBox();
            this.textBoxPasswordLI = new System.Windows.Forms.TextBox();
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.buttonLI = new System.Windows.Forms.Button();
            this.panelLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsernameLI
            // 
            this.labelUsernameLI.AutoSize = true;
            this.labelUsernameLI.BackColor = System.Drawing.Color.Transparent;
            this.labelUsernameLI.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUsernameLI.ForeColor = System.Drawing.Color.Sienna;
            this.labelUsernameLI.Location = new System.Drawing.Point(121, 51);
            this.labelUsernameLI.Name = "labelUsernameLI";
            this.labelUsernameLI.Size = new System.Drawing.Size(97, 17);
            this.labelUsernameLI.TabIndex = 0;
            this.labelUsernameLI.Text = "Korisničko ime:";
            // 
            // labelPasswordLI
            // 
            this.labelPasswordLI.AutoSize = true;
            this.labelPasswordLI.BackColor = System.Drawing.Color.Transparent;
            this.labelPasswordLI.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordLI.ForeColor = System.Drawing.Color.Sienna;
            this.labelPasswordLI.Location = new System.Drawing.Point(131, 87);
            this.labelPasswordLI.Name = "labelPasswordLI";
            this.labelPasswordLI.Size = new System.Drawing.Size(58, 17);
            this.labelPasswordLI.TabIndex = 1;
            this.labelPasswordLI.Text = "Lozinka:";
            // 
            // textBoxUsernameLI
            // 
            this.textBoxUsernameLI.Location = new System.Drawing.Point(224, 48);
            this.textBoxUsernameLI.Name = "textBoxUsernameLI";
            this.textBoxUsernameLI.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsernameLI.TabIndex = 2;
            // 
            // textBoxPasswordLI
            // 
            this.textBoxPasswordLI.Location = new System.Drawing.Point(224, 87);
            this.textBoxPasswordLI.Name = "textBoxPasswordLI";
            this.textBoxPasswordLI.Size = new System.Drawing.Size(100, 20);
            this.textBoxPasswordLI.TabIndex = 3;
            this.textBoxPasswordLI.UseSystemPasswordChar = true;
            // 
            // panelLogIn
            // 
            this.panelLogIn.BackgroundImage = global::NapredneBaze.Properties.Resources.login2;
            this.panelLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogIn.Controls.Add(this.buttonLI);
            this.panelLogIn.Controls.Add(this.textBoxPasswordLI);
            this.panelLogIn.Controls.Add(this.textBoxUsernameLI);
            this.panelLogIn.Controls.Add(this.labelPasswordLI);
            this.panelLogIn.Controls.Add(this.labelUsernameLI);
            this.panelLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogIn.Location = new System.Drawing.Point(0, 0);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(475, 238);
            this.panelLogIn.TabIndex = 4;
            // 
            // buttonLI
            // 
            this.buttonLI.BackColor = System.Drawing.Color.Sienna;
            this.buttonLI.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLI.Location = new System.Drawing.Point(177, 151);
            this.buttonLI.Name = "buttonLI";
            this.buttonLI.Size = new System.Drawing.Size(107, 32);
            this.buttonLI.TabIndex = 4;
            this.buttonLI.Text = "Uloguj se!";
            this.buttonLI.UseVisualStyleBackColor = false;
            this.buttonLI.Click += new System.EventHandler(this.buttonLI_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 238);
            this.Controls.Add(this.panelLogIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUsernameLI;
        private System.Windows.Forms.Label labelPasswordLI;
        private System.Windows.Forms.TextBox textBoxUsernameLI;
        private System.Windows.Forms.TextBox textBoxPasswordLI;
        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Button buttonLI;
    }
}