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
using System.IO;

namespace WorkFlowDesigner.Forms
{
    public partial class CreateForm : DevExpress.XtraEditors.XtraForm
    {
        public List<Attributes> attribute=new List<Attributes>();
        List<CheckBox> checkBoxList = new List<CheckBox>();
        List<TextBox> textBoxList = new List<TextBox>();
        List<System.Windows.Forms.ComboBox> comboBoxList = new List<System.Windows.Forms.ComboBox>();
        List<LayoutControlItem> layoutControlItemList = new List<LayoutControlItem>();
        List<Label> labelList = new List<Label>();
        FlowDefinition flow;
        string name;
        string type;
        public CreateForm()
        {
            InitializeComponent();
            
        }
        public CreateForm(FlowDefinition flow)
        {
            InitializeComponent();
            this.flow = flow;
            this.Load += CreateForm_Load;
           
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
          //lcLayout.RestoreLayoutFromXml(String.Format("{0}/{1}.xml", "C:/Users/KKiwala/Desktop", flow.Flow_name));
           
        }

        private void btnAddTB_Click(object sender, EventArgs e)
        {
            AddAtribute addAtribute = new AddAtribute(flow.PositionList);
            flow.AtributeList.Add(addAtribute.attribute);
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

            lcLayout.SaveLayoutToXml(String.Format("{0}/{1}.xml", "C:/Users/KKiwala/Desktop", flow.Flow_name));
            Document newDocument = new Document();
            NHibernateOperation operation = new NHibernateOperation();
            string name = String.Format("{0}/{1}.xml", "C:/Users/KKiwala/Desktop", flow.Flow_name);
            if (File.Exists(name))
            {

                newDocument.Name = flow.Flow_name;
                string ext = Path.GetExtension(name);
                string contenttype = "application/xml";
                if (contenttype != String.Empty)
                {
                    byte[] bytes;
                    FileStream file = new FileStream(name, FileMode.Open);
                    BinaryReader br = new BinaryReader(file);
                    
                    bytes = br.ReadBytes((int)file.Length);
                    
                    newDocument.Data = bytes;
                    newDocument.ContentType = contenttype;
                    operation.AddElement<Document>(newDocument);
                   
                }
            }
            IList<Document> doc = operation.GetList<Document>();
            Byte[] docs= doc.Last().Data;

            
            
           
        }
    }

      
    
}