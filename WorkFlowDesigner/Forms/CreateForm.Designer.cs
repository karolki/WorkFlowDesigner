namespace WorkFlowDesigner.Forms
{
    partial class CreateForm
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
            this.lcLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnAddAttribute = new System.Windows.Forms.Button();
            this.btnSaveFormToLayout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lcLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // lcLayout
            // 
            this.lcLayout.Dock = System.Windows.Forms.DockStyle.Right;
            this.lcLayout.Location = new System.Drawing.Point(103, 0);
            this.lcLayout.Name = "lcLayout";
            this.lcLayout.Root = this.layoutControlGroup1;
            this.lcLayout.Size = new System.Drawing.Size(719, 334);
            this.lcLayout.TabIndex = 0;
            this.lcLayout.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(719, 334);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(699, 314);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // bs
            // 
            this.bs.DataSource = typeof(WorkFlowDesigner.ListElement);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // btnAddAttribute
            // 
            this.btnAddAttribute.Location = new System.Drawing.Point(7, 10);
            this.btnAddAttribute.Name = "btnAddAttribute";
            this.btnAddAttribute.Size = new System.Drawing.Size(90, 23);
            this.btnAddAttribute.TabIndex = 1;
            this.btnAddAttribute.Text = "Add attribute";
            this.btnAddAttribute.UseVisualStyleBackColor = true;
            this.btnAddAttribute.Click += new System.EventHandler(this.btnAddTB_Click);
            // 
            // btnSaveFormToLayout
            // 
            this.btnSaveFormToLayout.Location = new System.Drawing.Point(22, 233);
            this.btnSaveFormToLayout.Name = "btnSaveFormToLayout";
            this.btnSaveFormToLayout.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFormToLayout.TabIndex = 4;
            this.btnSaveFormToLayout.Text = "Save to XML";
            this.btnSaveFormToLayout.UseVisualStyleBackColor = true;
            this.btnSaveFormToLayout.Click += new System.EventHandler(this.btnSaveFormToLayout_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 334);
            this.Controls.Add(this.btnSaveFormToLayout);
            this.Controls.Add(this.btnAddAttribute);
            this.Controls.Add(this.lcLayout);
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            ((System.ComponentModel.ISupportInitialize)(this.lcLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Button btnAddAttribute;
        private System.Windows.Forms.Button btnSaveFormToLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource bs;
    }
}