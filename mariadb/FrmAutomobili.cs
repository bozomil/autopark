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
            dtpDatumRegistracije.Value = DateTime.Today;
            int godina = DateTime.Today.Year;
            dtpGodinaProizvodnje.Value = new DateTime(godina, 1, 1);
            cbDostupan.Checked = false;
            btnSave.Text = "Spremi";
            btnDelete.Enabled = false;
            ent = new Automobil();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Ažuriranje podataka
            ent.Registracija = txtRegistracija.Text.Trim();
            ent.IdProizvodjac = int.TryParse(txtIdProizvodjac.Text, out int idProizvodjac) ? idProizvodjac : 0;
            ent.IdGoriva = int.TryParse(txtIdGoriva.Text, out int idGoriva) ? idGoriva : 0;
            ent.DatumRegistracije = dtpDatumRegistracije.Value.Date;
            ent.Model = txtModel.Text.Trim();
            ent.GodinaProizvodnje = dtpGodinaProizvodnje.Value.Year;
            ent.ccm = !string.IsNullOrWhiteSpace(txtCcm.Text) ? short.Parse(txtCcm.Text.Trim()) : (short?)null;
            ent.kW = !string.IsNullOrWhiteSpace(txtKw.Text) ? short.Parse(txtKw.Text.Trim()) : (short?)null;
            ent.Potrosnja = !string.IsNullOrWhiteSpace(txtPotrosnja.Text) ? decimal.Parse(txtPotrosnja.Text.Trim()) : (decimal?)null;
            ent.Dostupan = cbDostupan.Checked;
            ent.KilometriNaRegistraciji = decimal.TryParse(txtKilometriNaRegistraciji.Text.Trim(), out decimal km) ? km : 0;

            if (!ProvjeriUnos())
                return;

            using var ctx = new AutoparkDbContext();

            if (ent.IdAutomobila == 0)
                ctx.Automobili.Add(ent);
            else
                ctx.Automobili.Update(ent);

            ctx.SaveChanges();

            ClearForm();
            LoadAutomobili();

            MessageBox.Show("Automobil je uspješno spremljen.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

         }
     
        


        private bool ProvjeriUnos()
        {
            if (string.IsNullOrWhiteSpace(txtRegistracija.Text))
            {
                MessageBox.Show("Registracija automobila je obavezna.", "Unos Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Model automobila je obavezan.", "Unos Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtIdProizvodjac.Text, out _))
            {
                MessageBox.Show("IdProizvodjac mora biti ispravan broj.", "Unos Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtIdGoriva.Text, out _))
            {
                MessageBox.Show("IdGoriva mora biti ispravan broj.", "Unos Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtCcm.Text) && !short.TryParse(txtCcm.Text, out _))
            {
                MessageBox.Show("CCM mmora biti ispravan broj.", "Unos Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtKw.Text) && !short.TryParse(txtKw.Text, out _))
            {
                MessageBox.Show("kW mora biti ispravan broj.", "Unos Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtPotrosnja.Text) && !decimal.TryParse(txtPotrosnja.Text, out _))
            {
                MessageBox.Show("Potrosnja mora biti ispravan broj.", "Unos Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtKilometriNaRegistraciji.Text) && !decimal.TryParse(txtKilometriNaRegistraciji.Text, out _))
            {
                MessageBox.Show("Kilometri na registraciji mora biti ispravan decimalni number.", "Unos Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgvAutomobili_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAutomobili.CurrentRow == null || dgvAutomobili.CurrentRow.Index < 0)
                return;

            var id = (short)Convert.ToInt32(dgvAutomobili.CurrentRow.Cells["dgIdAutomobila"].Value);

            using var ctx = new AutoparkDbContext();
            var automobil = ctx.Automobili.FirstOrDefault(x => x.IdAutomobila == id);

            if (automobil != null)
            {
                //DateTime datumRegistracije = dtpDatumRegistracije.Value.Date;
                //string formatted = datumRegistracije.ToString("yyyy-MM-dd");

                ent = automobil;
                txtRegistracija.Text = ent.Registracija;
                txtIdProizvodjac.Text = ent.IdProizvodjac.ToString();   
                txtIdGoriva.Text = ent.IdGoriva.ToString();
                dtpDatumRegistracije.Value = ent.DatumRegistracije;
                txtModel.Text = ent.Model;
                dtpGodinaProizvodnje.Value = new DateTime(ent.GodinaProizvodnje, 1, 1);
                txtCcm.Text = ent.ccm?.ToString();
                txtKw.Text = ent.kW?.ToString();
                txtPotrosnja.Text = ent.Potrosnja?.ToString();
                cbDostupan.Checked = ent.Dostupan;
                txtKilometriNaRegistraciji.Text = ent.KilometriNaRegistraciji.ToString();

                btnSave.Text = "Ažuriraj";
                btnDelete.Enabled = true;
            }
        }
    }
   
}
