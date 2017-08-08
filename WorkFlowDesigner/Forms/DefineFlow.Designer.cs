namespace WorkFlowDesigner
{
    partial class DefineFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineFlow));
            this.gcSteps = new DevExpress.XtraGrid.GridControl();
            this.stepBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_step = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStart_position_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnd_position_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStepConditionList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSteps
            // 
            this.gcSteps.DataSource = this.stepBindingSource1;
            this.gcSteps.Location = new System.Drawing.Point(489, 3);
            this.gcSteps.MainView = this.gridView1;
            this.gcSteps.Name = "gcSteps";
            this.gcSteps.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gcSteps.Size = new System.Drawing.Size(400, 200);
            this.gcSteps.TabIndex = 0;
            this.gcSteps.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stepBindingSource1
            // 
            this.stepBindingSource1.DataSource = typeof(WorkFlowDesigner.Step);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_step,
            this.colStart_position_id,
            this.colEnd_position_id,
            this.colDescription,
            this.colStepConditionList,
            this.gridColumn1});
            this.gridView1.GridControl = this.gcSteps;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId_step
            // 
            this.colId_step.FieldName = "Id_step";
            this.colId_step.Name = "colId_step";
            // 
            // colStart_position_id
            // 
            this.colStart_position_id.Caption = "Start position name";
            this.colStart_position_id.FieldName = "Start_position_id.Name";
            this.colStart_position_id.Name = "colStart_position_id";
            this.colStart_position_id.Visible = true;
            this.colStart_position_id.VisibleIndex = 0;
            // 
            // colEnd_position_id
            // 
            this.colEnd_position_id.Caption = "End position name";
            this.colEnd_position_id.FieldName = "End_position_id.Name";
            this.colEnd_position_id.Name = "colEnd_position_id";
            this.colEnd_position_id.Visible = true;
            this.colEnd_position_id.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colStepConditionList
            // 
            this.colStepConditionList.FieldName = "StepConditionList.Condition";
            this.colStepConditionList.Name = "colStepConditionList";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Add condition";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn1.Image")));
            this.gridColumn1.Name = "gridColumn1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // DefineFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 343);
            this.Controls.Add(this.gcSteps);
            this.Name = "DefineFlow";
            this.Text = "DefineFlow";
            ((System.ComponentModel.ISupportInitialize)(this.gcSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSteps;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId_step;
        private DevExpress.XtraGrid.Columns.GridColumn colStart_position_id;
        private DevExpress.XtraGrid.Columns.GridColumn colEnd_position_id;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colStepConditionList;
        private System.Windows.Forms.BindingSource stepBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}