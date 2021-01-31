using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EbeveynKontrol.WinFormUI.Tools
{
    public static class MailTool
    {
        public static bool Send(string mail, string mailContent)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("ebeveyntakip@hotmail.com");
            //
            ePosta.To.Add(mail);
            //
            ePosta.Subject = "Bilgisayarınızdan yasaklı siteye giriş yapıldı.";
            //
            ePosta.Body = mailContent + " sitesine giriş yapıldı. Zaman :"+DateTime.Now;
            //
            SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
            smtp.UseDefaultCredentials = false;
            //
            smtp.Credentials = new System.Net.NetworkCredential("example@hotmail.com", "Şifreniz");

            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.Send(ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;
        }


    }
}
