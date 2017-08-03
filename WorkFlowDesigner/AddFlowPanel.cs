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
            InitializeComponent();
        }

        private void gcProperties_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAtribute_Click(object sender, EventArgs e)
        {
            AddAtribute addAtribute = new AddAtribute();
            addAtribute.ShowDialog();
        }
    }
}