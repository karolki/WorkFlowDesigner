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
        
        public virtual  byte[] Data { get; set; }
        public virtual string ContentType { get; set; }
        public virtual FlowExtension Id_flowextension { get; set; }

    }
}