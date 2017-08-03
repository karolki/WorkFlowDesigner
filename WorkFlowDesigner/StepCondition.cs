using System;
using System.Collections.Generic;
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

        public StepCondition(int id_stepcondition, int id_step, string condition)
        {
            this.id_stepcondition = id_stepcondition;
            this.id_step = id_step;
            this.condition = condition;
        }

        public StepCondition()
        {
            this.id_stepcondition = 0;
            this.id_step = 0;
            this.condition = "";
        }

        public int Id_stepcondition { get => id_stepcondition; set => id_stepcondition = value; }
        public int Id_step { get => id_step; set => id_step = value; }
        public string Condition { get => condition; set => condition = value; }


    }
}
