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
    public partial class StepSet : DevExpress.XtraEditors.XtraForm
    {
        FlowDefinition flow;
        List<StepView> stepViev = new List<StepView>();
        List<Step> Steps = new List<Step>();
        List<StepConditions> StepConditions = new List<StepConditions>();

        public StepSet()
        {
            InitializeComponent();
        }
        public StepSet(FlowDefinition flow)
        {
            InitializeComponent();
            this.flow = flow;
            for(int i=0;i<flow.PositionList.Count;i++)
            {
                cbEndPosition.Items.Add(flow.PositionList.ElementAt(i).Name);
                cbStartPosition.Items.Add(flow.PositionList.ElementAt(i).Name);
            }
            stepViewBindingSource.DataSource = stepViev;
        }

        private void btnSetStep_Click(object sender, EventArgs e)
        {

        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}