using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
    public class Position
    {
        private int id_position;
        private Flow id_flow;
        private String name;

        [DisplayName(@"Id_position")]
        public virtual int Id_position { get => id_position; set => id_position = value; }
        [DisplayName(@"Id_flow")]
        public virtual Flow Id_flow { get => id_flow; set => id_flow = value; }
        [DisplayName(@"Name")]
        public virtual string Name { get => name; set => name = value; }

        
   


    }
}
