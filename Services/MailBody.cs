using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tantawan_DotnetCoreMVC.Models;

namespace Tantawan_DotnetCoreMVC.Services
{
    public class MailBody : IMailBody
    {
        private readonly Contact _contact;
        private readonly Career _career;
        public MailBody(Contact contact, Career career)
        {
            _contact = contact;
            _career = career;

        }
        public String CreateContactBody (Contact contact)
        {
            
            return "Contact";
        }
        public String CreateCareerBody (Career career)
        {
            return "career";
        }
    }
}