using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkFlowDesigner
{
    
    public class Access
    {
        public virtual int Id_access { get; set; }
        public virtual Position Id_position { get; set; }
        public virtual Attribute Id_attribute { get; set; }
        public virtual int Read_property { get; set; }
        public virtual int Optional_change { get; set; }
        public virtual int Required_change { get; set; }
    }
}