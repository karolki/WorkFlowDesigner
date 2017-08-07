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
using System.Runtime.Remoting;

namespace WorkFlowDesigner
{
    public partial class AddListItem : DevExpress.XtraEditors.XtraForm
    {
        IList<ListElement> listListElement = new List<ListElement>();
        int index;

        public AddListItem()
        {
            InitializeComponent();
        }
        public AddListItem(IList<ListElement> list, int index)
        {
            InitializeComponent();
            listListElement = list;
            this.index = index;

        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listListElement.ElementAt(index).Name = tbListItemName.Text;
         
        }

        private void btnAddListItem_Click(object sender, EventArgs e)
        {
            if (tbListItemName.Text == "")
            {
                MessageBox.Show("List item name can't be empty!");
                return;
            }
            this.Close();
        }

        private void btnCancelAddListItem_Click(object sender, EventArgs e)
        {
            listListElement.RemoveAt(index);
            this.Close();
        }
    }
}