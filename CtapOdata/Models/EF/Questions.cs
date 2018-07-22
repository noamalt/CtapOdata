using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Questions
    {
        public int QuestionId { get; set; }
        public string ShortText { get; set; }
        public string Body { get; set; }
        public bool? IsActive { get; set; }

        public Answers Answers { get; set; }
    }
}
