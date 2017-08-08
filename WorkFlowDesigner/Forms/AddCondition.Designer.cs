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
            this.cbAttributes = new System.Windows.Forms.ComboBox();
            this.attributeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCondition = new System.Windows.Forms.TextBox();
            this.btnAddCondition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.attributeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAttributes
            // 
            this.cbAttributes.DataSource = this.attributeBindingSource;
            this.cbAttributes.DisplayMember = "Name";
            this.cbAttributes.FormattingEnabled = true;
            this.cbAttributes.Location = new System.Drawing.Point(47, 44);
            this.cbAttributes.Name = "cbAttributes";
            this.cbAttributes.Size = new System.Drawing.Size(121, 21);
            this.cbAttributes.TabIndex = 0;
            this.cbAttributes.SelectedIndexChanged += new System.EventHandler(this.cbAttributes_SelectedIndexChanged);
            // 
            // attributeBindingSource
            // 
            this.attributeBindingSource.DataSource = typeof(WorkFlowDesigner.Attribute);
            // 
            // tbCondition
            // 
            this.tbCondition.Location = new System.Drawing.Point(223, 44);
            this.tbCondition.Name = "tbCondition";
            this.tbCondition.Size = new System.Drawing.Size(159, 21);
            this.tbCondition.TabIndex = 1;
            this.tbCondition.TextChanged += new System.EventHandler(this.tbCondition_TextChanged);
            // 
            // btnAddCondition
            // 
            this.btnAddCondition.Location = new System.Drawing.Point(47, 148);
            this.btnAddCondition.Name = "btnAddCondition";
            this.btnAddCondition.Size = new System.Drawing.Size(75, 23);
            this.btnAddCondition.TabIndex = 2;
            this.btnAddCondition.Text = "Add";
            this.btnAddCondition.UseVisualStyleBackColor = true;
            this.btnAddCondition.Click += new System.EventHandler(this.btnAddCondition_Click);
            // 
            // AddCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 235);
            this.Controls.Add(this.btnAddCondition);
            this.Controls.Add(this.tbCondition);
            this.Controls.Add(this.cbAttributes);
            this.Name = "AddCondition";
            this.Text = "AddCondition";
            ((System.ComponentModel.ISupportInitialize)(this.attributeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAttributes;
        private System.Windows.Forms.TextBox tbCondition;
        private System.Windows.Forms.Button btnAddCondition;
        private System.Windows.Forms.BindingSource attributeBindingSource;
    }
}