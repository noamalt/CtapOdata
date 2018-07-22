using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class MailServersInformation
    {
        public MailServersInformation()
        {
            Offices = new HashSet<Offices>();
        }

        public int MailServerId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string HostAddress { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsSsl { get; set; }
        public int Timeout { get; set; }

        public ICollection<Offices> Offices { get; set; }
    }
}
