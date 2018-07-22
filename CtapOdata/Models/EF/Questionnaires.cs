using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class Questionnaires
    {
        public int Id { get; set; }
        public int QuestionnaireId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public int? Order { get; set; }
    }
}
