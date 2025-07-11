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

        // polje u formu za praćenje originalne registracije
        private string originalnaRegistracija = ""; // ili private string? originalnaRegistracija = null;

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
            cbDostupan.Checked = false;
            btnSave.Text = "Spremi";
            btnDelete.Enabled = false;
            ent.Registracija = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ProvjeriUnos())
                return;

            string novaRegistracija = txtRegistracija.Text.Trim();

            if (string.IsNullOrWhiteSpace(novaRegistracija))
            {
                MessageBox.Show("Registracija automobila je obavezna za spremanje.", "Unos Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime datumRegistracije = dtpDatumRegistracije.Value.Date;

            using var ctx = new AutoparkDbContext();

            if (!string.IsNullOrEmpty(originalnaRegistracija))
            {
                // Update postojeći auto
                Entities.Automobil? auto = ctx.Automobili.FirstOrDefault(a => a.Registracija == originalnaRegistracija);

                if (auto == null)
                {
                    MessageBox.Show("Originalni automobil nije pronađen za ažuriranje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Provjeri da nova registracija ne postoji kod drugog auta
                if (novaRegistracija != originalnaRegistracija &&
                    ctx.Automobili.Any(a => a.Registracija == novaRegistracija))
                {
                    MessageBox.Show("Unesena nova registracija već postoji u bazi.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ažuriranje podataka
                auto.Registracija = novaRegistracija;
                auto.IdProizvodjac = int.TryParse(txtIdProizvodjac.Text, out int idProizvodjac) ? idProizvodjac : 0;
                auto.IdGoriva = int.TryParse(txtIdGoriva.Text, out int idGoriva) ? idGoriva : 0;
                auto.DatumRegistracije = datumRegistracije;
                auto.Model = txtModel.Text.Trim();
                auto.GodinaProizvodnje = dtpGodinaProizvodnje.Value.Year;
                auto.ccm = !string.IsNullOrWhiteSpace(txtCcm.Text) ? short.Parse(txtCcm.Text.Trim()) : (short?)null;
                auto.kW = !string.IsNullOrWhiteSpace(txtKw.Text) ? short.Parse(txtKw.Text.Trim()) : (short?)null;
                auto.Potrosnja = !string.IsNullOrWhiteSpace(txtPotrosnja.Text) ? decimal.Parse(txtPotrosnja.Text.Trim()) : (decimal?)null;
                auto.Dostupan = cbDostupan.Checked;
                auto.KilometriNaRegistraciji = decimal.TryParse(txtKilometriNaRegistraciji.Text.Trim(), out decimal km) ? km : 0;

                try
                {
                    ctx.SaveChanges();
                    MessageBox.Show("Automobil je uspješno ažuriran.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadAutomobili();
                    originalnaRegistracija = null; // Resetiraj nakon update-a
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška pri ažuriranju: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Insert novi auto

                if (ctx.Automobili.Any(a => a.Registracija == novaRegistracija))
                {
                    MessageBox.Show("Automobil s ovom registracijom već postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var noviAuto = new Entities.Automobil
                {
                    Registracija = novaRegistracija,
                    IdProizvodjac = int.TryParse(txtIdProizvodjac.Text, out int idProizvodjac) ? idProizvodjac : 0,
                    IdGoriva = int.TryParse(txtIdGoriva.Text, out int idGoriva) ? idGoriva : 0,
                    DatumRegistracije = datumRegistracije,
                    Model = txtModel.Text.Trim(),
                    GodinaProizvodnje = dtpGodinaProizvodnje.Value.Year,
                    ccm = !string.IsNullOrWhiteSpace(txtCcm.Text) ? short.Parse(txtCcm.Text.Trim()) : (short?)null,
                    kW = !string.IsNullOrWhiteSpace(txtKw.Text) ? short.Parse(txtKw.Text.Trim()) : (short?)null,
                    Potrosnja = !string.IsNullOrWhiteSpace(txtPotrosnja.Text) ? decimal.Parse(txtPotrosnja.Text.Trim()) : (decimal?)null,
                    Dostupan = cbDostupan.Checked,
                    KilometriNaRegistraciji = decimal.TryParse(txtKilometriNaRegistraciji.Text.Trim(), out decimal km) ? km : 0
                };

                ctx.Automobili.Add(noviAuto);

                try
                {
                    ctx.SaveChanges();
                    MessageBox.Show("Automobil je uspješno spremljen.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadAutomobili();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Došlo je do greške prilikom spremanja automobila: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            //if (dgvAutomobili.CurrentRow?.Index == -1) return;

            if (dgvAutomobili.CurrentRow == null || dgvAutomobili.CurrentRow.Index < 0)
                return;

            var registracija = dgvAutomobili.CurrentRow.Cells["dgRegistracija"].Value.ToString();

            using var ctx = new AutoparkDbContext();
            var auto = ctx.Automobili.FirstOrDefault(a => a.Registracija == registracija);

            if (auto != null)
            {
                txtRegistracija.Text = auto.Registracija;
                txtIdProizvodjac.Text = auto.IdProizvodjac.ToString();
                txtIdGoriva.Text = auto.IdGoriva.ToString();
                dtpDatumRegistracije.Value = auto.DatumRegistracije;
                txtModel.Text = auto.Model;
                //dtpGodinaProizvodnje.Value = new DateTime(auto.GodinaProizvodnje, 1, 1);
                txtCcm.Text = auto.ccm?.ToString() ?? "";
                txtKw.Text = auto.kW?.ToString() ?? "";
                txtPotrosnja.Text = auto.Potrosnja != 0 ? auto.Potrosnja.ToString() : "";
                txtKilometriNaRegistraciji.Text = auto.KilometriNaRegistraciji != 0 ? auto.KilometriNaRegistraciji.ToString() : "";
                cbDostupan.Checked = auto.Dostupan;

                originalnaRegistracija = auto.Registracija; // <- zapamti original jer po ovom PK radiš update

                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }
    }
}
