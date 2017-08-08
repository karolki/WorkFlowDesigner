using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkFlowDesigner
{
    public class Attribute
    {
        
        public virtual int Id_attribute { get; set; }
        public virtual Flow Id_workflow { get; set; }
        public virtual string Name { get; set; }
        public virtual string Type { get; set; }
        public virtual IList<ListElement> List { get ; set; }       
        public virtual IList<Access> Accesslist { get ; set ; }
    }
}