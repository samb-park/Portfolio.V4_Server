using System;
using System.Net;
using System.Net.Mail;
using Business.Repository.IRepository;
using Models;

namespace Business.Repository
{
    public class EmailRepository :IEmailRepository
    {
        public void SendMail(EmailDTO email)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("sangbong.bak@gmail.com");
                    mail.To.Add("goorooru@gmail.com");
                    mail.Subject = $"[Message - {DateTime.Today.ToString("yy-MM-dd")}] From {email.Message}";
                    mail.Body = $"EMAIL : {email.Email}\n" +
                                $"PHONE : {email.PhoneNumber}\n" +
                                $"MESSAGE : {email.Email}\n" +
                                $"DATE : {DateTime.Today.ToString("yy-MM-dd")}";

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com",587))
                    {
                        smtp.Credentials = new NetworkCredential("sangbong.bak@gmail.com","!1Qqkrtkdqhd");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}