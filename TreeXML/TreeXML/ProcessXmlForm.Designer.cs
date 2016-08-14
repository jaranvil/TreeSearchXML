namespace TreeXML
{
    partial class ProcessXmlForm
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
            this.pbLoadingProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btrnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pbLoadingProgress
            // 
            this.pbLoadingProgress.Location = new System.Drawing.Point(12, 25);
            this.pbLoadingProgress.Name = "pbLoadingProgress";
            this.pbLoadingProgress.Size = new System.Drawing.Size(581, 23);
            this.pbLoadingProgress.TabIndex = 0;
            this.pbLoadingProgress.Value = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loading XML ...";
            // 
            // btrnCancel
            // 
            this.btrnCancel.Location = new System.Drawing.Point(518, 54);
            this.btrnCancel.Name = "btrnCancel";
            this.btrnCancel.Size = new System.Drawing.Size(75, 23);
            this.btrnCancel.TabIndex = 2;
            this.btrnCancel.Text = "Cancel";
            this.btrnCancel.UseVisualStyleBackColor = true;
            this.btrnCancel.Click += new System.EventHandler(this.btrnCancel_Click);
            // 
            // ProcessXmlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 89);
            this.Controls.Add(this.btrnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLoadingProgress);
            this.Name = "ProcessXmlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcessXml";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbLoadingProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btrnCancel;
    }
}