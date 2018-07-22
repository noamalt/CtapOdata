using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class CashierSettings
    {
        public int Id { get; set; }
        public int OfficeId { get; set; }
        public int CurrencyId { get; set; }
        public int CashierTypeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Sportbook { get; set; }
    }
}
