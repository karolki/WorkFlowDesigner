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
using DevExpress.XtraBars.Docking.Helpers;
using DevExpress.XtraBars.Docking;

namespace WorkFlowDesigner.Forms
{
    public partial class SetAccess : DevExpress.XtraEditors.XtraForm
    {
        public Attributes attribute;
        IList<Position> positionList;
        public  List<AccessPosition> accessPositionList = new List<AccessPosition>();
       
        public SetAccess()
        {
            InitializeComponent();
        }
        public SetAccess(Attributes a,IList<Position> list)
        {
            InitializeComponent();
            attribute = a;
            attribute.AccessList = new List<Access>();
            positionList = list;

            foreach(var item in list)
            {
                accessPositionList.Add(new AccessPosition(lc, item));
                accessPositionList.Last().read.Checked = true;
                
               
            }
            this.FormClosing += SetAccess_FormClosing;
        }

        private void SetAccess_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            foreach (var access in accessPositionList)
            {
                attribute.AccessList.Add(new Access());
                attribute.AccessList.Last().Id_position = access.position;
                attribute.AccessList.Last().Optional_change = access.optional_write.Checked ? 1 : 0;
                attribute.AccessList.Last().Read_property = access.read.Checked ? 1 : 0;
                attribute.AccessList.Last().Required_change = access.write.Checked ? 1 : 0;
                attribute.AccessList.Last().Id_attribute = attribute;
            }
            
        }
    }
    public class AccessPosition  
    {
        public Position position;
        public CheckBox read, write, optional_write;
        LayoutControlItem r, w, o;
        

        AccessPosition() { }
       public  AccessPosition(LayoutControl lc, Position pos)
        {
            position = pos;
            read = new CheckBox();
            write = new CheckBox();
            optional_write = new CheckBox();
            read.Text = "Read";
            write.Text = "Write";
            optional_write.Text = "Optional write";
            r = new LayoutControlItem();
            w = new LayoutControlItem();
            o = new LayoutControlItem();

            r.Control = read;
            w.Control = write;
            o.Control = optional_write;
            r.Text = position.Name;
            r.TextVisible = true;
            lc.AddItem(r);          
            lc.AddItem(w);
            lc.Items.Last().Move(lc.Items.ElementAt(lc.Items.Count - 2), DevExpress.XtraLayout.Utils.InsertType.Right);
            lc.AddItem(o);
            lc.Items.Last().Move(lc.Items.ElementAt(lc.Items.Count - 3), DevExpress.XtraLayout.Utils.InsertType.Right);
            read.CheckedChanged += Read_CheckedChanged;

        }

        private void Read_CheckedChanged(object sender, EventArgs e)
        {
            if(read.Checked==false)
            {
                write.Checked = false;
                optional_write.Checked = false;
            }
        }
    }

}