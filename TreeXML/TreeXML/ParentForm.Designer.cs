namespace TreeXML
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewUISearch = new System.Windows.Forms.ToolStripButton();
            this.btnNewDataStructureSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTreeView
            // 
            this.mainTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainTreeView.Location = new System.Drawing.Point(0, 0);
            this.mainTreeView.Name = "mainTreeView";
            this.mainTreeView.Size = new System.Drawing.Size(329, 563);
            this.mainTreeView.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewUISearch,
            this.btnNewDataStructureSearch});
            this.toolStrip1.Location = new System.Drawing.Point(329, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(495, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewUISearch
            // 
            this.btnNewUISearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewUISearch.Image = ((System.Drawing.Image)(resources.GetObject("btnNewUISearch.Image")));
            this.btnNewUISearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewUISearch.Name = "btnNewUISearch";
            this.btnNewUISearch.Size = new System.Drawing.Size(23, 22);
            this.btnNewUISearch.Text = "toolStripButton1";
            this.btnNewUISearch.Click += new System.EventHandler(this.btnNewUISearch_Click);
            // 
            // btnNewDataStructureSearch
            // 
            this.btnNewDataStructureSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewDataStructureSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnNewDataStructureSearch.Image")));
            this.btnNewDataStructureSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewDataStructureSearch.Name = "btnNewDataStructureSearch";
            this.btnNewDataStructureSearch.Size = new System.Drawing.Size(23, 22);
            this.btnNewDataStructureSearch.Text = "toolStripButton1";
            this.btnNewDataStructureSearch.Click += new System.EventHandler(this.btnNewDataStructureSearch_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 563);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainTreeView);
            this.IsMdiContainer = true;
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewUISearch;
        private System.Windows.Forms.ToolStripButton btnNewDataStructureSearch;
    }
}