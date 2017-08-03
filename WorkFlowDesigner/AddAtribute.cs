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
    public partial class AddAtribute : DevExpress.XtraEditors.XtraForm
    {
        public AddAtribute()
        {
            InitializeComponent();
        }
        public AddAtribute(List<Attribute> a, int index)
        {
            InitializeComponent();
            this.atribute = a.ElementAt(index);
            tbAtributeName.Text = a.ElementAt(index).Name;
            cbAtributeType.SelectedItem = a.ElementAt(index).Type;
        }
        

        private void tbAtributeName_TextChanged(object sender, EventArgs e)
        {
            atribute.Name = tbAtributeName.Text;
        }

        private void cbAtributeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            atribute.Type = cbAtributeType.SelectedItem.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}