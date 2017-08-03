using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
    class Position
    {
        private int id_position;
        private int id_flow;
        private String name;

        public int Id_position { get => id_position; set => id_position = value; }
        public int Id_flow { get => id_flow; set => id_flow = value; }
        public string Name { get => name; set => name = value; }

        public Position(int id_position, int id_flow, string name)
        {
            this.id_position = id_position;
            this.id_flow = id_flow;
            this.name = name;
        }

        public Position()
        {
            this.id_position = 0;
            this.id_flow = 0;
            this.name = "";
        }




    }
}
