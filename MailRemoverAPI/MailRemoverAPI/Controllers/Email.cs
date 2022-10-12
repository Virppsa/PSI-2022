using System;
using System.IO;

namespace MailRemoverAPI.Controllers;


    class Email
    {
        public Email(string emailAddress, string dateOfEmail)
        {
            this.emailAddress = emailAddress;
            this.dateOfEmail = dateOfEmail;
        }

        public string emailAddress { get; set; }
        public string dateOfEmail { get; set; }

    }