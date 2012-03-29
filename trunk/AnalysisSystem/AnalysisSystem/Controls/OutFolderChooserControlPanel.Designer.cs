namespace AnalysisSystem.Controls
{
    partial class OutFolderChooserControlPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outFolderLabel = new System.Windows.Forms.Label();
            this.outFolderTextBox = new System.Windows.Forms.TextBox();
            this.outFolderBrowseButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // outFolderLabel
            // 
            this.outFolderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outFolderLabel.AutoSize = true;
            this.outFolderLabel.Location = new System.Drawing.Point(3, 16);
            this.outFolderLabel.Name = "outFolderLabel";
            this.outFolderLabel.Size = new System.Drawing.Size(117, 23);
            this.outFolderLabel.TabIndex = 0;
            this.outFolderLabel.Text = "Output Folder";
            // 
            // outFolderTextBox
            // 
            this.outFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outFolderTextBox.Location = new System.Drawing.Point(126, 12);
            this.outFolderTextBox.Name = "outFolderTextBox";
            this.outFolderTextBox.Size = new System.Drawing.Size(374, 30);
            this.outFolderTextBox.TabIndex = 1;
            // 
            // outFolderBrowseButton
            // 
            this.outFolderBrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.outFolderBrowseButton.AutoSize = true;
            this.outFolderBrowseButton.Location = new System.Drawing.Point(506, 11);
            this.outFolderBrowseButton.Name = "outFolderBrowseButton";
            this.outFolderBrowseButton.Size = new System.Drawing.Size(75, 33);
            this.outFolderBrowseButton.TabIndex = 2;
            this.outFolderBrowseButton.Text = "Browse";
            this.outFolderBrowseButton.UseVisualStyleBackColor = true;
            this.outFolderBrowseButton.Click += new System.EventHandler(this.outFolderBrowseButton_Click);
            // 
            // OutFolderChooserControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outFolderBrowseButton);
            this.Controls.Add(this.outFolderTextBox);
            this.Controls.Add(this.outFolderLabel);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "OutFolderChooserControlPanel";
            this.Size = new System.Drawing.Size(588, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outFolderLabel;
        private System.Windows.Forms.TextBox outFolderTextBox;
        private System.Windows.Forms.Button outFolderBrowseButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}
