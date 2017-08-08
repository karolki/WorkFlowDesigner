using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkFlowDesigner
{
    public class ListElement
    {
        
        public virtual int Id_list_element { get; set; }
        public virtual string Name { get; set; }
        public virtual Attribute Id_attribute { get; set; }
    }
}