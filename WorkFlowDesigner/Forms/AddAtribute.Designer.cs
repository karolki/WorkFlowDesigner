namespace WorkFlowDesigner
{
    partial class AddAtribute
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbAtributeName = new System.Windows.Forms.TextBox();
            this.cbAtributeType = new System.Windows.Forms.ComboBox();
            this.btnAddListItem = new System.Windows.Forms.Button();
            this.gcListElements = new DevExpress.XtraGrid.GridControl();
            this.listElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvListElements = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_list_element = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcListElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listElementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(177, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbAtributeName
            // 
            this.tbAtributeName.Location = new System.Drawing.Point(40, 46);
            this.tbAtributeName.Name = "tbAtributeName";
            this.tbAtributeName.Size = new System.Drawing.Size(100, 21);
            this.tbAtributeName.TabIndex = 2;
            this.tbAtributeName.TextChanged += new System.EventHandler(this.tbAtributeName_TextChanged);
            // 
            // cbAtributeType
            // 
            this.cbAtributeType.FormattingEnabled = true;
            this.cbAtributeType.Items.AddRange(new object[] {
            "",
            "text",
            "int",
            "float",
            "checkbox",
            "list"});
            this.cbAtributeType.Location = new System.Drawing.Point(177, 46);
            this.cbAtributeType.Name = "cbAtributeType";
            this.cbAtributeType.Size = new System.Drawing.Size(121, 21);
            this.cbAtributeType.TabIndex = 4;
            this.cbAtributeType.SelectedIndexChanged += new System.EventHandler(this.cbAtributeType_SelectedIndexChanged);
            // 
            // btnAddListItem
            // 
            this.btnAddListItem.Location = new System.Drawing.Point(499, 43);
            this.btnAddListItem.Name = "btnAddListItem";
            this.btnAddListItem.Size = new System.Drawing.Size(23, 23);
            this.btnAddListItem.TabIndex = 5;
            this.btnAddListItem.Text = "+";
            this.btnAddListItem.UseVisualStyleBackColor = true;
            this.btnAddListItem.Click += new System.EventHandler(this.btnAddListItem_Click);
            // 
            // gcListElements
            // 
            this.gcListElements.DataSource = this.listElementBindingSource;
            this.gcListElements.Location = new System.Drawing.Point(304, 43);
            this.gcListElements.MainView = this.gvListElements;
            this.gcListElements.Name = "gcListElements";
            this.gcListElements.Size = new System.Drawing.Size(180, 130);
            this.gcListElements.TabIndex = 6;
            this.gcListElements.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListElements});
            // 
            // listElementBindingSource
            // 
            this.listElementBindingSource.DataSource = typeof(WorkFlowDesigner.ListElement);
            // 
            // gvListElements
            // 
            this.gvListElements.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_list_element,
            this.colName});
            this.gvListElements.GridControl = this.gcListElements;
            this.gvListElements.Name = "gvListElements";
            this.gvListElements.OptionsView.ShowGroupPanel = false;
            // 
            // colId_list_element
            // 
            this.colId_list_element.FieldName = "Id_list_element";
            this.colId_list_element.Name = "colId_list_element";
            this.colId_list_element.OptionsColumn.AllowEdit = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // AddAtribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 188);
            this.Controls.Add(this.gcListElements);
            this.Controls.Add(this.btnAddListItem);
            this.Controls.Add(this.cbAtributeType);
            this.Controls.Add(this.tbAtributeName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddAtribute";
            this.Text = "AddAtribute";
            ((System.ComponentModel.ISupportInitialize)(this.gcListElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listElementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbAtributeName;
        private System.Windows.Forms.ComboBox cbAtributeType;
        Attribute atribute;
        private System.Windows.Forms.Button btnAddListItem;
        private DevExpress.XtraGrid.GridControl gcListElements;
        private System.Windows.Forms.BindingSource listElementBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListElements;
        private DevExpress.XtraGrid.Columns.GridColumn colId_list_element;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}