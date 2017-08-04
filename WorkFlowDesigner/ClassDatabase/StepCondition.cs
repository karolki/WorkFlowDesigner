using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
   public class StepCondition
    {
        private int id_stepcondition;
        private Step id_step;
        private string condition;


        [DisplayName(@"Id_stepcondition")]
        public virtual int Id_stepcondition { get => id_stepcondition; set => id_stepcondition = value; }
        [DisplayName(@"Id_step")]
        public virtual Step Id_step { get => id_step; set => id_step = value; }
        [DisplayName(@"Condition")]
        public virtual  string Condition { get => condition; set => condition = value; }


    }
}
