namespace mariadb
{
    partial class FrmMdi
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
            menuStrip = new MenuStrip();
            administratorToolStripMenuItem = new ToolStripMenuItem();
            korisnikToolStripMenuItem = new ToolStripMenuItem();
            izvjestajiToolStripMenuItem = new ToolStripMenuItem();
            tsImePrezime = new ToolStripStatusLabel();
            stPrikazi = new StatusStrip();
            tsIdKorisnika = new ToolStripStatusLabel();
            gorivaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            stPrikazi.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { administratorToolStripMenuItem, korisnikToolStripMenuItem, izvjestajiToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(737, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // administratorToolStripMenuItem
            // 
            administratorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gorivaToolStripMenuItem });
            administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            administratorToolStripMenuItem.Size = new Size(92, 20);
            administratorToolStripMenuItem.Text = "Administrator";
            // 
            // korisnikToolStripMenuItem
            // 
            korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            korisnikToolStripMenuItem.Size = new Size(61, 20);
            korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // izvjestajiToolStripMenuItem
            // 
            izvjestajiToolStripMenuItem.Name = "izvjestajiToolStripMenuItem";
            izvjestajiToolStripMenuItem.Size = new Size(63, 20);
            izvjestajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // tsImePrezime
            // 
            tsImePrezime.Name = "tsImePrezime";
            tsImePrezime.Size = new Size(79, 17);
            tsImePrezime.Text = "Neprijavljen!!!";
            // 
            // stPrikazi
            // 
            stPrikazi.Items.AddRange(new ToolStripItem[] { tsImePrezime, tsIdKorisnika });
            stPrikazi.Location = new Point(0, 501);
            stPrikazi.Name = "stPrikazi";
            stPrikazi.Padding = new Padding(1, 0, 16, 0);
            stPrikazi.Size = new Size(737, 22);
            stPrikazi.TabIndex = 2;
            stPrikazi.Text = "StatusStrip";
            // 
            // tsIdKorisnika
            // 
            tsIdKorisnika.Name = "tsIdKorisnika";
            tsIdKorisnika.Size = new Size(0, 17);
            tsIdKorisnika.Visible = false;
            // 
            // gorivaToolStripMenuItem
            // 
            gorivaToolStripMenuItem.Name = "gorivaToolStripMenuItem";
            gorivaToolStripMenuItem.Size = new Size(180, 22);
            gorivaToolStripMenuItem.Text = "Goriva";
            gorivaToolStripMenuItem.Click += gorivaToolStripMenuItem_Click;
            // 
            // FrmMdi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 523);
            Controls.Add(stPrikazi);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmMdi";
            Text = "MDIGlavnaForma";
            Load += MDIGlavnaForma_Load;
            Shown += FrmMdi_Shown;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            stPrikazi.ResumeLayout(false);
            stPrikazi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private ToolStripMenuItem administratorToolStripMenuItem;
        private ToolStripMenuItem korisnikToolStripMenuItem;
        private ToolStripMenuItem izvjestajiToolStripMenuItem;
        private ToolStripStatusLabel tsImePrezime;
        private StatusStrip stPrikazi;
        private ToolStripStatusLabel tsIdKorisnika;
        private ToolStripMenuItem gorivaToolStripMenuItem;
    }
}



