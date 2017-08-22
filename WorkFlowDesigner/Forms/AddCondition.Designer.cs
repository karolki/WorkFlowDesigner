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
            this.lcLayout = new DevExpress.XtraLayout.LayoutControl();
            this.lc = new DevExpress.XtraLayout.LayoutControlGroup();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLogic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lcLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).BeginInit();
            this.SuspendLayout();
            // 
            // lcLayout
            // 
            this.lcLayout.AllowCustomization = false;
            this.lcLayout.Location = new System.Drawing.Point(14, 32);
            this.lcLayout.Name = "lcLayout";
            this.lcLayout.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.lcLayout.Root = this.lc;
            this.lcLayout.Size = new System.Drawing.Size(295, 216);
            this.lcLayout.TabIndex = 0;
            this.lcLayout.Text = "layoutControl1";
            // 
            // lc
            // 
            this.lc.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lc.GroupBordersVisible = false;
            this.lc.Location = new System.Drawing.Point(0, 0);
            this.lc.Name = "lc";
            this.lc.Size = new System.Drawing.Size(295, 216);
            this.lc.TextVisible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Attribute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Operator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Condition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Logic";
            // 
            // tbLogic
            // 
            this.tbLogic.Location = new System.Drawing.Point(12, 7);
            this.tbLogic.Name = "tbLogic";
            this.tbLogic.Size = new System.Drawing.Size(22, 21);
            this.tbLogic.TabIndex = 6;
            this.tbLogic.Visible = false;
            // 
            // AddCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 238);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLogic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lcLayout);
            this.Name = "AddCondition";
            this.Text = "AddCondition";
            ((System.ComponentModel.ISupportInitialize)(this.lcLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcLayout;
        private DevExpress.XtraLayout.LayoutControlGroup lc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLogic;
    }
}