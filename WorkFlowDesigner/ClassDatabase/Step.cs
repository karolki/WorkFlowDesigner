using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkFlowDesigner
{
    public class Step
    {
        public Step() { }
        public Step(Position start, Position end, string desc, string condition)
        {
            Start_position_id = start;
            End_position_id = end;
            Description = desc;
            Condition = condition;
        }
        public virtual int Id_step { get; set; }
        public virtual Position Start_position_id { get; set; }
        public virtual Position End_position_id { get; set; }
        public virtual string Description { get; set; }
        public virtual string Condition { get; set; }
        
    }
}