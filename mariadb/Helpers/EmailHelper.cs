using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace mariadb.Helpers
{
    public static class EmailHelper
    {
        public static bool SendMail(string to, string subject, string body, out string errorMessage)
        {
            errorMessage = "";

            try
            {
                // Čitanje podataka iz app.config
                string? smtpServer = ConfigurationManager.AppSettings["SmtpServer"];
                string? smtpPortStr = ConfigurationManager.AppSettings["SmtpPort"];
                string? fromEmail = ConfigurationManager.AppSettings["FromEmail"];
                string? appPassword = ConfigurationManager.AppSettings["AppPassword"];
                string? fromName = ConfigurationManager.AppSettings["FromName"];

                // Validacija osnovne konfiguracije
                if (string.IsNullOrWhiteSpace(smtpServer) ||
                    string.IsNullOrWhiteSpace(smtpPortStr) ||
                    string.IsNullOrWhiteSpace(fromEmail) ||
                    string.IsNullOrWhiteSpace(appPassword))
                {
                    errorMessage = "SMTP konfiguracija nije ispravno postavljena u app.config.";
                    return false;
                }

                if (!int.TryParse(smtpPortStr, out int smtpPort))
                {
                    errorMessage = "SMTP port u app.config nije ispravan broj.";
                    return false;
                }

                var smtpClient = new SmtpClient
                {
                    Host = smtpServer,
                    Port = smtpPort,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(fromEmail, appPassword)
                };

                var fromAddress = new MailAddress(fromEmail, fromName ?? fromEmail);

                var mail = new MailMessage
                {
                    From = fromAddress,
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };

                mail.To.Add(to);

                smtpClient.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = $"Greška pri slanju e-pošte: {ex.Message}";
                return false;
            }
        }
    }
}
