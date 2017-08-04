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


        [DisplayName(@"Id_step")]
        public int Id_step { get => id_step; set => id_step = value; }
        [DisplayName(@"Start_position_id")]
        public Position Start_position_id { get => start_position_id; set => start_position_id = value; }
        [DisplayName(@"End_position_id")]
        public Position End_position_id { get => end_position_id; set => end_position_id = value; }
        [DisplayName(@"Description")]
        public string Description { get => description; set => description = value; }

    }
}
