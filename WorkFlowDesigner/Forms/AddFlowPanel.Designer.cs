namespace WorkFlowDesigner
{
    partial class AddFlowPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcAtribute = new DevExpress.XtraGrid.GridControl();
            this.bsAttribute = new System.Windows.Forms.BindingSource(this.components);
            this.gvAtribute = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_attribute = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_workflow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcName = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.bsPosition = new System.Windows.Forms.BindingSource(this.components);
            this.gcPosition = new DevExpress.XtraGrid.GridControl();
            this.gvPosition = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colId_position = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_flow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAtribute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAttribute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAtribute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.button1);
            this.layoutControl1.Controls.Add(this.gcPosition);
            this.layoutControl1.Controls.Add(this.gcAtribute);
            this.layoutControl1.Controls.Add(this.btnAddPosition);
            this.layoutControl1.Controls.Add(this.tbName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(471, 65, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(895, 340);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcAtribute
            // 
            this.gcAtribute.DataSource = this.bsAttribute;
            this.gcAtribute.Location = new System.Drawing.Point(449, 36);
            this.gcAtribute.MainView = this.gvAtribute;
            this.gcAtribute.Name = "gcAtribute";
            this.gcAtribute.Size = new System.Drawing.Size(434, 141);
            this.gcAtribute.TabIndex = 4;
            this.gcAtribute.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAtribute});
            // 
            // bsAttribute
            // 
            this.bsAttribute.DataSource = typeof(WorkFlowDesigner.Position);
            // 
            // gvAtribute
            // 
            this.gvAtribute.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_attribute,
            this.colId_workflow,
            this.colName,
            this.colType});
            this.gvAtribute.GridControl = this.gcAtribute;
            this.gvAtribute.Name = "gvAtribute";
            this.gvAtribute.OptionsView.ShowGroupPanel = false;
            // 
            // colId_attribute
            // 
            this.colId_attribute.FieldName = "Id_attribute";
            this.colId_attribute.Name = "colId_attribute";
            this.colId_attribute.OptionsColumn.AllowEdit = false;
            // 
            // colId_workflow
            // 
            this.colId_workflow.FieldName = "Id_workflow";
            this.colId_workflow.Name = "colId_workflow";
            this.colId_workflow.OptionsColumn.AllowEdit = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsEditForm.UseEditorColRowSpan = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.AllowEdit = false;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 1;
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Location = new System.Drawing.Point(12, 70);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(142, 20);
            this.btnAddPosition.TabIndex = 1;
            this.btnAddPosition.Text = "Add Position";
            this.btnAddPosition.UseVisualStyleBackColor = true;
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddAtribute_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(71, 36);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(83, 20);
            this.tbName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.emptySpaceItem5,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem4,
            this.emptySpaceItem6,
            this.layoutControlItem3,
            this.emptySpaceItem3,
            this.layoutControlItem4,
            this.emptySpaceItem7,
            this.layoutControlItem1,
            this.lcName,
            this.emptySpaceItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(895, 340);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcName
            // 
            this.lcName.Control = this.tbName;
            this.lcName.Location = new System.Drawing.Point(0, 24);
            this.lcName.Name = "lcName";
            this.lcName.Size = new System.Drawing.Size(146, 24);
            this.lcName.Text = "Flow Name:";
            this.lcName.TextSize = new System.Drawing.Size(56, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(437, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAddPosition;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(146, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(437, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(261, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(156, 24);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(225, 58);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(437, 169);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(438, 151);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(381, 24);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(56, 296);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcAtribute;
            this.layoutControlItem2.Location = new System.Drawing.Point(437, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(438, 145);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 82);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(10, 238);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // bsPosition
            // 
            this.bsPosition.DataSource = typeof(WorkFlowDesigner.Position);
            // 
            // gcPosition
            // 
            this.gcPosition.DataSource = this.bsPosition;
            this.gcPosition.Location = new System.Drawing.Point(22, 94);
            this.gcPosition.MainView = this.gvPosition;
            this.gcPosition.Name = "gcPosition";
            this.gcPosition.Size = new System.Drawing.Size(367, 234);
            this.gcPosition.TabIndex = 5;
            this.gcPosition.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPosition});
            // 
            // gvPosition
            // 
            this.gvPosition.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_position,
            this.colId_flow,
            this.colName1});
            this.gvPosition.GridControl = this.gcPosition;
            this.gvPosition.Name = "gvPosition";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gcPosition;
            this.layoutControlItem3.Location = new System.Drawing.Point(10, 82);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(371, 238);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // colId_position
            // 
            this.colId_position.FieldName = "Id_position";
            this.colId_position.Name = "colId_position";
            // 
            // colId_flow
            // 
            this.colId_flow.FieldName = "Id_flow";
            this.colId_flow.Name = "colId_flow";
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.OptionsColumn.AllowEdit = false;
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Atribute";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.button1;
            this.layoutControlItem4.Location = new System.Drawing.Point(698, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(177, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(146, 24);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(10, 58);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(146, 10);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // AddFlowPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 340);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddFlowPanel";
            this.Text = "AddFlowPanel";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAtribute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAttribute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAtribute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.TextBox tbName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lcName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraGrid.GridControl gcAtribute;
        private System.Windows.Forms.BindingSource bsAttribute;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAtribute;
        private DevExpress.XtraGrid.Columns.GridColumn colId_attribute;
        private DevExpress.XtraGrid.Columns.GridColumn colId_workflow;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        Attribute atribute;
        Flow flow;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl gcPosition;
        private System.Windows.Forms.BindingSource bsPosition;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colId_position;
        private DevExpress.XtraGrid.Columns.GridColumn colId_flow;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
    }
}