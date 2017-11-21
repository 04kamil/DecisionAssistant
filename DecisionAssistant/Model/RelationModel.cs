using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionAssistant.Model
{
    public class RelationModel
    {
        public CriterionModel First { get; set; }
        public CriterionModel Second { get; set; }
        public double Value { get; set; }
    }
}
