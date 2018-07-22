using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LeadDocuments
    {
        public int LeadDocumentId { get; set; }
        public string Name { get; set; }
        public int LeadDocumentTypeId { get; set; }
        public int LeadId { get; set; }
        public long FileSize { get; set; }
        public string FileExtension { get; set; }
        public string FileName { get; set; }

        public Leads Lead { get; set; }
        public LeadDocumentTypes LeadDocumentType { get; set; }
    }
}
