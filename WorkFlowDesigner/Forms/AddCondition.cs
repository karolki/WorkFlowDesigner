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

namespace WorkFlowDesigner.Forms
{
    public partial class AddCondition : DevExpress.XtraEditors.XtraForm
    {
        Step step;
        IList<Attribute> listAttribute;
        string condition="";
        string attribute="";
        public AddCondition()
        {
            InitializeComponent();
        }
        public AddCondition(Step step,IList<Attribute> list)
        {
            
            listAttribute = list;

           
            InitializeComponent();
            attributeBindingSource.DataSource = list;
            this.step = step;
        }

        private void btnAddCondition_Click(object sender, EventArgs e)
        {
            if(tbCondition.Text=="")
            {
                MessageBox.Show("Condition can't be empty!");
                return;
            }
            step.StepConditionList.Add(new StepCondition(attribute+condition));
            this.Close();
            
            
        }

        private void cbAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            attribute = cbAttributes.SelectedText;
        }

        private void tbCondition_TextChanged(object sender, EventArgs e)
        {
            condition = tbCondition.Text;
        }
    }
}