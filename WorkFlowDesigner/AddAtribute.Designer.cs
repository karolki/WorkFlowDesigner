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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbAtributeName = new System.Windows.Forms.TextBox();
            this.cbeListAtribute = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbAtributeType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbeListAtribute.Properties)).BeginInit();
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
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbAtributeName
            // 
            this.tbAtributeName.Location = new System.Drawing.Point(40, 46);
            this.tbAtributeName.Name = "tbAtributeName";
            this.tbAtributeName.Size = new System.Drawing.Size(100, 21);
            this.tbAtributeName.TabIndex = 2;
            // 
            // cbeListAtribute
            // 
            this.cbeListAtribute.Location = new System.Drawing.Point(342, 47);
            this.cbeListAtribute.Name = "cbeListAtribute";
            this.cbeListAtribute.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeListAtribute.Size = new System.Drawing.Size(100, 20);
            this.cbeListAtribute.TabIndex = 3;
            // 
            // cbAtributeType
            // 
            this.cbAtributeType.FormattingEnabled = true;
            this.cbAtributeType.Items.AddRange(new object[] {
            "text",
            "int",
            "float",
            "checkbox",
            "list"});
            this.cbAtributeType.Location = new System.Drawing.Point(177, 46);
            this.cbAtributeType.Name = "cbAtributeType";
            this.cbAtributeType.Size = new System.Drawing.Size(121, 21);
            this.cbAtributeType.TabIndex = 4;
            // 
            // AddAtribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 188);
            this.Controls.Add(this.cbAtributeType);
            this.Controls.Add(this.cbeListAtribute);
            this.Controls.Add(this.tbAtributeName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddAtribute";
            this.Text = "AddAtribute";
            ((System.ComponentModel.ISupportInitialize)(this.cbeListAtribute.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbAtributeName;
        private DevExpress.XtraEditors.ComboBoxEdit cbeListAtribute;
        private System.Windows.Forms.ComboBox cbAtributeType;
    }
}