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
            List<Step> startsteplista = new List<Step>();
            List<Step> endsteplista = new List<Step>();


            Flow flow = new Flow();
            flow.Flow_description = "asd";
            flow.Flow_name = "FlowSTep";


            position.Name = "FlowTest";
            position.Id_flow = flow;
            list.Add(position);
            flow.PositionList = list;
            //dodanie przeplywu i pozycji

            Step step = new Step();//dodanie kroku
            step.Description = "TEST";
            step.Start_position_id = position;
            step.End_position_id = position;

            startsteplista.Add(step);
            endsteplista.Add(step);

            Attribute att = new Attribute();
            att.Name = "name";
            att.Type = "";
            att.Read_property = 0;
            att.Required_change = 0;
            att.Optional_change = 0;
            att.Id_workflow = flow;

            List<ListElement> list2 = new List<ListElement>();
            ListElement elem = new ListElement();
            elem.Name = "elmname";
            elem.Id_attribute = att;
            list2.Add(elem);

            att.List = list2;
            lista2.Add(att);

            flow.AtributeList = lista2;

            NHibernateOperation operation = new NHibernateOperation();

            IList<Position> sprawdzam = operation.GetList<Position>();
            System.Console.Write(sprawdzam);

            

            

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