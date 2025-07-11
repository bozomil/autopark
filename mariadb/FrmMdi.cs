using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mariadb.Entities;

namespace mariadb
{
    public partial class FrmMdi : Form
    {
        public FrmMdi()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }


        private void MDIGlavnaForma_Load(object sender, EventArgs e)
        {
            administratorToolStripMenuItem.Enabled = false;
            korisnikToolStripMenuItem.Enabled = false;
            izvjestajiToolStripMenuItem.Enabled = false;
        }

        private void FrmMdi_Shown(object sender, EventArgs e)
        {
            // Provjerite da ne otvarate više puta
            if (!this.MdiChildren.OfType<FrmPrijava>().Any())
            {
                var prijava = new FrmPrijava();
                prijava.MdiParent = this; // <— child za MDI
                prijava.WindowState = FormWindowState.Normal; // ili Maximized po potrebi
                prijava.Show();
            }
        }

        private void gorivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1) Instanciraj child formu
            var child = new FrmGoriva();

            // 2) Registriraj je kao MDI-child
            child.MdiParent = this;

            // 3) Prikaži je
            child.Show();

        }

        // Add this property to allow external control of the menu item
        public ToolStripMenuItem AdministrarorMenuItem
        {
            get { return administratorToolStripMenuItem; }
        }

        public ToolStripMenuItem IzvjestajiMenuItem
        {
            get { return izvjestajiToolStripMenuItem; }
        }

        public ToolStripMenuItem KorisnikMenuItem
        {
            get { return korisnikToolStripMenuItem; }
        }

        public ToolStripStatusLabel StatusLabel
        {
            get { return tsImePrezime; }
        }

        public ToolStripStatusLabel StatusLabel2
        {
            get { return tsIdKorisnika; }
        }
    }
}
