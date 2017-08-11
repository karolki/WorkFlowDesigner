using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WorkFlowDesigner
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        FlowDefinition flow = new FlowDefinition();
        IList<FlowDefinition> listFlow;
        IList<Attributes> attributes2 = new List<Attributes>();
        IList<Position> position2 = new List<Position>();
        IList<Step> step2 = new List<Step>();
        public Form1()
        {
            InitializeComponent();
            InitNH init = new InitNH();
            init.InitNHibernate();
            NHibernateOperation operation = new NHibernateOperation();
            
            listFlow = operation.GetList<FlowDefinition>();
            foreach(var a in listFlow)
            {
                comboBox1.Items.Add(a.Flow_name);
            }
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFlowPanel addFlowPanel = new AddFlowPanel();
            addFlowPanel.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (var a in listFlow)
            {
                MessageBox.Show("X2");
                if (a.Flow_name==comboBox1.SelectedText)
                {
                    MessageBox.Show("X");
                    NHibernateOperation operation = new NHibernateOperation();
                    IList<Attributes> attributes = operation.GetList<Attributes>();
                    IList<Position> position = operation.GetList<Position>();
                    IList<Step> step = operation.GetList<Step>();
                    IList<StepConditions> stepconditions = operation.GetList<StepConditions>();
                    IList<Access> access = operation.GetList<Access>();
                    IList<ListElement> listelement = operation.GetList<ListElement>();

                    
                    IList<StepConditions> stepconditions2 = new List<StepConditions>();
                    IList<Access> access2 = new List<Access>();
                    IList<ListElement> listelement2 = new List<ListElement>();
                    
                    flow.Flow_name = a.Flow_name;
                    flow.id_flowDefinition = a.id_flowDefinition;
                    
                    foreach (var x in attributes)
                    {
                        if (x.Id_workflow == flow) attributes2.Add(x);
                    }
                    foreach (var x in listelement)
                    {
                        foreach (var x2 in attributes2)
                        {
                            if (x.Id_attribute == x2)
                            {
                                x2.List.Add(x);
                            }
                        }
                    }
                    foreach (var x in position)
                    {
                        if (x.Id_flowDefinition == flow) position2.Add(x);
                    }
                    foreach (var x in access)
                    {
                        foreach(var x2 in position2)
                        {
                            if(x.Id_position==x2)
                            {
                                x2.Accesslist.Add(x);
                            }
                        }
                        foreach (var x2 in attributes2)
                        {
                            if (x.Id_attribute==x2)
                            {
                                x2.AccessList.Add(x);
                            }
                        }
                    }
                    foreach (var x in stepconditions)
                    {
                        foreach (var x2 in step2)
                        {
                            if (x.Id_step == x2)
                            {
                                x2.StepConditionList.Add(x);
                            }
                        }
                    }
                    foreach (var x in step)
                    {
                        foreach(var x2 in position2)
                        {
                            if(x.Start_position_id==x2)
                            {
                                x2.StartStepList.Add(x);
                            }
                            else if (x.End_position_id == x2)
                            {
                                x2.EndStepList.Add(x);
                            }
                        }
                    }
                    flow.Flow_description = a.Flow_description;



                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flow.AtributeList = attributes2;
            flow.PositionList = position2;
            
            this.Hide();
            AddFlowPanel addFlowPanel = new AddFlowPanel(flow, step2);
            addFlowPanel.Show();
        }
    }
}