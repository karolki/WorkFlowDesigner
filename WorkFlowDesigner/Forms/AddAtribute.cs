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
using DevExpress.XtraGrid;

namespace WorkFlowDesigner
{
    public partial class AddAtribute : DevExpress.XtraEditors.XtraForm
    {
        ListElement testElement;
        List<ListElement> listElement = new List<ListElement>();
        List<Attribute> tempAtributeList = new List<Attribute>();
        int index;
     
        public AddAtribute()
        {
            InitializeComponent();
            btnAddListItem.Visible = false;
            
        }
       
        public AddAtribute(List<Attribute> a, int index)
        {
            
            InitializeComponent();
            this.index = index;
            this.tempAtributeList = a;
            this.atribute = a.ElementAt(index);
            tbAtributeName.Text = a.ElementAt(index).Name;
            cbAtributeType.SelectedItem = a.ElementAt(index).Type;
            btnAddListItem.Visible = false;
            gcListElements.Visible = false;


            listElementBindingSource.DataSource = listElement;
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
                gcListElements.Visible = true;
                btnAddListItem.Visible = true;
            }
            else
            {
                gcListElements.Visible = false;
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
            listElement.Add(new ListElement());
            listElementBindingSource.ResetBindings(false);
            AddListItem addListItem = new AddListItem(listElement,listElement.Count-1);
            addListItem.Show();
            addListItem.FormClosing += new FormClosingEventHandler(AddListItem_Closing);
        }
        private void AddListItem_Closing(object sender, FormClosingEventArgs e)
        {
            listElementBindingSource.ResetBindings(true);
        }
        



        private void lbcListItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tempAtributeList.RemoveAt(index);
            this.Close();
        }
        
    }
}