using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
    class StepCondition
    {
        private int id_stepcondition;
        private int id_step;
        private String condition;


        [DisplayName(@"Id_stepcondition")]
        public int Id_stepcondition { get => id_stepcondition; set => id_stepcondition = value; }
        [DisplayName(@"Id_step")]
        public int Id_step { get => id_step; set => id_step = value; }
        [DisplayName(@"Condition")]
        public string Condition { get => condition; set => condition = value; }


    }
}
