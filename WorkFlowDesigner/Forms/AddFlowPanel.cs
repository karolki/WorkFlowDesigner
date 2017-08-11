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
        FlowDefinition flow;
        IList<Step> listStep = new List<Step>();
       
        public AddFlowPanel()
        {
            this.flow = new FlowDefinition();
            flow.PositionList = new List<Position>();
            flow.AtributeList = new List<Attributes>();
            InitializeComponent();
            bsPosition.DataSource = this.flow.PositionList;
            bsAttribute.DataSource = this.flow.AtributeList;

        }
        public AddFlowPanel(FlowDefinition flow,IList<Step> step)
        {
            this.flow = flow;
            listStep = step;
            flow.PositionList = new List<Position>();
            flow.AtributeList = new List<Attributes>();
            InitializeComponent();
            bsPosition.DataSource = this.flow.PositionList;
            bsAttribute.DataSource = this.flow.AtributeList;


        }

        private void btnAddAtribute_Click(object sender, EventArgs e)
        {
              if(tbName.Text=="")
            {
                MessageBox.Show("Please enter flow name!");
                return;
            }
            
            CreateForm createForm = new CreateForm(flow);
            createForm.Show();
            createForm.FormClosed += CreateForm_FormClosed;
        }

        private void CreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            flow.AtributeList = (sender as CreateForm).attribute;
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
           
            DefineFlow defineFlow = new DefineFlow(flow);
            defineFlow.FormClosing += DefineFlow_FormClosing;
            defineFlow.Show();
        }

        private void DefineFlow_FormClosing(object sender, FormClosingEventArgs e)
        {
            listStep = (sender as DefineFlow).stepList;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            flow.Flow_name = tbName.Text;
        }

        private void flowDescription_TextChanged(object sender, EventArgs e)
        {
            flow.Flow_description = flowDescription.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NHibernateOperation operation = new NHibernateOperation();
            operation.AddElement<FlowDefinition>(flow);
           
            foreach (var position in flow.PositionList)
            {
                position.Id_flowDefinition = flow;
                operation.AddElement<Position>(position);
               
                
            }
            foreach (var step in listStep)
            {
                operation.AddElement<Step>(step);
                if(step.StepConditionList!=null)
                    foreach (var it in step.StepConditionList)
                    {
                        it.Id_step = step;
                        operation.AddElement<StepConditions>(it);
                    }

            }
            foreach (var attribute in flow.AtributeList)
            {
                attribute.Id_workflow = flow;
                operation.AddElement<Attributes>(attribute);
                if(attribute.List.Count!=0)
                foreach (var item in attribute.List)
                {
                    item.Id_attribute = attribute;
                    operation.AddElement<ListElement>(item);

                }
                foreach (var item in attribute.AccessList)
                {
                    item.Id_attribute = attribute;
                    operation.AddElement<Access>(item);
                }
            }
            
            
            this.Close();
        }


       

    }
}