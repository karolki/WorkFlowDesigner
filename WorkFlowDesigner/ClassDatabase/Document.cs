using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;


namespace WorkFlowDesigner
{
    public class Document
    {

        public virtual int Id_document { get; set; }        
        public virtual string Name { get; set; }
        public virtual Flow Id_flow { get; set; }
        public virtual User Id_user { get; set; }
    }
}