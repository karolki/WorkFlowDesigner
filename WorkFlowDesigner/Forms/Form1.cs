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
        
        public Form1()
        {
            InitializeComponent();

            InitNH init = new InitNH();
            init.InitNHibernate();
            Position position = new Position();
            List<Position> list = new List<Position>();
            List<Attribute> lista2 = new List<Attribute>();
            Flow flow = new Flow();
            flow.Flow_description = "asd";
            flow.Flow_name = "asd";
            

            position.Name = "przeplywamsobieposwiecie";
            position.Id_flow = flow;
            list.Add(position);
            flow.PositionList = list;
            flow.AtributeList = lista2;
            
           
           

            // operation = new NHibernateOperation();
            //operation.AddFlow(flow);
           // operation.AddPosition(position);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFlowPanel addFlowPanel = new AddFlowPanel();
            addFlowPanel.Show();
        }
     }
}