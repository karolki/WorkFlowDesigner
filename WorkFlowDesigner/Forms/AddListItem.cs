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
    public partial class AddListItem : DevExpress.XtraEditors.XtraForm
    {
        ListElement listElement;
        public AddListItem()
        {
            InitializeComponent();
        }
        public AddListItem(List<ListElement> listListElement,int index)
        {
            InitializeComponent();
            listElement = listListElement.ElementAt(index);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listElement.Name = tbListItemName.Text;
        }
    }
}