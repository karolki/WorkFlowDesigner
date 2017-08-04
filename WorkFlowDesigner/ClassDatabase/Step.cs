using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
    public class Step
    {
        private int id_step;
        private Position start_position_id;
        private Position end_position_id;
        private String description;
        private IList<Step> stepconditionlist = new List<Step>();


        [DisplayName(@"Id_step")]
        public virtual int Id_step { get => id_step; set => id_step = value; }
        [DisplayName(@"Start_position_id")]
        public virtual Position Start_position_id { get => start_position_id; set => start_position_id = value; }
        [DisplayName(@"End_position_id")]
        public virtual Position End_position_id { get => end_position_id; set => end_position_id = value; }
        [DisplayName(@"Description")]
        public virtual string Description { get => description; set => description = value; }
        public virtual IList<Step> StepConditionList { get => stepconditionlist; set => stepconditionlist = value; }

    }
}
