using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class MailSubjects
    {
        public int SubjectId { get; set; }
        public string SubjectText { get; set; }
        public int LanguageId { get; set; }
        public int? MailId { get; set; }

        public Languages Language { get; set; }
        public MailTemplates Mail { get; set; }
    }
}
