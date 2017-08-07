using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
   public  class Access
    {
        private int id_access;
        private Position id_position;
        private Attribute id_attribute;
        private int read_property;
        private int optional_change;
        private int required_change;

        [DisplayName(@"Id_attribute")]
        public virtual int Id_access { get => id_access; set => id_access = value; }
        [DisplayName(@"Read_property")]
        public virtual int Read_property { get => read_property; set => read_property = value; }
        [DisplayName(@"Optional_change")]
        public virtual int Optional_change { get => optional_change; set => optional_change = value; }
        [DisplayName(@"Required_change")]
        public virtual int Required_change { get => required_change; set => required_change = value; }
        [DisplayName(@"Position_id")]
        public virtual Position Id_position { get => id_position; set => id_position = value; }
        [DisplayName(@"Position_id")]
        public virtual Attribute Id_attribute { get => id_attribute; set => id_attribute = value; }
    }
}
