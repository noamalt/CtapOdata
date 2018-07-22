using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class HealthCheckUsers
    {
        public int Id { get; set; }
        public string Healthcheckuser { get; set; }
        public DateTime? Dateentered { get; set; }
    }
}
