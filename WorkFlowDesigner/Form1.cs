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

            User user = new User();
            user.Name = "asdf";
            user.Surname = "costam";
            user.Permission = "sadf";

            NHibernateOperation operation = new NHibernateOperation();
            operation.Add(user);
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