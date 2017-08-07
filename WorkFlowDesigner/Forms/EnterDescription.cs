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
    public partial class EnterDescription : DevExpress.XtraEditors.XtraForm
    {
        public string description;
        public EnterDescription()
        {
            InitializeComponent();
        }
        public EnterDescription(string description)
        {
            this.description = description;
            InitializeComponent();
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {
            description = tbDescription.Text;
        }

        private void btnAddDesc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}