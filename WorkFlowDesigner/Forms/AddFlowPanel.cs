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
using WorkFlowDesigner.ClassDatabase;

namespace WorkFlowDesigner
{
   
    public partial class AddFlowPanel : DevExpress.XtraEditors.XtraForm
    {
        FlowDefinition flow;
        IList<Step> listStep = new List<Step>();
        IList<Access> access;
        bool editMode = false;
        public AddFlowPanel()
        {
            this.flow = new FlowDefinition();
            flow.PositionList = new List<Position>();
            flow.AtributeList = new List<Attributes>();
            InitializeComponent();
            bsPosition.DataSource = this.flow.PositionList;
            bsAttribute.DataSource = this.flow.AtributeList;

        }
        public AddFlowPanel(FlowDefinition flow,IList<Step> step,IList<Access> access,bool editMode=true)
        {
            this.flow = flow;
            listStep = step;
            InitializeComponent();
            bsPosition.DataSource = this.flow.PositionList;
            bsAttribute.DataSource = this.flow.AtributeList;
            tbName.Text = this.flow.Flow_name;
            flowDescription.Text = this.flow.Flow_description;
            this.access = access;
            this.editMode = editMode;
            btnDeleteFlow.Visible = true;
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
            
            foreach (var attribute in flow.AtributeList)
            {
                attribute.Id_workflow = flow;
                MessageBox.Show(attribute.DataSource.ToString());
                if(attribute.DataSource!=null)                {
                   operation.AddElement<Source>(attribute.DataSource);
                }
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
            foreach (var step in listStep)
            {
                operation.AddElement<Step>(step);
            }
       

            this.Close();
        }

        private void btnDeleteFlow_Click(object sender, EventArgs e)
        {
            NHibernateOperation operation = new NHibernateOperation();

           
            foreach(var item in flow.FlowList)
            {
                foreach(var ext in item.FlowExtensionList)
                {
                    operation.Delete<FlowExtension>(ext);
                }
                operation.Delete<Flow>(item);
            }
            List<Attributes> listA = new List<Attributes>();
            foreach(var item in flow.AtributeList)
            {
                foreach (var item2 in item.AccessList)
                {
                    operation.Delete<Access>(item2);
                }
                foreach (var list in item.List)
                {
                    operation.Delete<ListElement>(list);
                }
                if (item.Type != "table") operation.Delete<Attributes>(item);
                else listA.Add(item);
            }
            foreach(var item in listA)
            {
                operation.Delete<Attributes>(item);
            }
            foreach(var item in flow.PositionList)
            {
                foreach (var step in item.StartStepList)
                {
                    operation.Delete<Step>(step);
                }
                operation.Delete<Position>(item);
            }
            operation.Delete<FlowDefinition>(flow);
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}