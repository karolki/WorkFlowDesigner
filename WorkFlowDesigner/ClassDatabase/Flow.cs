using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkFlowDesigner
{
    public class Flow
    {
        public virtual int Flow_id { get; set; }
        public virtual string Flow_name { get; set; }
        public virtual string Flow_description { get; set; }
        public virtual IList<Attribute> AtributeList { get; set; }
        public virtual IList<Position> PositionList { get ; set; }
        public virtual IList<Document> DocumentList { get; set; }
    }
}