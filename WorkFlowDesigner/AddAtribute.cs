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
            btnAddListItem.Visible = false;
        }
        public AddAtribute(List<Attribute> a, int index)
        {
            InitializeComponent();
            this.atribute = a.ElementAt(index);
            tbAtributeName.Text = a.ElementAt(index).Name;
            cbAtributeType.SelectedItem = a.ElementAt(index).Type;
            btnAddListItem.Visible = false;
        }
        

        private void tbAtributeName_TextChanged(object sender, EventArgs e)
        {
            atribute.Name = tbAtributeName.Text;
        }

        private void cbAtributeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            atribute.Type = cbAtributeType.SelectedItem.ToString();
            if (atribute.Type.ToString() == "list")
            {
              
                btnAddListItem.Visible = true;
            }
            else
            {
               
                btnAddListItem.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbAtributeName.Text == "")
            {
                MessageBox.Show("Name of the attribute can't be empty!");
                return;
            }
           if (cbAtributeType.SelectedItem==null)
            {
                MessageBox.Show("Type of the attribute can't be empty!");
                return;
            }
            this.Close();
        }

        private void btnAddListItem_Click(object sender, EventArgs e)
        {

        }

       

        private void lbcListItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}