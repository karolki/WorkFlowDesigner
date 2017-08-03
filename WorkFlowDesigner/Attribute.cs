using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
    public class Attribute
    {
        private int id_attribute;
        private int id_workflow;
        private String name;
        private String type;
        private int read_property;
        private int optional_change;
        private int required_change;
        private int id_list_element;

        public Attribute(int id_attribute, int id_workflow, string name, string type, int read_property, int optional_change, int required_change, int id_list_element)
        {
            this.id_attribute = id_attribute;
            this.id_workflow = id_workflow;
            this.name = name;
            this.type = type;
            this.read_property = read_property;
            this.optional_change = optional_change;
            this.required_change = required_change;
            this.id_list_element = id_list_element;
        }

        public Attribute()
        {
            this.id_attribute = 0;
            this.id_workflow = 0;
            this.name = "";
            this.type = "";
            this.read_property =0;
            this.optional_change = 0;
            this.required_change = 0;
            this.id_list_element = 0;
        }

        public int Id_attribute { get => id_attribute; set => id_attribute = value; }
        public int Id_workflow { get => id_workflow; set => id_workflow = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Read_property { get => read_property; set => read_property = value; }
        public int Optional_change { get => optional_change; set => optional_change = value; }
        public int Required_change { get => required_change; set => required_change = value; }
        public int Id_list_element { get => id_list_element; set => id_list_element = value; }

       

    }
}
