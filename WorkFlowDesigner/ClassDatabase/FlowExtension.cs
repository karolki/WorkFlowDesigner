using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkFlowDesigner
{
    public class FlowExtension
    {
        public virtual int id_flowextension { get; set; }
        public virtual string Value { get; set; }
        public virtual Flow id_flow { get; set; }
        public virtual Attributes id_attribute { get; set; }
        public virtual IList<Document> documentList { get; set; }
    }
}