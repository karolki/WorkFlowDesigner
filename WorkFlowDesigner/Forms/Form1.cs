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