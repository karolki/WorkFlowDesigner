using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
    class Step
    {
        private int id_step;
        private int start_position_id;
        private int end_position_id;
        private String description;

        public Step(int id_step, int start_position_id, int end_position_id, string description)
        {
            this.id_step = id_step;
            this.start_position_id = start_position_id;
            this.end_position_id = end_position_id;
            this.description = description;
        }

        public Step()
        {
            this.id_step = 0;
            this.start_position_id = 0;
            this.end_position_id = 0;
            this.description = "";
        }

        public int Id_step { get => id_step; set => id_step = value; }
        public int Start_position_id { get => start_position_id; set => start_position_id = value; }
        public int End_position_id { get => end_position_id; set => end_position_id = value; }
        public string Description { get => description; set => description = value; }

    }
}
