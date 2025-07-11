using mariadb.Data;
using mariadb.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mariadb
{
    public partial class FrmGoriva : Form
    {
        private Gorivo ent = new Gorivo();

        public FrmGoriva()
        {
            InitializeComponent();
        }

        private void FrmGoriva_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadGoriva();
        }

        private void LoadGoriva()
        {
            dgvGoriva.AutoGenerateColumns = false;

            using var ctx = new AutoparkDbContext();
            dgvGoriva.DataSource = ctx.Goriva.ToList();
        }

        private void ClearForm()
        {
            txtNazivGoriva.Clear();
            txtCijenaGoriva.Clear();
            btnSave.Text = "Spremi";
            btnDelete.Enabled = false;
            ent = new Gorivo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ent.NazivGoriva = txtNazivGoriva.Text.Trim();

            if (!decimal.TryParse(txtCijenaGoriva.Text.Trim(), out decimal cijena))
            {
                MessageBox.Show("Unesite ispravnu cijenu goriva.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ent.CijenaGoriva = cijena;

            using var ctx = new AutoparkDbContext();

            if (ent.IdGoriva == 0)
                ctx.Goriva.Add(ent);
            else
                ctx.Goriva.Update(ent);

            ctx.SaveChanges();

            ClearForm();
            LoadGoriva();

            MessageBox.Show("Gorivo je uspješno spremljeno.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ent.IdGoriva == 0)
                return;

            var potvrda = MessageBox.Show("Jeste li sigurni da želite obrisati ovo gorivo?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (potvrda != DialogResult.Yes) return;

            using var ctx = new AutoparkDbContext();
            ctx.Goriva.Remove(ent);
            ctx.SaveChanges();

            ClearForm();
            LoadGoriva();

            MessageBox.Show("Gorivo je uspješno obrisano.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvGoriva_DoubleClick(object sender, EventArgs e)
        {
            if (dgvGoriva.CurrentRow == null || dgvGoriva.CurrentRow.Index < 0)
                return;

            var id = (short)Convert.ToInt32(dgvGoriva.CurrentRow.Cells["dgIdGoriva"].Value);

            using var ctx = new AutoparkDbContext();
            var gorivo = ctx.Goriva.FirstOrDefault(x => x.IdGoriva == id);

            if (gorivo != null)
            {
                ent = gorivo;
                txtNazivGoriva.Text = ent.NazivGoriva;
                txtCijenaGoriva.Text = ent.CijenaGoriva.ToString();
                btnSave.Text = "Ažuriraj";
                btnDelete.Enabled = true;
            }
        }

        private void dohvatiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvGoriva.CurrentRow == null)
                return;

            var id = (short)dgvGoriva.CurrentRow.Cells["dgIdGoriva"].Value;

            using var ctx = new AutoparkDbContext();
            var gorivo = ctx.Goriva.FirstOrDefault(g => g.IdGoriva == id);

            if (gorivo == null)
                return;

            var frmAuto = MdiParent?.MdiChildren.OfType<FrmAutomobili>().FirstOrDefault();
            if (frmAuto != null)
            {
                frmAuto.SetGorivoId((short)gorivo.IdGoriva);
                this.Close();
            }
            else
            {

                if (dgvGoriva.ContextMenuStrip != null)
                {
                    var item = dgvGoriva.ContextMenuStrip.Items["dohvatiToolStripMenuItem"] as ToolStripMenuItem;
                    if (item != null)
                    {
                        item.Visible = false;
                    }
                }
            }
        }
    }
}
