using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WorkFlowDesigner.Forms;

namespace WorkFlowDesigner
{
    public partial class DefineFlow : DevExpress.XtraEditors.XtraForm
    {
        Flow flow;
        
        List<FlowLabel> flowLabels = new List<FlowLabel>();
        FlowLabel selectedLabel=null;
        FlowLabel selectedLabelStart = null;
        FlowLabel selectedLabelEnd =null;

        public DefineFlow()
        {
            InitializeComponent();
           
        }
        public DefineFlow(Flow flow)
        {
            this.flow = flow;
            foreach (var position in flow.PositionList)
            {
                flowLabels.Add(new FlowLabel(position));
                this.Controls.Add(flowLabels.ElementAt(flowLabels.Count - 1));
                flowLabels.ElementAt(flowLabels.Count - 1).MouseClick += Label_MouseClick;
                flowLabels.ElementAt(flowLabels.Count - 1).LocationChanged += DefineFlow_LocationChanged;

            }
            this.MouseClick += DefineFlow_MouseClick;
            this.MouseMove += DefineFlow_MouseMove;
            this.DoubleBuffered = true;
            this.KeyDown += DefineFlow_KeyDown; ;
            InitializeComponent();
        }
        private void DefineFlow_KeyDown(object sender, KeyEventArgs e)
        {
            if (selectedLabelStart != null && e.KeyCode==Keys.Delete)
            {
               for(int i=selectedLabelStart.connections.Count-1;i>=0;i--)
                {
                    selectedLabelStart.connections.ElementAt(i).label.Hide();
                    selectedLabelStart.connections.RemoveAt(i);
                }
                selectedLabelStart.BackColor = Color.Black;
                 selectedLabelStart = null;
                Invalidate();
               
            }
        }

        private void DefineFlow_LocationChanged(object sender, EventArgs e)
        {
            Invalidate();
            foreach (var flowlabel in flowLabels)
            {
                foreach (var connection in flowlabel.connections)
                {
                    DrawLShapeLine(this.CreateGraphics(), connection.startFlowLabel.Location.X, connection.startFlowLabel.Location.Y,
                        connection.endFlowLabel.Location.X, connection.endFlowLabel.Location.Y);
                    if(connection.label.Text!="") connection.label.Location=
                            new Point((int)(connection.startFlowLabel.Location.X+connection.endFlowLabel.Location.X)/2,connection.endFlowLabel.Location.Y);
                }
            }
        }

        private void Label_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (selectedLabel == null) selectedLabel = (sender as FlowLabel);
                else
                {
                    selectedLabel = null;
                    foreach (var flowlabel in flowLabels)
                    {
                        foreach (var connection in flowlabel.connections)
                        {

                            DrawLShapeLine(this.CreateGraphics(), connection.startFlowLabel.Location.X, connection.startFlowLabel.Location.Y,
                                connection.endFlowLabel.Location.X, connection.endFlowLabel.Location.Y);
                            if (connection.label.Text != "") connection.label.Location = 
                                    new Point((int)(connection.startFlowLabel.Location.X + connection.endFlowLabel.Location.X) / 2,connection.endFlowLabel.Location.Y);
                        }
                    }
                }
                
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (selectedLabel == null)
                {
                    if (selectedLabelStart == null)
                    {
                        selectedLabelStart = sender as FlowLabel;
                        (sender as FlowLabel).BackColor = Color.HotPink;
                    }
                    else if (selectedLabelStart != null)
                    {
                        selectedLabelEnd = sender as FlowLabel;
                        selectedLabelStart.BackColor = Color.Black;
                        
                        EnterDescription enterDescription = new EnterDescription();
                        enterDescription.Show();
                        enterDescription.FormClosed += EnterDescription_FormClosed;
                        
                    }
                }
            }
        }

        private void EnterDescription_FormClosed(object sender, FormClosedEventArgs e)
        {
            selectedLabelStart.connections.Add(new Connection(selectedLabelStart, selectedLabelEnd, (sender as EnterDescription).description));
           
            this.Controls.Add(selectedLabelStart.connections.ElementAt(selectedLabelStart.connections.Count - 1).label);
            selectedLabelStart.connections.ElementAt(selectedLabelStart.connections.Count - 1).label.Location =
             new Point((int)(selectedLabelStart.Location.X + selectedLabelEnd.Location.X) / 2,selectedLabelEnd.Location.Y);
            DrawLShapeLine(this.CreateGraphics(), selectedLabelStart.Location.X, selectedLabelStart.Location.Y, selectedLabelEnd.Location.X, selectedLabelEnd.Location.Y);
            selectedLabelStart = null;
            selectedLabelEnd = null;
        }

  

        private void DefineFlow_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedLabel != null) selectedLabel = null;
            
        }

        private void DefineFlow_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedLabel != null) selectedLabel.Location = e.Location;

        }
    
        public void DrawLShapeLine(System.Drawing.Graphics g, int StartX, int StartY, int EndX, int EndY)
        {
            Pen myPen = new Pen(Color.Black);
            myPen.Width = 2;
            int arrowSize = 4;
            int deltaPointX = EndX - StartX;
            int deltaPointY = EndY - StartY;
            Point[] points;
            if (deltaPointX >= 0)
            {
                points = new Point[]{
                new Point(StartX, StartY),
                new Point(StartX, deltaPointY + StartY),
                new Point(StartX + deltaPointX, StartY + deltaPointY),
                // Arrow right
                new Point(StartX + deltaPointX - arrowSize, StartY + deltaPointY - arrowSize),
                new Point(StartX + deltaPointX - arrowSize, StartY + deltaPointY + arrowSize),
                new Point(StartX + deltaPointX, StartY + deltaPointY)
                };
                g.DrawLines(myPen, points);
            }
            if (deltaPointX < 0)
            {
                points = new Point[]{
                new Point(StartX, StartY),
                new Point(StartX, deltaPointY + StartY),
                new Point(StartX + deltaPointX+100, StartY + deltaPointY),
                // Arrow right
                new Point(StartX + deltaPointX + arrowSize+100, StartY + deltaPointY + arrowSize),
                new Point(StartX + deltaPointX + arrowSize+100, StartY + deltaPointY - arrowSize),
                new Point(StartX + deltaPointX+100, StartY + deltaPointY)
                };
                g.DrawLines(myPen, points);
            }

        }
    }
     public class Connection
    {
        public FlowLabel startFlowLabel;
        public FlowLabel endFlowLabel;
       
        public Label label;
        public Connection()
        { }
        public Connection(FlowLabel start, FlowLabel end,string description)
        {
            startFlowLabel = start;
            endFlowLabel = end;
            label = new Label();
            label.Text = description;        
        }

      

       
       
    }
}
   
