using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
    public class Attribute
    {
        private int id_attribute;
        private Flow id_workflow;
        private String name;
        private String type;
        private IList<Access> accesslist = new List<Access>();
        private IList<ListElement> list = new List<ListElement>();


        [DisplayName(@"Id_attribute")]
        public virtual int Id_attribute { get => id_attribute; set => id_attribute = value; }
        [DisplayName(@"Id_workflow")]
        public virtual Flow Id_workflow { get => id_workflow; set => id_workflow = value; }
        [DisplayName(@"Name")]
        public virtual string Name { get => name; set => name = value; }
        [DisplayName(@"Type")]
        public virtual string Type { get => type; set => type = value; }
        
        [DisplayName(@"Element_list")]
        public virtual IList<ListElement> List { get => list; set => list = value; }
        [DisplayName(@"Access_list")]
        public IList<Access> Accesslist { get => accesslist; set => accesslist = value; }
    }
}
