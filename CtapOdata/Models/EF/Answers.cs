using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Answers
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string Body { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDefault { get; set; }

        public Questions Question { get; set; }
    }
}
