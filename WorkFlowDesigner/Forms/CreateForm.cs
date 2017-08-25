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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars.Docking2010.Views;
using System.Xml;

namespace WorkFlowDesigner.Forms
{
    public partial class CreateForm : DevExpress.XtraEditors.XtraForm
    {
        public List<Attributes> attribute = new List<Attributes>();
        List<CheckBox> checkBoxList = new List<CheckBox>();
        List<TextBox> textBoxList = new List<TextBox>();
        List<System.Windows.Forms.ComboBox> comboBoxList = new List<System.Windows.Forms.ComboBox>();
        List<LayoutControlItem> layoutControlItemList = new List<LayoutControlItem>();
        List<Label> labelList = new List<Label>();
        List<DataGridView> gridVievlist = new List<DataGridView>();
        FlowDefinition flow;
        List<int[]> listTables = new List<int[]>();
        string name;
        string type;
        private Attributes selectedTable = null;
        int? selectedGrid = null;

        public CreateForm()
        {
            InitializeComponent();

        }
        public CreateForm(FlowDefinition flow)
        {
            InitializeComponent();
            this.flow = flow;
            this.FormClosing += CreateForm_FormClosing;
            foreach (var item in flow.AtributeList)
            {
                attribute.Add(item);
                if (item.Parent == null)
                    addItemByType(item.Type);
                else
                {
                    foreach (var grid in gridVievlist)
                    {
                        foreach (var table in listTables)
                        {
                            if (gridVievlist.IndexOf(grid) == table[0])
                            {
                                selectedTable = attribute.ElementAt(table[1]);
                                selectedGrid = gridVievlist.IndexOf(grid);
                            }
                        }
                    }
                    addColumn(item);
                }
            }
            this.Load += CreateForm_Load;
        }

        private void CreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XMLParser parser = new XMLParser();
            XmlDocument xml = parser.getXMLfromAtributes(layoutControlItemList);

            string name1 = String.Format("{0}/{1}abc.xml", "C:/Users/KKiwala/Desktop", flow.Flow_name);
            string name2 = String.Format("{0}/{1} DESIGNER.xml", "C:/Users/KKiwala/Desktop", flow.Flow_name);
            File.Delete(name1);
            File.Delete(name2);
            xml.Save(name1);
            lcLayout.SaveLayoutToXml(name2);
            Document newDocument = new Document();
            NHibernateOperation operation = new NHibernateOperation();
            Document doc = null;
            Document doc2 = null;
            try
            {
                doc = operation.GetDocByName(flow.Flow_name);
                doc2 = operation.GetDocByName(flow.Flow_name + "Design");
            }
            catch { }

            if (File.Exists(name1))
            {
                newDocument.Name = flow.Flow_name;
                string ext = Path.GetExtension(name1);
                string contenttype = "application/xml";
                byte[] bytes;
                FileStream file = new FileStream(name1, FileMode.Open);
                BinaryReader br = new BinaryReader(file);
                bytes = br.ReadBytes((int)file.Length);
                newDocument.Data = bytes;
                newDocument.ContentType = contenttype;
                if (doc != null)
                {
                    newDocument.Id_document = doc.Id_document;
                    operation.Update<Document>(newDocument);
                }else
                operation.AddElement<Document>(newDocument);

            }
            if (File.Exists(name2))
            {
                newDocument.Name = flow.Flow_name + "Design";
                string ext = Path.GetExtension(name2);
                string contenttype = "application/xml";
                byte[] bytes;
                FileStream file = new FileStream(name2, FileMode.Open);
                BinaryReader br = new BinaryReader(file);
                bytes = br.ReadBytes((int)file.Length);
                newDocument.Data = bytes;
                newDocument.ContentType = contenttype;
                if (doc2 != null)
                {
                    newDocument.Id_document = doc2.Id_document;
                    operation.Update<Document>(newDocument);
                }
                else
                    operation.AddElement<Document>(newDocument);

            }
            


        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

            NHibernateOperation operation = new NHibernateOperation();
            Document doc = null;
            try
            {
                doc = operation.GetDocByName(flow.Flow_name + "Design");
            }
            catch (Exception aaa)
            {
                MessageBox.Show(aaa.ToString());

            }
            if (doc == null) return;
            XmlDocument a = new XmlDocument();
            string hex = "";
            foreach (var b in doc.Data)
            {
                hex += b;
            }

            string data = Encoding.UTF8.GetString(doc.Data);
            a.LoadXml(data.Substring(1));
            string path = String.Format("{0}/{1} DESIGNER.xml", "C:/Users/KKiwala/Desktop", flow.Flow_name);

            a.Save(path);
            try
            {
                lcLayout.RestoreLayoutFromXml(path);
            }
            catch (Exception exc) { }
            File.Delete(path);
        }
        public void WriteOutXml(XmlReader xmlReader, string fileName)
        {
            var writer = XmlWriter.Create(fileName);
            writer.WriteNode(xmlReader, true);
        }

        private void btnAddTB_Click(object sender, EventArgs e)
        {
            AddAtribute addAtribute = new AddAtribute(flow.PositionList);
            flow.AtributeList.Add(addAtribute.attribute);
            addAtribute.Show();
            addAtribute.FormClosed += AddAtribute_FormClosed;
        }
        private void Add(object sender, EventArgs e)
        {
            AddAtribute addAtribute = new AddAtribute(flow.PositionList, selectedTable);
            flow.AtributeList.Add(addAtribute.attribute);
            addAtribute.Show();
            addAtribute.FormClosed += AddAtribute_FormClosed;

        }

        private void AddAtribute_FormClosed(object sender, FormClosedEventArgs e)
        {
            attribute.Add((sender as AddAtribute).attribute);
            MessageBox.Show(attribute.Last().DataSource.TableName);
            if (selectedTable == null) addItemByType(attribute.Last().Type);


            if ((sender as AddAtribute).attribute.Parent != null) addColumn((sender as AddAtribute).attribute);
        }
        private void addColumn(Attributes atribute)
        {
            DataGridViewColumn column = new DataGridViewColumn();
            DataGridViewCheckBoxColumn c_column = null;
            DataGridViewCell cell = null;
            switch (atribute.Type)
            {
                case "list":
                    {
                        cell = new DataGridViewComboBoxCell();
                        if (atribute.DataSource == null)
                        {
                            foreach (var item in atribute.List)
                            {
                                (cell as DataGridViewComboBoxCell).Items.Add(item);
                            }
                            (cell as DataGridViewComboBoxCell).DisplayMember = "Name";
                        }
                        else
                        {
                            Connector connector = new Connector();
                            List<string> lista = connector.GetListFromDataSource(atribute.DataSource);
                            foreach (var item in lista)
                            {
                                (cell as DataGridViewComboBoxCell).Items.Add(item);
                            }
                        }
                        break;
                    }
                case "checkbox":
                    {
                        c_column = new DataGridViewCheckBoxColumn();
                        c_column.TrueValue = true;
                        c_column.FalseValue = false;
                        cell = new DataGridViewCheckBoxCell();

                        break;
                    }
                case "text":
                    {
                        cell = new DataGridViewTextBoxCell();
                        break;
                    }
                case "int":
                    {
                        cell = new DataGridViewTextBoxCell();
                        break;
                    }
            }

            if (cell != null)
            {
                cell.Style.BackColor = Color.Wheat;
                if (c_column != null)
                {
                    c_column.Name = atribute.Name;
                    c_column.CellTemplate = cell;
                    gridVievlist.ElementAt((int)selectedGrid).Columns.Add(c_column);
                }

                else
                {
                    column.Name = atribute.Name;
                    column.CellTemplate = cell;
                    gridVievlist.ElementAt((int)selectedGrid).Columns.Add(column);
                }
            }
            attribute.Last().Parent = selectedTable;
            selectedGrid = null;
            selectedTable = null;

        }
        private void addItemByType(string type, Attributes parent = null)
        {

            switch (type)
            {
                case "text":
                    {
                        layoutControlItemList.Add(new LayoutControlItem());
                        textBoxList.Add(new TextBox());
                        textBoxList.Last().Name = "tb" + (textBoxList.Count - 1).ToString();
                        textBoxList.Last().Text = "text";
                        textBoxList.Last().ReadOnly = true;
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
                        if (attribute.Last().DataSource == null)
                        {
                            foreach(var item in attribute.Last().List)
                            {
                                comboBoxList.Last().Items.Add(item.Name);
                            }
                            
                        }
                        else
                        {
                            Connector connector = new Connector();
                            
                            foreach (var item in connector.GetListFromDataSource(attribute.Last().DataSource))
                            {
                                comboBoxList.Last().Items.Add(item);
                            }
                        }
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
                        layoutControlItemList.Last().Name = attribute.Last().Name;
                        layoutControlItemList.Last().Control = checkBoxList.Last();
                        lcLayout.AddItem(layoutControlItemList.Last());
                        break;
                    }
                case "int":
                    {
                        layoutControlItemList.Add(new LayoutControlItem());
                        textBoxList.Add(new TextBox());
                        textBoxList.Last().Name = "tb" + (textBoxList.Count - 1).ToString();
                        textBoxList.Last().Text = "number";
                        textBoxList.Last().TextChanged += CreateForm_TextChanged;
                        textBoxList.Last().ReadOnly = true;
                        layoutControlItemList.Last().Control = textBoxList.Last();
                        layoutControlItemList.Last().Name = attribute.Last().Name;
                        lcLayout.AddItem(layoutControlItemList.Last());
                        break;
                    }
                case "table":
                    {
                        layoutControlItemList.Add(new LayoutControlItem());
                        gridVievlist.Add(new DataGridView());
                        gridVievlist.Last().Name = "tab" + (gridVievlist.Count - 1).ToString();
                        gridVievlist.Last().TextChanged += CreateForm_TextChanged;
                        gridVievlist.Last().AllowUserToAddRows = false;
                        gridVievlist.Last().AutoGenerateColumns = false;
                        layoutControlItemList.Last().Control = gridVievlist.Last();
                        layoutControlItemList.Last().Name = attribute.Last().Name;
                        lcLayout.AddItem(layoutControlItemList.Last());
                        layoutControlItemList.Last().MouseDown += CreateForm_MouseDown;
                        listTables.Add(new int[] { gridVievlist.IndexOf(gridVievlist.Last()), attribute.IndexOf(attribute.Last()) });
                        break;
                    }

            }
        }

        private void CreateForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                foreach (var item in listTables)
                {
                    if (gridVievlist.IndexOf((sender as LayoutControlItem).Control as DataGridView) == item[0])
                    {
                        selectedTable = attribute.ElementAt(item[1]);
                        selectedGrid = gridVievlist.IndexOf((sender as LayoutControlItem).Control as DataGridView);
                    }
                }
                LayoutControlItem view = sender as LayoutControlItem;
                ContextMenu menu = new ContextMenu();
                MenuItem menuItem = new MenuItem("Add Column",
                new EventHandler(Add));
                menuItem.Tag = view;
                menu.MenuItems.Add(menuItem);
                menu.Show(view.Control, e.Location);
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


    }



}