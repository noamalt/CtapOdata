using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class DesksTokens
    {
        public int Id { get; set; }
        public int DeskId { get; set; }
        public string DeskToken { get; set; }

        public Desks Desk { get; set; }
    }
}
