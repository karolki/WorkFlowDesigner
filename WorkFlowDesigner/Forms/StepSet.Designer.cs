namespace WorkFlowDesigner.Forms
{
    partial class StepSet
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
            this.cbStartPosition = new System.Windows.Forms.ComboBox();
            this.cbEndPosition = new System.Windows.Forms.ComboBox();
            this.btnSetStep = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stepViewBindingSource = new System.Windows.Forms.BindingSource();
            this.tbDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStartPosition
            // 
            this.cbStartPosition.FormattingEnabled = true;
            this.cbStartPosition.Location = new System.Drawing.Point(24, 12);
            this.cbStartPosition.Name = "cbStartPosition";
            this.cbStartPosition.Size = new System.Drawing.Size(121, 21);
            this.cbStartPosition.TabIndex = 0;
            // 
            // cbEndPosition
            // 
            this.cbEndPosition.FormattingEnabled = true;
            this.cbEndPosition.Location = new System.Drawing.Point(170, 12);
            this.cbEndPosition.Name = "cbEndPosition";
            this.cbEndPosition.Size = new System.Drawing.Size(121, 21);
            this.cbEndPosition.TabIndex = 1;
            // 
            // btnSetStep
            // 
            this.btnSetStep.Location = new System.Drawing.Point(425, 10);
            this.btnSetStep.Name = "btnSetStep";
            this.btnSetStep.Size = new System.Drawing.Size(75, 23);
            this.btnSetStep.TabIndex = 2;
            this.btnSetStep.Text = "Set";
            this.btnSetStep.UseVisualStyleBackColor = true;
            this.btnSetStep.Click += new System.EventHandler(this.btnSetStep_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stepViewBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(24, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // stepViewBindingSource
            // 
            this.stepViewBindingSource.DataSource = typeof(WorkFlowDesigner.StepView);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(315, 13);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 21);
            this.tbDescription.TabIndex = 4;
            this.tbDescription.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
            // 
            // StepSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 284);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnSetStep);
            this.Controls.Add(this.cbEndPosition);
            this.Controls.Add(this.cbStartPosition);
            this.Name = "StepSet";
            this.Text = "StepSet";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStartPosition;
        private System.Windows.Forms.ComboBox cbEndPosition;
        private System.Windows.Forms.Button btnSetStep;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource stepViewBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox tbDescription;
    }
}