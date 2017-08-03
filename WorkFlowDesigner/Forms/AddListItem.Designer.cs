namespace WorkFlowDesigner
{
    partial class AddListItem
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
            this.tbListItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddListItem = new System.Windows.Forms.Button();
            this.btnCancelAddListItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbListItemName
            // 
            this.tbListItemName.Location = new System.Drawing.Point(104, 38);
            this.tbListItemName.Name = "tbListItemName";
            this.tbListItemName.Size = new System.Drawing.Size(100, 21);
            this.tbListItemName.TabIndex = 0;
            this.tbListItemName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List item name:";
            // 
            // btnAddListItem
            // 
            this.btnAddListItem.Location = new System.Drawing.Point(23, 73);
            this.btnAddListItem.Name = "btnAddListItem";
            this.btnAddListItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddListItem.TabIndex = 2;
            this.btnAddListItem.Text = "Add";
            this.btnAddListItem.UseVisualStyleBackColor = true;
            this.btnAddListItem.Click += new System.EventHandler(this.btnAddListItem_Click);
            // 
            // btnCancelAddListItem
            // 
            this.btnCancelAddListItem.Location = new System.Drawing.Point(129, 73);
            this.btnCancelAddListItem.Name = "btnCancelAddListItem";
            this.btnCancelAddListItem.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddListItem.TabIndex = 3;
            this.btnCancelAddListItem.Text = "Cancel";
            this.btnCancelAddListItem.UseVisualStyleBackColor = true;
            this.btnCancelAddListItem.Click += new System.EventHandler(this.btnCancelAddListItem_Click);
            // 
            // AddListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 117);
            this.Controls.Add(this.btnCancelAddListItem);
            this.Controls.Add(this.btnAddListItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbListItemName);
            this.Name = "AddListItem";
            this.Text = "AddListItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbListItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddListItem;
        private System.Windows.Forms.Button btnCancelAddListItem;
    }
}