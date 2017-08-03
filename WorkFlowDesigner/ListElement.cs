using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
    class ListElement
    {
        private int id_list_element;
        private String name;

        public ListElement(int id_list_element, string name)
        {
            this.id_list_element = id_list_element;
            this.name = name;
        }

        public ListElement()
        {
            this.id_list_element = 0;
            this.name = "";
        }

        public int Id_list_element { get => id_list_element; set => id_list_element = value; }
        public string Name { get => name; set => name = value; }
    }
}
