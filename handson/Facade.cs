using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.design.facade
{
    using System;

    // Subsystem 1: SMTPServer
    class SMTPServer
    {
        public void Connect()
        {
            Console.WriteLine("Connected to SMTP server");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected from SMTP server");
        }

        public void SendEmail(string from, string to, string subject, string body)
        {
            Console.WriteLine($"Sent email from {from} to {to} with subject: {subject}");
        }
    }

    // Subsystem 2: EmailValidator
    class EmailValidator
    {
        public bool IsValidEmail(string email)
        {
            // Simulate email validation logic
            return email.Contains("@") && email.Contains(".");
        }
    }

    // Facade
    class EmailFacade
    {
        private EmailValidator validator;
        private SMTPServer smtpServer;

        public EmailFacade()
        {
            validator = new EmailValidator();
            smtpServer = new SMTPServer();
        }

        public void SendEmail(string from, string to, string subject, string body)
        {
            if (validator.IsValidEmail(from) && validator.IsValidEmail(to))
            {
                smtpServer.Connect();
                smtpServer.SendEmail(from, to, subject, body);
                smtpServer.Disconnect();
            }
            else
            {
                Console.WriteLine("Invalid email addresses. Email not sent.");
            }
        }
    }
}