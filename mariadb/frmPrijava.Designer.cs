namespace mariadb
{
    partial class FrmPrijava
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
            label1 = new Label();
            label2 = new Label();
            txtKorisnickoIme = new TextBox();
            txtLozinka = new TextBox();
            label3 = new Label();
            BtnLogin = new Button();
            BtnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 121);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Lozinka";
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Location = new Point(155, 71);
            txtKorisnickoIme.Margin = new Padding(4);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(116, 23);
            txtKorisnickoIme.TabIndex = 2;
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(155, 121);
            txtLozinka.Margin = new Padding(4);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(116, 23);
            txtLozinka.TabIndex = 3;
            txtLozinka.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 10);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 22);
            label3.TabIndex = 5;
            label3.Text = "Dobrodošli!";
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(31, 173);
            BtnLogin.Margin = new Padding(4);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(88, 26);
            BtnLogin.TabIndex = 7;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(155, 173);
            BtnExit.Margin = new Padding(4);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(88, 26);
            BtnExit.TabIndex = 8;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // FrmPrijava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(328, 236);
            Controls.Add(BtnExit);
            Controls.Add(BtnLogin);
            Controls.Add(label3);
            Controls.Add(txtLozinka);
            Controls.Add(txtKorisnickoIme);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmPrijava";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prijava";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnExit;
    }
}

