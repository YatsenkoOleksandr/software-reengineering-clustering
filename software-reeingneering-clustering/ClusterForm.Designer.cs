﻿namespace software_reeingneering_clustering
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
            this.clusterButton = new System.Windows.Forms.Button();
            this.openClassMethodsFile = new System.Windows.Forms.OpenFileDialog();
            this.saveResult = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // clusterButton
            // 
            this.clusterButton.Location = new System.Drawing.Point(540, 145);
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
            // ClusterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 180);
            this.Controls.Add(this.clusterButton);
            this.Name = "ClusterForm";
            this.Text = "Software Reengineering - Lab 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clusterButton;
        private System.Windows.Forms.OpenFileDialog openClassMethodsFile;
        private System.Windows.Forms.SaveFileDialog saveResult;
    }
}
