using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class MailSenders
    {
        public MailSenders()
        {
            MailTemplates = new HashSet<MailTemplates>();
        }

        public int MailSenderId { get; set; }
        public string MailSenderDisplayName { get; set; }

        public ICollection<MailTemplates> MailTemplates { get; set; }
    }
}
