using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
    public class StepConditions
    {
        public StepConditions() { }
        public StepConditions(Position pos, string oper, string cond)
        {
            Condition = cond;
            Position = pos;
            Operator = oper;
        }
        public virtual int Id_stepcondition { get; set; }
        public virtual Step Id_step { get; set; }
        public virtual Position Position { get; set; }
        public virtual string Operator { get; set; }
        public virtual string Condition { get; set; }
    }
}
