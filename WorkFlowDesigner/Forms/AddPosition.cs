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
    public partial class AddPosition : DevExpress.XtraEditors.XtraForm
    {
        Position position;
        IList<Position> tempPositionList = new List<Position>();
        int index;
        bool delete = true;
        public AddPosition()
        {
            InitializeComponent();
        }
        public AddPosition(IList<Position> list,int index)
        {
            InitializeComponent();
            tempPositionList = list;
            this.index = index;
            position = list.ElementAt(index);
            tbPositionName.Name = position.Name;
            this.FormClosing += new FormClosingEventHandler(Close);
        }
        private void Close(object sender, FormClosingEventArgs e)
        {
           if(delete) tempPositionList.RemoveAt(index);
        }
        private void tbPositionName_TextChanged(object sender, EventArgs e)
        {
            position.Name = tbPositionName.Text;
        }

        private void btnConfirmAddPosition_Click(object sender, EventArgs e)
        {
            if(position.Name=="")
            {
                MessageBox.Show("Position name can't be empty!");
                return;
            }
            delete = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}