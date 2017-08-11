namespace WorkFlowDesigner.Forms
{
    partial class AddCondition
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bsAtributeList = new System.Windows.Forms.BindingSource(this.components);
            this.stepConditionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Position = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAtributeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepConditionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.operatorDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.dgv.DataSource = this.stepConditionsBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(547, 150);
            this.dgv.TabIndex = 0;
            // 
            // bsAtributeList
            // 
            this.bsAtributeList.DataSource = typeof(WorkFlowDesigner.Attributes);
            // 
            // stepConditionsBindingSource
            // 
            this.stepConditionsBindingSource.DataSource = typeof(WorkFlowDesigner.StepConditions);
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position.Name";
            this.Position.DataSource = this.bsAtributeList;
            this.Position.DisplayMember = "Name";
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ValueMember = "Name";
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "Operator";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.operatorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Condition";
            this.dataGridViewTextBoxColumn3.HeaderText = "Condition";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // AddCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 336);
            this.Controls.Add(this.dgv);
            this.Name = "AddCondition";
            this.Text = "AddCondition";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAtributeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepConditionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstepconditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stepConditionsBindingSource;
        private System.Windows.Forms.BindingSource bsAtributeList;
        private System.Windows.Forms.DataGridViewComboBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Position;
        private System.Windows.Forms.DataGridViewComboBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}