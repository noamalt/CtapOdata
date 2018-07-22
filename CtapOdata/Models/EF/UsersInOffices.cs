using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class UsersInOffices
    {
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public bool IsManager { get; set; }

        public Offices Office { get; set; }
        public Users User { get; set; }
    }
}
