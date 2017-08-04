using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{ 

   public class Document
    {
        private int id_document;
        private string name;
        private string type;

        public virtual int Id_document { get => id_document; set => id_document = value; }
        public virtual string Name { get => name; set => name = value; }
        public virtual string Type { get => type; set => type = value; }
    }
    
}
