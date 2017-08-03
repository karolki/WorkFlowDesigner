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

namespace WorkFlowDesigner
{
    public partial class AddFlowPanel : DevExpress.XtraEditors.XtraForm
    {
        public AddFlowPanel()
        {
            this.flow = new Flow();
            InitializeComponent();
        }

        private void gcProperties_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAtribute_Click(object sender, EventArgs e)
        {
            this.flow.AtributeList.Add(atribute = new Attribute());
            AddAtribute addAtribute = new AddAtribute(this.flow.AtributeList,this.flow.AtributeList.Count-1 );
           
            if (attributeBindingSource.DataSource != this.flow.AtributeList) attributeBindingSource.DataSource = this.flow.AtributeList;
            addAtribute.ShowDialog();
        }

      
    }
}