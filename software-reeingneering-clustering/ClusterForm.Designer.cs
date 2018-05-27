namespace software_reeingneering_clustering
{
    partial class ClusterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClusterForm));
            this.clusterButton = new System.Windows.Forms.Button();
            this.openClassMethodsFile = new System.Windows.Forms.OpenFileDialog();
            this.saveResult = new System.Windows.Forms.SaveFileDialog();
            this.trvResultTree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // clusterButton
            // 
            this.clusterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clusterButton.Location = new System.Drawing.Point(603, 543);
            this.clusterButton.Name = "clusterButton";
            this.clusterButton.Size = new System.Drawing.Size(120, 25);
            this.clusterButton.TabIndex = 0;
            this.clusterButton.Text = "Hierarchical Clustering";
            this.clusterButton.UseVisualStyleBackColor = true;
            this.clusterButton.Click += new System.EventHandler(this.clusterButton_Click);
            // 
            // openClassMethodsFile
            // 
            this.openClassMethodsFile.FileName = "openFileDialog1";
            // 
            // trvResultTree
            // 
            this.trvResultTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trvResultTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trvResultTree.ImageIndex = 0;
            this.trvResultTree.ImageList = this.imageList1;
            this.trvResultTree.Location = new System.Drawing.Point(12, 12);
            this.trvResultTree.Name = "trvResultTree";
            this.trvResultTree.SelectedImageIndex = 0;
            this.trvResultTree.Size = new System.Drawing.Size(711, 525);
            this.trvResultTree.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "class.png");
            this.imageList1.Images.SetKeyName(1, "function.png");
            this.imageList1.Images.SetKeyName(2, "Folder.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of clusters:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "K-Means Clustering";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(153, 577);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ClusterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 605);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trvResultTree);
            this.Controls.Add(this.clusterButton);
            this.Name = "ClusterForm";
            this.Text = "Software Reengineering - Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clusterButton;
        private System.Windows.Forms.OpenFileDialog openClassMethodsFile;
        private System.Windows.Forms.SaveFileDialog saveResult;
        private System.Windows.Forms.TreeView trvResultTree;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

