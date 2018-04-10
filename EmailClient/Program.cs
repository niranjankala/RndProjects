using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailClient
{
    class Program
    {
        static void Main(string[] args)
        {

            using (SmtpClient client = new SmtpClient())
            using (MailMessage message = new MailMessage())
            {
                Properties.Settings.Default.ToEmail.Split(',').ToList().ForEach(emailAddress =>
                {
                    message.To.Add(emailAddress);
                });

                message.IsBodyHtml = Properties.Settings.Default.IsBodyHtml;
                message.Subject = Properties.Settings.Default.MessageSubject;
                message.Body = Properties.Settings.Default.MessageBodyText;

                try
                {
                    // send the email
                    client.Send(message);
                }
                catch (SmtpException ex)
                {
                    // log exception
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
