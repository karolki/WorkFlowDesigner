using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WorkFlowDesigner
{
    public class StepView
    {
        String startPos;
        String endPos;
        String description;
        Step stepp;
        public StepView() { }
        public StepView(String start, String end, String desc, Step step)
        {
            startPos = start;
            endPos = end;
            description = desc;
            stepp = step;
        }
        public virtual String StartPos { get => startPos; set => startPos = value; }
        public virtual String EndPos { get => endPos; set => endPos = value; }
        public virtual String Description { get => description; set => description = value; }
        public virtual Step Stepp { get => stepp; set => stepp = value; }
    }
}
