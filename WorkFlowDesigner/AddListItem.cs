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
        public AddListItem()
        {
            InitializeComponent();
        }
        public AddListItem(List<ListElement> listElement)
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}