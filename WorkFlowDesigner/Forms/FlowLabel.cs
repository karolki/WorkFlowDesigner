using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WorkFlowDesigner.Forms
{
    public class FlowLabel: Label
    {
        public FlowLabel() { }
        public FlowLabel(Position position_changed)
        {
            positionSet = position_changed;
            Text = positionSet.Name;
            BackColor = Color.Black;
            ForeColor = Color.White;
            TextAlign = ContentAlignment.MiddleCenter;
        }
        public List<Connection> connections = new List<Connection>();
        public Position positionSet;
    }
}
