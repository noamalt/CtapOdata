using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class AccountTokens
    {
        public Guid AccountTokenId { get; set; }
        public int AccountId { get; set; }
        public DateTime DateEntered { get; set; }
        public int AccountTokenTypeId { get; set; }

        public Accounts Account { get; set; }
        public AccountTokenTypes AccountTokenType { get; set; }
    }
}
