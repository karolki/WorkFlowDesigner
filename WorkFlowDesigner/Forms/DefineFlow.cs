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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Base;

namespace WorkFlowDesigner
{
    public partial class DefineFlow : DevExpress.XtraEditors.XtraForm
    {
        FlowDefinition flow;
        
        List<FlowLabel> flowLabels = new List<FlowLabel>();
        FlowLabel selectedLabel=null;
        FlowLabel selectedLabelStart = null;
        FlowLabel selectedLabelEnd =null;
        public List<Step> stepList=new List<Step>();
        public DefineFlow()
        {
            InitializeComponent();
           
        }
        public DefineFlow(FlowDefinition flow)
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
            this.KeyDown += DefineFlow_KeyDown;
            this.FormClosing += DefineFlow_FormClosing;
            InitializeComponent();
            gridView1.MouseDown += GridView1_MouseDown;

        }

        private void DefineFlow_FormClosing(object sender, FormClosingEventArgs e)
        {
            stepList = new List<Step>();
            foreach(var label in flowLabels)
            {
                foreach(var connection in label.connections)
                {
                    
                    stepList.Add(connection.step);
                    
                }
            }
           
        }

        private void GridView1_MouseDown(object sender, MouseEventArgs e)
        {
         
            GridView view = sender as GridView;
            // obtaining hit info 
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (((e.Button & MouseButtons.Right) != 0) && (hitInfo.InRow) &&
                (!view.IsGroupRow(hitInfo.RowHandle)))
            {
                // switching focus 
                view.FocusedRowHandle = hitInfo.RowHandle;
                // showing the custom context menu 

                ViewMenu menu = new ViewMenu(view);
                DXMenuItem menuItem = new DXMenuItem("DeleteRow",
                  new EventHandler(DeleteFocusedRow));
                menuItem.Tag = view;
                menu.Items.Add(menuItem);
                menu.Show(hitInfo.HitPoint);
            }
        }

        void DeleteFocusedRow(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            if (menuItem == null) return;
            ColumnView View = menuItem.Tag as ColumnView;
            View.DeleteRow(View.FocusedRowHandle);
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
                        connection.endFlowLabel.Location.X, connection.endFlowLabel.Location.Y,Color.Black);
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
                                connection.endFlowLabel.Location.X, connection.endFlowLabel.Location.Y,Color.Black);
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
            DrawLShapeLine(this.CreateGraphics(), selectedLabelStart.Location.X, selectedLabelStart.Location.Y, selectedLabelEnd.Location.X, selectedLabelEnd.Location.Y,Color.Black);
            selectedLabelStart = null;
            selectedLabelEnd = null;
            List<Step> tempList = new List<Step>();
            foreach (var position in flowLabels)
            {
                foreach (var a in position.connections)
                {
                    tempList.Add(a.step);
                    
                }
            }
            stepList = tempList;
            stepBindingSource1.DataSource = stepList;
            stepBindingSource1.ResetBindings(true);
        }

  

        private void DefineFlow_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedLabel != null) selectedLabel = null;
            else
            {
                foreach (var label in flowLabels)
                {
                    foreach (var connection in label.connections)
                    {
                        if(connection.IsSelected(e.Location))
                        {
                            DrawLShapeLine(this.CreateGraphics(), connection.startFlowLabel.Location.X, connection.startFlowLabel.Location.Y, connection.endFlowLabel.Location.X, connection.endFlowLabel.Location.Y, Color.Red);
                            AddCondition addCondition = new AddCondition(connection.step, flow.AtributeList);
                            addCondition.FormClosed += AddCondition_FormClosed;
                            addCondition.Show();
                            return;
                        }
                    }
                }
            }
        }

        private void AddCondition_FormClosed(object sender, FormClosedEventArgs e)
        {
            Step step = new Step();
            step.Condition = "";

            foreach (var item in (sender as AddCondition).Condition())
            {
                step.Condition += item[0];
                step.Condition += item[1];
            }
           
        }

        private void DefineFlow_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedLabel != null) selectedLabel.Location = e.Location;

        }
    
        public void DrawLShapeLine(System.Drawing.Graphics g, int StartX, int StartY, int EndX, int EndY,Color color)
        {
            Pen myPen = new Pen(color);
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
        public Step step;
        public Label label;
        public Connection()
        { }
        public Connection(FlowLabel start, FlowLabel end, string description)
        {
            startFlowLabel = start;
            endFlowLabel = end;
            label = new Label();
            label.Text = description;
            step = new Step(start.positionSet, end.positionSet, description,"");
        }
        public bool IsSelected(Point p)
        {
            List<Rectangle> rc = new List<Rectangle>();
            rc.Add(new Rectangle(startFlowLabel.Location.X-2, (startFlowLabel.Location.Y > endFlowLabel.Location.Y ? endFlowLabel.Location.Y : startFlowLabel.Location.Y),4,Math.Abs(endFlowLabel.Location.Y-startFlowLabel.Location.Y)));
            rc.Add(new Rectangle(endFlowLabel.Location.X > startFlowLabel.Location.X ? startFlowLabel.Location.X : endFlowLabel.Location.X, endFlowLabel.Location.Y + 2, Math.Abs(startFlowLabel.Location.X - endFlowLabel.Location.X), 4));
            foreach (var rect in rc)
            {
                if(rect.Contains(p))
                {
                    return true;
                    
                }
            }
            return false;
        }
      

       
       
    }
}
   
