using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkFlowDesigner.ClassDatabase;

namespace WorkFlowDesigner
{
    public class Attributes
    {
        public Attributes()
        {
            Parent = null;
        }
        public virtual int Id_attribute { get; set; }
        public virtual FlowDefinition Id_workflow { get; set; }
        public virtual string Name { get; set; }
        public virtual string Type { get; set; }
        public virtual IList<ListElement> List { get ; set; }       
        public virtual Attributes Parent { get; set; }
        public virtual IList<FlowExtension> FlowExtensionList { get; set; }
        public virtual IList<Access> AccessList { get; set; }
        public virtual Source DataSource { get; set; }
    }
}