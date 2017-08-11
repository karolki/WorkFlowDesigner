using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace WorkFlowDesigner
{
    public  class User
    {
       
        
        public virtual int Id_user { get; set; }
        public virtual string Surname { get; set; }
       
        public virtual string Name { get; set; }
        public virtual string Permission { get; set; }
        public virtual string Email { get; set; }
        
        public virtual string Password { get; set; }        
        public virtual Position Id_position { get; set; }
        public virtual IList<Flow> FlowList { get; set; }
    }
}