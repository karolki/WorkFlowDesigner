using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WorkFlowDesigner
{
    public class Flow
    {
        private int flow_id;
        private string flow_description;
        private string flow_name;
        private List<Attribute> attributeList = new List<Attribute>();
        private IList<Position> positionList = new List<Position>();

        [DisplayName(@"Flow_id")]
        public virtual int Flow_id { get => flow_id; set => flow_id = value; }
        [DisplayName(@"Flow_description")]
        public virtual string Flow_description { get => flow_description; set => flow_description = value; }
        [DisplayName(@"Flow_name")]
        public virtual string Flow_name { get => flow_name; set => flow_name = value; }
        public virtual List<Attribute> AtributeList { get => attributeList; set => attributeList = value; }
        public virtual IList<Position> PositionList { get => positionList; set => positionList = value; }
    }

}