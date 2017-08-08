using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkFlowDesigner
{
    public class Step
    {
        public Step() { }
        public Step(Position start_pos,Position end_pos,string description)
        {
            Start_position_id = start_pos;
            End_position_id = end_pos;
            Description = description;
            StepConditionList = new List<StepCondition>();
        }
        public virtual int Id_step { get; set; }
        public virtual Position Start_position_id { get; set; }
        public virtual Position End_position_id { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<StepCondition> StepConditionList { get ; set ; }
    }
}