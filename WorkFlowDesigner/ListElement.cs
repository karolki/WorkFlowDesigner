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

        [DisplayName(@"Id_list_element")]
        public int Id_list_element { get => id_list_element; set => id_list_element = value; }
        [DisplayName(@"Name")]
        public string Name { get => name; set => name = value; }
    }
}
