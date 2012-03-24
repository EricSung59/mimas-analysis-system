namespace AnalysisSystem.Controls
{
    partial class ConvertingControlPanel
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
            this.convertButton = new System.Windows.Forms.Button();
            this.outFolderLabel = new System.Windows.Forms.Label();
            this.outFolderTextBox = new System.Windows.Forms.TextBox();
            this.outFolderBrowseButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.choosingControlPanel = new AnalysisSystem.Controls.ChoosingControlPanel();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.convertButton.AutoSize = true;
            this.convertButton.Location = new System.Drawing.Point(314, 516);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(136, 52);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "CONVERT";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outFolderLabel
            // 
            this.outFolderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outFolderLabel.AutoSize = true;
            this.outFolderLabel.Location = new System.Drawing.Point(3, 470);
            this.outFolderLabel.Name = "outFolderLabel";
            this.outFolderLabel.Size = new System.Drawing.Size(91, 23);
            this.outFolderLabel.TabIndex = 3;
            this.outFolderLabel.Text = "Out Folder";
            // 
            // outFolderTextBox
            // 
            this.outFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outFolderTextBox.Location = new System.Drawing.Point(100, 466);
            this.outFolderTextBox.Name = "outFolderTextBox";
            this.outFolderTextBox.Size = new System.Drawing.Size(581, 30);
            this.outFolderTextBox.TabIndex = 4;
            // 
            // outFolderBrowseButton
            // 
            this.outFolderBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outFolderBrowseButton.AutoSize = true;
            this.outFolderBrowseButton.Location = new System.Drawing.Point(687, 465);
            this.outFolderBrowseButton.Name = "outFolderBrowseButton";
            this.outFolderBrowseButton.Size = new System.Drawing.Size(75, 33);
            this.outFolderBrowseButton.TabIndex = 5;
            this.outFolderBrowseButton.Text = "Browse";
            this.outFolderBrowseButton.UseVisualStyleBackColor = true;
            this.outFolderBrowseButton.Click += new System.EventHandler(this.outFolderBrowseButton_Click);
            // 
            // choosingControlPanel
            // 
            this.choosingControlPanel.AnalysisSystemForm = null;
            this.choosingControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choosingControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choosingControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosingControlPanel.Location = new System.Drawing.Point(-1, -1);
            this.choosingControlPanel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.choosingControlPanel.Name = "choosingControlPanel";
            this.choosingControlPanel.Size = new System.Drawing.Size(765, 444);
            this.choosingControlPanel.TabIndex = 1;
            // 
            // ConvertingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.outFolderBrowseButton);
            this.Controls.Add(this.outFolderTextBox);
            this.Controls.Add(this.outFolderLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.choosingControlPanel);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ConvertingControlPanel";
            this.Size = new System.Drawing.Size(765, 583);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChoosingControlPanel choosingControlPanel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outFolderLabel;
        private System.Windows.Forms.TextBox outFolderTextBox;
        private System.Windows.Forms.Button outFolderBrowseButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;

    }
}
