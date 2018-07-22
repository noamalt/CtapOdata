using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class LiveKashCards
    {
        public string LiveKashCard { get; set; }
        public string LiveKashCvv { get; set; }
        public string LiveKashExpiration { get; set; }
        public int AccountId { get; set; }
        public string DateOfBirth { get; set; }

        public Accounts Account { get; set; }
    }
}
