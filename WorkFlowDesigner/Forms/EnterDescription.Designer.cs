namespace WorkFlowDesigner.Forms
{
    partial class EnterDescription
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
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDesc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(166, 26);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(132, 53);
            this.tbDescription.TabIndex = 0;
            this.tbDescription.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter description to the step:";
            // 
            // btnAddDesc
            // 
            this.btnAddDesc.Location = new System.Drawing.Point(102, 86);
            this.btnAddDesc.Name = "btnAddDesc";
            this.btnAddDesc.Size = new System.Drawing.Size(75, 23);
            this.btnAddDesc.TabIndex = 2;
            this.btnAddDesc.Text = "OK";
            this.btnAddDesc.UseVisualStyleBackColor = true;
            this.btnAddDesc.Click += new System.EventHandler(this.btnAddDesc_Click);
            // 
            // EnterDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 121);
            this.Controls.Add(this.btnAddDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.Name = "EnterDescription";
            this.Text = "EnterDescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDesc;
    }
}