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
   
    public partial class AddFlowPanel : DevExpress.XtraEditors.XtraForm
    {
        
       
        public AddFlowPanel()
        {
            this.flow = new Flow();
            InitializeComponent();
            
         }
                
        private void gcProperties_Click(object sender, EventArgs e)
        {

        }
        
        private void btnAddAtribute_Click(object sender, EventArgs e)
        {
            this.flow.AtributeList.Add(atribute = new Attribute());
            AddAtribute addAttribute = new AddAtribute(this.flow.AtributeList, this.flow.AtributeList.Count - 1);
            if (bsAttribute.DataSource != this.flow.AtributeList) bsAttribute.DataSource = this.flow.AtributeList;
            addAttribute.Show();
            addAttribute.FormClosing += new FormClosingEventHandler(AddAttribute_Closing);
        }
        
    
    private void AddAttribute_Closing(object sender, FormClosingEventArgs e)
    {
        bsAttribute.ResetBindings(true);
    }



    // Somewhere else in your code:

}
}