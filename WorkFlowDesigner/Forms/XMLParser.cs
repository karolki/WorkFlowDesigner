using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WorkFlowDesigner.Forms
{
    class XMLParser
    {
        public XMLParser()
        {

        }
        public XmlDocument getXMLfromAtributes(List<LayoutControlItem> a)
        {
            XmlDocument xml = new XmlDocument();
            XmlNode docNode = xml.CreateXmlDeclaration("1.0", "UTF-8", null);
            xml.AppendChild(docNode);
            XmlNode itemsNode = xml.CreateElement("Items");
            foreach (var item in a)
            {

                XmlNode itemNode = xml.CreateElement("Item");
                XmlNode idNode = xml.CreateElement("ID");
                XmlAttribute name = xml.CreateAttribute("name");
                name.Value = item.Text;
                XmlAttribute type = xml.CreateAttribute("type");
                type.Value = item.Control.GetType() == typeof(TextBox) ? "text" :
                item.Control.GetType() == typeof(CheckBox) ? "checkbox" :
                item.Control.GetType() == typeof(System.Windows.Forms.ComboBox) ? "list" :
                item.Control.GetType() == typeof(DataGridView) ? "table" : "other";
                if (item.Control.Text == "number") type.Value = "number";
                idNode.Attributes.Append(name);
                idNode.Attributes.Append(type);
                itemNode.AppendChild(idNode);
                XmlNode sizeNode = xml.CreateElement("Size");
                XmlAttribute width = xml.CreateAttribute("width");
                width.Value = item.Width.ToString();
                XmlAttribute height = xml.CreateAttribute("height");
                height.Value = item.Height.ToString();
                sizeNode.Attributes.Append(width);
                sizeNode.Attributes.Append(height);
                itemNode.AppendChild(sizeNode);
                XmlNode locNode = xml.CreateElement("Location");
                XmlAttribute x = xml.CreateAttribute("x");
                x.Value = item.Location.X.ToString();
                XmlAttribute y = xml.CreateAttribute("y");
                y.Value = item.Location.Y.ToString();
                locNode.Attributes.Append(x);
                locNode.Attributes.Append(y);
                itemNode.AppendChild(locNode);

                if (type.Value == "table")
                {
                    XmlNode columnsNode = xml.CreateElement("Columns");
                    DataGridView view = item.Control as DataGridView;
                    foreach (DataGridViewColumn column in view.Columns)
                    {
                        XmlNode columnNode = xml.CreateElement("Column");
                        XmlNode id = xml.CreateElement("ID");
                        XmlAttribute nameColumn = xml.CreateAttribute("name");
                        nameColumn.Value = column.Name;
                        XmlAttribute typeColumn = xml.CreateAttribute("type");
                        XmlAttribute indexColumn = xml.CreateAttribute("index");
                        indexColumn.Value = view.Columns.IndexOf(column).ToString();
                        typeColumn.Value = column.CellTemplate.GetType() == typeof(DataGridViewTextBoxCell) ? "text" :
                        column.CellTemplate.GetType() == typeof(DataGridViewCheckBoxCell) ? "checkbox" :
                        column.CellTemplate.GetType() == typeof(DataGridViewComboBoxCell) ? "list" : "other";
                        id.Attributes.Append(nameColumn);
                        id.Attributes.Append(typeColumn);
                        id.Attributes.Append(indexColumn);
                        columnNode.AppendChild(id);
                        XmlNode sizeColumn = xml.CreateElement("Size");
                        XmlAttribute widthColumn = xml.CreateAttribute("width");
                        widthColumn.Value = column.Width.ToString();
                        sizeColumn.Attributes.Append(widthColumn);
                        columnNode.AppendChild(sizeColumn);
                        columnsNode.AppendChild(columnNode);

                    }

                    itemNode.AppendChild(columnsNode);
                }

                itemsNode.AppendChild(itemNode);

            }
            xml.AppendChild(itemsNode);
            return xml;
        }

    }
    
}
