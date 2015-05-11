using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace CommonUtils
{
    /// <summary>
    /// Communication Util
    /// </summary>
    public static class CommunicationUtil
    {
        /// <summary>
        /// Send Email
        /// </summary>
        /// <param name="emailToSend">email To Send</param>
        /// <param name="subject">subject</param>
        /// <param name="attachment">attachment</param>
        /// <param name="html">html</param>
        /// <returns></returns>
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

        /// <summary>
        /// Send Email
        /// </summary>
        /// <param name="emailToSend">email To Send</param>
        /// <param name="subject">subject</param>
        /// <param name="html">html</param>
        /// <returns></returns>
        public static void SendEmail(string emailToSend, string subject, AlternateView html)
        {
            var mm = new MailMessage();
            mm.To.Add(emailToSend);
            mm.From = new MailAddress("idiposable@gmail.com");
            mm.CC.Add("nathan.zwelibanzi.khupe@mcast.edu.mt");
            mm.Subject = subject;
            mm.AlternateViews.Add(html);
            mm.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("idiposable@gmail.com", "z0aQ&$xS!w1")
            };

            try
            {
                client.Send(mm);
            }
            catch (Exception)
            {
                throw new Exception("Error sending email");
            }
        }
    }
}