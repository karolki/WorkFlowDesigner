using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkFlowDesigner
{
    public class StepCondition
    {
        public StepCondition() { }
        public StepCondition(string condition)
        { 
            Condition = condition;
        }
        public virtual int Id_stepcondition { get; set; }
        public virtual Step Id_step { get; set; }
        public virtual string Condition { get; set; }
    }
}