using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
     public class ListElement
    {
        private int id_list_element;
        private String name;
        private Attribute id_attribute;

        [DisplayName(@"Id_list_element")]
        public virtual int Id_list_element { get => id_list_element; set => id_list_element = value; }
        [DisplayName(@"Name")]
        public virtual string Name { get => name; set => name = value; }
        [DisplayName(@"Id_attribute")]
        public virtual Attribute Id_attribute { get => id_attribute; set => id_attribute = value; }
    }
}
