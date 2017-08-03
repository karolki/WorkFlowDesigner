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
        private List<Position> positionList = new List<Position>();

        [DisplayName(@"Flow_id")]
        public int Flow_id { get => flow_id; set => flow_id = value; }
        [DisplayName(@"Flow_description")]
        public string Flow_description { get => flow_description; set => flow_description = value; }
        [DisplayName(@"Flow_name")]
        public string Flow_name { get => flow_name; set => flow_name = value; }
        public List<Attribute> AtributeList { get => attributeList; set => attributeList = value; }
        public List<Position> PositionList { get => positionList; set => positionList = value; }
    }
}