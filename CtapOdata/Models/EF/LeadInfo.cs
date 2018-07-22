using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadInfo
    {
        public int LeadInfoId { get; set; }
        public int LeadId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? LanguageId { get; set; }
        public int? CountryId { get; set; }

        public Countries Country { get; set; }
        public Languages Language { get; set; }
        public Leads Lead { get; set; }
    }
}
