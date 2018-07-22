using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class CompliancesInLeads
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int LeadId { get; set; }
        public int DocumentTypeId { get; set; }
        public string FileName { get; set; }
        public int? FileSize { get; set; }
        public string FileExtension { get; set; }
        public Guid? FileGuid { get; set; }
        public int? ComplianceStatusId { get; set; }
        public int? ComplianceRejectionId { get; set; }
        public DateTime? ComplianceCreationDate { get; set; }
        public DateTime? ComplianceModificationDate { get; set; }
    }
}
