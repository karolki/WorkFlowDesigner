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
    public partial class AddCondition : DevExpress.XtraEditors.XtraForm
    {
        Step step;
        IList<Attributes> listAttribute;
        string condition = "";
        string attribute = "";
        public AddCondition()
        {
            InitializeComponent();

        }
        public AddCondition(Step step, IList<Attributes> list)
        {
            listAttribute = list;
            InitializeComponent();
            this.step = step;

            if (this.step.StepConditionList == null) this.step.StepConditionList = new List<StepConditions>();
            
            this.step.StepConditionList.Add(new StepConditions());
            stepConditionsBindingSource.DataSource = this.step.StepConditionList;
            bsAtributeList.DataSource = this.listAttribute;
           
            operatorDataGridViewTextBoxColumn.Items.AddRange(new string[] { "<", "<=", ">", ">=", "=", "!=" });
           
            dgv.CellClick += Dgv_CellClick;
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).CurrentCell.Value == null)
                return;
            foreach (var element in listAttribute)
            { 

                if ((sender as DataGridView).CurrentCell.Value.ToString() == element.Name && element.Type == "int")
                {
                    operatorDataGridViewTextBoxColumn.Items.Clear();
                    operatorDataGridViewTextBoxColumn.Items.AddRange(new string[] { "<", "<=", ">", ">=", "=", "!=" });
                    break;
                }
                else if ((sender as DataGridView).CurrentCell.Value.ToString() == element.Name && element.Type == "text")
                {
                    operatorDataGridViewTextBoxColumn.Items.Clear();
                    operatorDataGridViewTextBoxColumn.Items.AddRange(new string[] { "=", "!=" });
                    break;
                }
            }
        }

       

   

      
    }
    public class ConditionData
    {
        public ConditionData(List<Attributes> a)
        {
            atributes = a;
        }
        public List<Attributes> atributes;
        public string[] operators = new string[] { "<", "<=", ">", ">=", "=", "!=" };
        public string[] answers = new string[] { "is checked", "is not checked", "is filled" };

    }
}
