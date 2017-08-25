using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WorkFlowDesigner
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        FlowDefinition flow=new FlowDefinition();
        IList<FlowDefinition> listFlow;
        IList<Attributes> attributes2 = new List<Attributes>();
        IList<Position> position2 = new List<Position>();
        IList<Step> step2 = new List<Step>();
        IList<Access> access = new List<Access>();
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
            comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;
            using (SqlConnection conn = new SqlConnection())
            {
                
                conn.ConnectionString = @"Server = 172.21.70.40; Database = opticamp; User Id = sa;Password = cdnxl1*";
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT name FROM Sys.Tables", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MessageBox.Show(String.Format("{0}",
                        // call the objects from their index
                        reader[0]));
                    }
                }
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFlowPanel addFlowPanel = new AddFlowPanel();
            addFlowPanel.Show();
        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
             foreach (var a in listFlow)
             {
                if (a.Flow_name == comboBox1.SelectedItem.ToString()) 
                 {
                     
                     NHibernateOperation operation = new NHibernateOperation();
                     flow.Flow_name = a.Flow_name;
                     flow.id_flowDefinition = a.id_flowDefinition;
                     flow.Flow_description = a.Flow_description;
                     
                     flow.PositionList = operation.GetPositionByID(flow.id_flowDefinition);
                     flow.AtributeList = operation.GetAttributeByID(flow.id_flowDefinition);
                     flow.FlowList = operation.GetFlowByFlowID(flow);
                     foreach(Attributes at in flow.AtributeList)
                     {
                        at.AccessList = operation.GetAccesByAtrID(at);
                     }
                     foreach(Position pos in flow.PositionList)
                    {
                        operation.GetStepByPosID(pos);
                    }
                    return;
                 }
             }
         }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddFlowPanel addFlowPanel = new AddFlowPanel(flow, step2,access);
            addFlowPanel.Show();
        }

        
    }
}