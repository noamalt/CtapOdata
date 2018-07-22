using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class SmsBodyInStatusAndLabguage
    {
        public int? SmsTemplateId { get; set; }
        public int? LanguageId { get; set; }
        public int? StatusId { get; set; }
        public int SmsBodyInStatusAndLabguageId { get; set; }

        public Languages Language { get; set; }
        public SmsTemplates SmsTemplate { get; set; }
        public LeadStatuses Status { get; set; }
    }
}
