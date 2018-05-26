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
            this.SuspendLayout();
            // 
            // clusterButton
            // 
            this.clusterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clusterButton.Location = new System.Drawing.Point(625, 551);
            this.clusterButton.Name = "clusterButton";
            this.clusterButton.Size = new System.Drawing.Size(75, 23);
            this.clusterButton.TabIndex = 0;
            this.clusterButton.Text = "Clusterize";
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
            this.trvResultTree.Size = new System.Drawing.Size(278, 562);
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
            // ClusterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 586);
            this.Controls.Add(this.trvResultTree);
            this.Controls.Add(this.clusterButton);
            this.Name = "ClusterForm";
            this.Text = "Software Reengineering - Lab 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clusterButton;
        private System.Windows.Forms.OpenFileDialog openClassMethodsFile;
        private System.Windows.Forms.SaveFileDialog saveResult;
        private System.Windows.Forms.TreeView trvResultTree;
        private System.Windows.Forms.ImageList imageList1;
    }
}

