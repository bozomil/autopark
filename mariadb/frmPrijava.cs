using System;
using System.Linq;
using System.Windows.Forms;
using mariadb.Data;
using mariadb.Entities;
using mariadb.Helpers;

namespace mariadb
{
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string korisnik = txtKorisnickoIme.Text.Trim();
            string lozinka = txtLozinka.Text;

            // 1) Provjera unosa
            if (string.IsNullOrEmpty(korisnik) || string.IsNullOrEmpty(lozinka))
            {
                MessageBox.Show("Unesite korisničko ime i lozinku.",
                                "Nedostajući podaci",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var ctx = new AutoparkDbContext())
                {
                    // 2) Traženje korisnika
                    var k = ctx.Korisnici
                               .FirstOrDefault(x => x.KorisnickoIme == korisnik && x.Lozinka == lozinka);

                    if (k == null)
                    {
                        // 3a) Ne postoji takav par korisnik/lozinka
                        MessageBox.Show("Pogrešno korisničko ime ili lozinka.",
                                        "Neuspješna prijava",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    else if (!k.JeAdmin)
                    {
                        // 3b) Postoji, ali nije admin
                        MessageBox.Show("Nemate administratorske privilegije.",
                                        "Ograničen pristup",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                        var mdiParent = this.MdiParent as FrmMdi;
                        if (mdiParent != null)
                        {
                            mdiParent.AdministrarorMenuItem.Enabled = false;
                            mdiParent.IzvjestajiMenuItem.Enabled = true;
                            mdiParent.KorisnikMenuItem.Enabled = true;
                            mdiParent.StatusLabel.Text = "Prijavljeni korisnik: " + k.ImePrezime;
                            mdiParent.StatusLabel2.Text = "" + k.IdKorisnika;

                        }

                        this.Hide();
                    }
                    else
                    {
                        // 3c) Uspješna prijava za admina
                        MessageBox.Show("Administratorske privilegije.",
                                        "Potpuni pristup",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        var mdiParent = this.MdiParent as FrmMdi;
                        if (mdiParent != null)
                        {
                            mdiParent.AdministrarorMenuItem.Enabled = true;
                            mdiParent.IzvjestajiMenuItem.Enabled = true;
                            mdiParent.KorisnikMenuItem.Enabled = true;
                            mdiParent.StatusLabel.Text = "Administrator: " + k.ImePrezime;
                            mdiParent.StatusLabel2.Text = "" + k.IdKorisnika;

                            var servis = new ProvjeriStanjeVozilaHelper();
                            servis.Provjeri();

                        }
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                // 4) Greška u pristupu bazi
                MessageBox.Show("Pogreška pri pristupu bazi:\n" + ex.Message,
                                "Greška",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
