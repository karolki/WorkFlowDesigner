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
        private Flow id_workflow;
        private String name;
        private String type;
        private int read_property;
        private int optional_change;
        private int required_change;
        private IList<ListElement> list;


        [DisplayName(@"Id_attribute")]
        public virtual int Id_attribute { get => id_attribute; set => id_attribute = value; }
        [DisplayName(@"Id_workflow")]
        public virtual Flow Id_workflow { get => id_workflow; set => id_workflow = value; }
        [DisplayName(@"Name")]
        public virtual string Name { get => name; set => name = value; }
        [DisplayName(@"Type")]
        public virtual string Type { get => type; set => type = value; }
        [DisplayName(@"Read_property")]
        public virtual int Read_property { get => read_property; set => read_property = value; }
        [DisplayName(@"Optional_change")]
        public virtual int Optional_change { get => optional_change; set => optional_change = value; }
        [DisplayName(@"Required_change")]
        public virtual int Required_change { get => required_change; set => required_change = value; }
        [DisplayName(@"Element_list")]
        public virtual IList<ListElement> List { get => list; set => list = value; }
    }
}
