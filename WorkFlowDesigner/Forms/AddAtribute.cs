﻿using System;
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
using WorkFlowDesigner.Forms;

namespace WorkFlowDesigner
{
    public partial class AddAtribute : DevExpress.XtraEditors.XtraForm
    {

        public Attributes attribute;
        IList<Position> positionList;
        public Attributes table = null;
      //  IList<Attribute> tempAtributeList = new List<Attribute>();
      //  int index;
        bool delete = true;
        public AddAtribute(IList<Position> pos, Attributes id_parent=null)
        {
            table = id_parent;
            InitializeComponent();
            btnAddListItem.Visible = false;
            attribute = new Attributes();
            attribute.Parent = id_parent;
            attribute.List = new List<ListElement>();
            listElementBindingSource.DataSource = attribute.List;
            positionList = pos;
            gcListElements.Visible = false;
        }
       
        public AddAtribute(IList<Attributes> a, int index,IList<Position>pos)
        {
            
            InitializeComponent();
            
            this.attribute = a.ElementAt(index);
            tbAtributeName.Text = a.ElementAt(index).Name;
            cbAtributeType.SelectedItem = a.ElementAt(index).Type;
            btnAddListItem.Visible = false;
            gcListElements.Visible = false;
            attribute.List = new List<ListElement>();
            this.FormClosing += new FormClosingEventHandler(Closing);
            listElementBindingSource.DataSource = attribute.List;
        }
        

        private void tbAtributeName_TextChanged(object sender, EventArgs e)
        {
            attribute.Name = tbAtributeName.Text;
            
        }

        private void cbAtributeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            attribute.Type = cbAtributeType.SelectedItem.ToString();
            if (attribute.Type.ToString() == "list")
            {
                gcListElements.Visible = true;
                btnAddListItem.Visible = true;
            }
            else
            {
                gcListElements.Visible = false;
                btnAddListItem.Visible = false;
            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbAtributeName.Text == "")
            {
                MessageBox.Show("Name of the attribute can't be empty!");
                return;
            }
           if (cbAtributeType.SelectedItem==null)
            {
                MessageBox.Show("Type of the attribute can't be empty!");
                return;
            }
            delete = false;
            SetAccess setAccess = new SetAccess(attribute, positionList);
            
            setAccess.Show();
            this.Close();
        }

      

        

        private void btnAddListItem_Click(object sender, EventArgs e)
        {
            attribute.List.Add(new ListElement());
            listElementBindingSource.ResetBindings(false);
            AddListItem addListItem = new AddListItem(attribute.List, attribute.List.Count-1);
            addListItem.Show();
            addListItem.FormClosing += new FormClosingEventHandler(AddListItem_Closing);
            
        }
        private void AddListItem_Closing(object sender, FormClosingEventArgs e)
        {
            listElementBindingSource.ResetBindings(true);
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        private void Closing(object sender, FormClosingEventArgs e)
        {
        //    if(delete)tempAtributeList.RemoveAt(index); ;
        }

        private void btnSetSouce_Click(object sender, EventArgs e)
        {
            SetDatasource setDataSource = new SetDatasource();
            setDataSource.Show();
            setDataSource.FormClosing += SetDataSource_FormClosing;
        }

        private void SetDataSource_FormClosing(object sender, FormClosingEventArgs e)
        {
            attribute.DataSource = (sender as SetDatasource).source;
            btnAddListItem.Visible = false;
            MessageBox.Show(attribute.DataSource.ToString());
            MessageBox.Show(attribute.DataSource.TableName);
        }
    }
}