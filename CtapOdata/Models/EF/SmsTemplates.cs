using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class SmsTemplates
    {
        public SmsTemplates()
        {
            SmsBodyInStatusAndLabguage = new HashSet<SmsBodyInStatusAndLabguage>();
        }

        public int TemplateId { get; set; }
        public string Body { get; set; }
        public string FriendlyName { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<SmsBodyInStatusAndLabguage> SmsBodyInStatusAndLabguage { get; set; }
    }
}
