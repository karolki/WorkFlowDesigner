using System;
using System.Collections.Generic;
using System.ComponentModel;
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


        [DisplayName(@"Id_attribute")]
        public int Id_attribute { get => id_attribute; set => id_attribute = value; }
        [DisplayName(@"Id_workflow")]
        public int Id_workflow { get => id_workflow; set => id_workflow = value; }
        [DisplayName(@"Name")]
        public string Name { get => name; set => name = value; }
        [DisplayName(@"Type")]
        public string Type { get => type; set => type = value; }
        [DisplayName(@"Read_property")]
        public int Read_property { get => read_property; set => read_property = value; }
        [DisplayName(@"Optional_change")]
        public int Optional_change { get => optional_change; set => optional_change = value; }
        [DisplayName(@"Required_change")]
        public int Required_change { get => required_change; set => required_change = value; }
        [DisplayName(@"Id_list_element")]
        public int Id_list_element { get => id_list_element; set => id_list_element = value; }

       

    }
}
