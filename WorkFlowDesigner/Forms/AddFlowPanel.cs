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
using DevExpress.XtraGrid;
using WorkFlowDesigner.Forms;

namespace WorkFlowDesigner
{
   
    public partial class AddFlowPanel : DevExpress.XtraEditors.XtraForm
    {
        Flow flow;
       
        public AddFlowPanel()
        {
            this.flow = new Flow();
            flow.PositionList = new List<Position>();
            flow.AtributeList = new List<Attribute>();
            InitializeComponent();
            bsPosition.DataSource = this.flow.PositionList;
            bsAttribute.DataSource = this.flow.AtributeList;

        }
        
        private void btnAddAtribute_Click(object sender, EventArgs e)
        {
            /*  flow.AtributeList.Add(new Attribute());
              AddAtribute addAttribute = new AddAtribute(flow.AtributeList, flow.AtributeList.Count - 1);
              addAttribute.Show();
              addAttribuateForm te.FormClosing += new FormClosingEventHandler(AddAttribute_Closing);*/
              if(tbName.Text=="")
            {
                MessageBox.Show("Please enter flow name!");
                return;
            }
            CreateForm createForm = new CreateForm(flow);
            createForm.Show();
        }
        
    
    private void AddAttribute_Closing(object sender, FormClosingEventArgs e)
    {
        bsAttribute.ResetBindings(true);
    }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            flow.PositionList.Add(new Position());
            AddPosition addAttribute = new AddPosition(flow.PositionList, flow.PositionList.Count - 1);
            addAttribute.Show();
            addAttribute.FormClosing += new FormClosingEventHandler(AddPosition_Closing);
        }
    private void AddPosition_Closing(object sender, FormClosingEventArgs e)
     {
            bsPosition.ResetBindings(true);
     }

        private void btnSetSteps_Click(object sender, EventArgs e)
        {
            //StepSet stepSet = new StepSet(flow);
            //stepSet.Show();
            DefineFlow defineFlow = new DefineFlow(flow);
            defineFlow.Show();
        }


        // Somewhere else in your code:

    }
}