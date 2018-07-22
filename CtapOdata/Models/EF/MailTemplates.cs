using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class MailTemplates
    {
        public MailTemplates()
        {
            MailSubjects = new HashSet<MailSubjects>();
        }

        public int MailId { get; set; }
        public string MailName { get; set; }
        public string MailFileName { get; set; }
        public string MailFriendlyName { get; set; }
        public int? MailSenderId { get; set; }
        public bool? IsNewsLetter { get; set; }
        public bool? IsActive { get; set; }

        public MailSenders MailSender { get; set; }
        public ICollection<MailSubjects> MailSubjects { get; set; }
    }
}
