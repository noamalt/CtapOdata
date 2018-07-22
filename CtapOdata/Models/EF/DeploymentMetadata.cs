using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class DeploymentMetadata
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Action { get; set; }
        public string By { get; set; }
        public string As { get; set; }
        public DateTime CompletedDate { get; set; }
        public string With { get; set; }
        public string BlockId { get; set; }
        public byte[] InsertedSerial { get; set; }
        public byte[] UpdatedSerial { get; set; }
        public string MetadataVersion { get; set; }
        public string Hash { get; set; }
    }
}
