using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class HrUsersMapping
    {
        public int Id { get; set; }
        public int HruserId { get; set; }
        public int UserId { get; set; }

        public Users User { get; set; }
    }
}
