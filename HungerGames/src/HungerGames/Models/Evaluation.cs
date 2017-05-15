using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungerGames.Models
{
    public class Evaluation
    {
        public int EvaluationID { get; set; }

        public decimal EvaluationValue { get; set; }

        public string UserID { get; set; }

        public string QuestionID { get; set; }

    }
}
