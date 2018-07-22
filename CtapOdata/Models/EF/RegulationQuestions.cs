using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class RegulationQuestions
    {
        public int QuestionId { get; set; }
        public string QuestionString { get; set; }
        public string Key { get; set; }
        public int? LanguageId { get; set; }
    }
}
