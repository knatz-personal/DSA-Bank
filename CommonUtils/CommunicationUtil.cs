using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace CommonUtils
{
    public static class CommunicationUtil
    {
        public static bool SendEmail(IEnumerable<string> emailToSend, string subject, Attachment attachment, AlternateView html)
        {
            bool isSent = false;

            var mm = new MailMessage();
            foreach (var item in emailToSend)
            {
                mm.To.Add(item);
            }
            mm.From = new MailAddress("idiposable@gmail.com");
            mm.CC.Add("nathan.zwelibanzi.khupe@mcast.edu.mt");
            mm.Subject = subject;
            mm.AlternateViews.Add(html);
            mm.IsBodyHtml = true;
            mm.Attachments.Add(attachment);

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("idiposable@gmail.com", "z0aQ&$xS!w1")
            };

            client.Send(mm);
            isSent = true;


            return isSent;
        }
    }
}