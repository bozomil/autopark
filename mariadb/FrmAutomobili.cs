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
    public partial class FrmAutomobili : Form
    {
        private Automobil ent = new Automobil();

        // Ova svojstva omogućuju pristup entitetu iz drugih formi
        public void SetProizvodjacId(short id)
        {
            txtIdProizvodjac.Text = id.ToString();
        }

        public void SetGorivoId(short idGoriva)
        {
            txtIdGoriva.Text = idGoriva.ToString();
        }

        // Konstruktor
        public FrmAutomobili()
        {
            InitializeComponent();
        }

        private void FrmAutomobili_Load(object sender, EventArgs e)
        {
            ClearForm();
            btnUpdate.Visible = false;
            LoadAutomobili();
        }

        // Ova metoda učitava automobile iz baze i prikazuje ih u DataGridView
        void LoadAutomobili()
        {
            dgvAutomobili.AutoGenerateColumns = false; // Onemogućava automatsko generiranje kolona
            using var ctx = new AutoparkDbContext();
            dgvAutomobili.DataSource = ctx.Automobili.ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        void ClearForm()
        {
            txtRegistracija.Text = txtIdProizvodjac.Text = txtIdGoriva.Text = txtKilometriNaRegistraciji.Text = txtModel.Text = txtCcm.Text = txtKw.Text = txtPotrosnja.Text = "";
            cbDostupan.Checked = false;
            btnSave.Visible = true; // Prikaži gumb za spremanje
            btnUpdate.Visible = false; // Sakrij gumb za ažuriranje
            btnDelete.Enabled = false;
            ent.Registracija = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgvAutomobili_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAutomobili.CurrentRow?.Index == -1) return;

            ent.Registracija = dgvAutomobili.CurrentRow.Cells["dgRegistracija"].Value.ToString();

            string reg = dgvAutomobili.CurrentRow.Cells["dgRegistracija"].Value.ToString();
            using var db = new AutoparkDbContext();
            ent = db.Automobili.Find(reg);

            if (ent != null)
            {
                txtRegistracija.Text = ent.Registracija;
                txtIdProizvodjac.Text = ent.IdProizvodjac.ToString();
                txtIdGoriva.Text = ent.IdGoriva.ToString();
                dtpDatumRegistracije.Value = ent.DatumRegistracije;
                txtModel.Text = ent.Model;
                dtpGodinaProizvodnje.Value = new DateTime(ent.GodinaProizvodnje, 1, 1);
                txtCcm.Text = ent.ccm?.ToString() ?? "";
                txtKw.Text = ent.kW?.ToString() ?? "";
                txtPotrosnja.Text = ent.Potrosnja != 0 ? ent.Potrosnja.ToString() : "";
                txtKilometriNaRegistraciji.Text = ent.KilometriNaRegistraciji != 0 ? ent.KilometriNaRegistraciji.ToString() : "";
                cbDostupan.Checked = ent.Dostupan;

                btnSave.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
