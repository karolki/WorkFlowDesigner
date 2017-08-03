using System;

namespace WorkFlowDesigner
{
    public class Flow
    {
        private int flow_id;
        private string flow_description;
        private string flow_name;

        public Flow(int flow_id, string flow_description, string flow_name)
        {
            this.flow_id = flow_id;
            this.flow_description = flow_description;
            this.flow_name = flow_name;
        }

        public Flow()
        {
            this.flow_id = 0;
            this.flow_description = "";
            this.flow_name = "";
        }

        public int Flow_id { get => flow_id; set => flow_id = value; }
        public string Flow_description { get => flow_description; set => flow_description = value; }
        public string Flow_name { get => flow_name; set => flow_name = value; }
    }
}