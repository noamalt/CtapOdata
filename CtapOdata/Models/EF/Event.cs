using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Eventstart { get; set; }
        public DateTime Eventend { get; set; }
        public string Resource { get; set; }
        public int UserId { get; set; }
    }
}
