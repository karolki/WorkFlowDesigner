namespace WorkFlowDesigner.Forms
{
    partial class AddPosition
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
            this.tbPositionName = new System.Windows.Forms.TextBox();
            this.btnConfirmAddPosition = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPositionName
            // 
            this.tbPositionName.Location = new System.Drawing.Point(32, 36);
            this.tbPositionName.Name = "tbPositionName";
            this.tbPositionName.Size = new System.Drawing.Size(100, 21);
            this.tbPositionName.TabIndex = 0;
            this.tbPositionName.TextChanged += new System.EventHandler(this.tbPositionName_TextChanged);
            // 
            // btnConfirmAddPosition
            // 
            this.btnConfirmAddPosition.Location = new System.Drawing.Point(32, 102);
            this.btnConfirmAddPosition.Name = "btnConfirmAddPosition";
            this.btnConfirmAddPosition.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAddPosition.TabIndex = 1;
            this.btnConfirmAddPosition.Text = "Add";
            this.btnConfirmAddPosition.UseVisualStyleBackColor = true;
            this.btnConfirmAddPosition.Click += new System.EventHandler(this.btnConfirmAddPosition_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 193);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConfirmAddPosition);
            this.Controls.Add(this.tbPositionName);
            this.Name = "AddPosition";
            this.Text = "AddPosition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPositionName;
        private System.Windows.Forms.Button btnConfirmAddPosition;
        private System.Windows.Forms.Button button2;
    }
}