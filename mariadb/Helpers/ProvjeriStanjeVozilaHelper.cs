using mariadb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mariadb.Helpers
{
    public class ProvjeriStanjeVozilaHelper
    {
        public void Provjeri()
        {
            using (var db = new AutoparkDbContext())
            {
                var sviAutomobili = db.Automobili.ToList();

                foreach (var auto in sviAutomobili)
                {
                    // --- Provjera za servis ---
                    if (auto.KilometriNaRegistraciji >= 20000)
                    {
                        var servisRezultat = MessageBox.Show(
                            $"Obavezan servis\nAutomobil s registracijom {auto.Registracija} mora na servis.",
                            "Servis vozila",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (servisRezultat == DialogResult.Yes)
                        {
                            auto.KilometriNaRegistraciji = 0;
                            db.SaveChanges();
                            MessageBox.Show($"Automobil {auto.Registracija} je servisiran.", "Uspjeh");
                        }
                        else
                        {
                            MessageBox.Show("Odgođen servis.", "Info");
                        }
                    }

                    // --- Provjera za registraciju ---
                    var danaOdRegistracije = (DateTime.Now - auto.DatumRegistracije).TotalDays;

                    if (danaOdRegistracije > 360)
                    {
                        var regRezultat = MessageBox.Show(
                            $"Podsjetnik za registraciju\nAutomobil s registracijom {auto.Registracija} mora se ponovo registrirati.",
                            "Registracija vozila",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                        if (regRezultat == DialogResult.Yes)
                        {
                            auto.KilometriNaRegistraciji = 0;
                            auto.DatumRegistracije = DateTime.Now;
                            db.SaveChanges();
                            MessageBox.Show($"Registracija vozila {auto.Registracija} je ažurirana.", "Uspjeh");
                        }
                        else
                        {
                            MessageBox.Show("Odgođena registracija.", "Info");
                        }
                    }
                }
            }
        }
    }
}
