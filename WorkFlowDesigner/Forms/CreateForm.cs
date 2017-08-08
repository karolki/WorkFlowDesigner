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
using DevExpress.XtraLayout;

namespace WorkFlowDesigner.Forms
{
    public partial class CreateForm : DevExpress.XtraEditors.XtraForm
    {
        List<Attribute> attribute=new List<Attribute>();
        List<CheckBox> checkBoxList = new List<CheckBox>();
        List<TextBox> textBoxList = new List<TextBox>();
        List<System.Windows.Forms.ComboBox> comboBoxList = new List<System.Windows.Forms.ComboBox>();
        List<LayoutControlItem> layoutControlItemList = new List<LayoutControlItem>();
        List<Label> labelList = new List<Label>();
        Flow flow;
        string name;
        string type;
        public CreateForm()
        {
            InitializeComponent();
            
        }
        public CreateForm(Flow flow)
        {
            InitializeComponent();
            this.flow = flow;
        }


        private void btnAddTB_Click(object sender, EventArgs e)
        {
            AddAtribute addAtribute = new AddAtribute();
            addAtribute.Show();
            addAtribute.FormClosed += AddAtribute_FormClosed;
            

        }

        private void AddAtribute_FormClosed(object sender, FormClosedEventArgs e)
        {
            attribute.Add((sender as AddAtribute).attribute);
            switch (attribute.Last().Type)
            {
                case "text":
                    {
                        layoutControlItemList.Add(new LayoutControlItem());
                        textBoxList.Add(new TextBox());
                        textBoxList.Last().Name = "tb" + (textBoxList.Count - 1).ToString();
                        layoutControlItemList.Last().Control = textBoxList.Last();
                        layoutControlItemList.Last().Name = attribute.Last().Name;
                        lcLayout.AddItem(layoutControlItemList.Last());
                        break;
                    }
                case "list":
                    {
                        layoutControlItemList.Add(new LayoutControlItem());
                        comboBoxList.Add(new System.Windows.Forms.ComboBox());
                        comboBoxList.Last().Name = "cb+" + (comboBoxList.Count - 1).ToString();
                        bs.DataSource = attribute.Last().List;
                        comboBoxList.Last().DataSource = bs;
                        comboBoxList.Last().DisplayMember = "Name";
                        layoutControlItemList.Last().Name = attribute.Last().Name;
                        layoutControlItemList.Last().Control = comboBoxList.Last();
                        lcLayout.AddItem(layoutControlItemList.Last());
                        break;
                    }
                case "checkbox":
                    {
                        layoutControlItemList.Add(new LayoutControlItem());
                        checkBoxList.Add(new CheckBox());
                        checkBoxList.Last().Name = "check" + (checkBoxList.Count - 1).ToString();
                        checkBoxList.Last().Text = attribute.Last().Name;
                        layoutControlItemList.Last().Control = checkBoxList.Last();
                        lcLayout.AddItem(layoutControlItemList.Last());
                        break;
                    }
                case "int":
                    {
                        layoutControlItemList.Add(new LayoutControlItem());
                        textBoxList.Add(new TextBox());
                        textBoxList.Last().Name = "tb" + (textBoxList.Count - 1).ToString();
                        textBoxList.Last().TextChanged += CreateForm_TextChanged;
                        layoutControlItemList.Last().Control = textBoxList.Last();
                        layoutControlItemList.Last().Name = attribute.Last().Name;
                        lcLayout.AddItem(layoutControlItemList.Last());
                        break;
                    }

            }
        }

        private void CreateForm_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch((sender as TextBox).Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                (sender as TextBox).Text = (sender as TextBox).Text.Remove((sender as TextBox).Text.Length - 1);
            }
        }

        private void btnSaveFormToLayout_Click(object sender, EventArgs e)
        {
            lcLayout.SaveLayoutToXml(String.Format("{0}/{1}.xml", Application.StartupPath, flow.Flow_name));
        }

        
    }
}