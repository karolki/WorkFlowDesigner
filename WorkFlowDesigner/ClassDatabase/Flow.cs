using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkFlowDesigner
{
    public class Flow
    {
        public virtual int id_flow { get; set; }
        
        public virtual string Name { get; set; }
        public virtual User id_user { get; set; }
        
        public virtual FlowDefinition id_flowdefinition{ get; set; }

        public virtual IList<FlowExtension> FlowExtensionList { get; set; }
        public virtual Position id_position { get; set; }



    }
}