using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FIT5032_Week08A.Utils
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "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";

        public void Send(String toEmail, String subject, String contents, String file)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("1578763540@qq.com", "FIT5032 Example Email User");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            
            msg.AddAttachment("confirm.docx", file);
            var response = client.SendEmailAsync(msg);
        }

    }
}