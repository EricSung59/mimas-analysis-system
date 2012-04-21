namespace AnalysisSystem.Forms
{
    partial class HfdCalculateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputFolderTextBox = new System.Windows.Forms.TextBox();
            this.outputFolderTextBox = new System.Windows.Forms.TextBox();
            this.inputFolderBrowseButton = new System.Windows.Forms.Button();
            this.outputFolderBrowseButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output folder";
            // 
            // inputFolderTextBox
            // 
            this.inputFolderTextBox.Location = new System.Drawing.Point(86, 6);
            this.inputFolderTextBox.Name = "inputFolderTextBox";
            this.inputFolderTextBox.Size = new System.Drawing.Size(355, 20);
            this.inputFolderTextBox.TabIndex = 2;
            this.inputFolderTextBox.Text = "D:\\ToanBK\\Desktop\\Test";
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.Location = new System.Drawing.Point(86, 39);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.Size = new System.Drawing.Size(355, 20);
            this.outputFolderTextBox.TabIndex = 3;
            this.outputFolderTextBox.Text = "D:\\ToanBK\\Desktop\\Test";
            // 
            // inputFolderBrowseButton
            // 
            this.inputFolderBrowseButton.Location = new System.Drawing.Point(447, 4);
            this.inputFolderBrowseButton.Name = "inputFolderBrowseButton";
            this.inputFolderBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.inputFolderBrowseButton.TabIndex = 4;
            this.inputFolderBrowseButton.Text = "Browse";
            this.inputFolderBrowseButton.UseVisualStyleBackColor = true;
            this.inputFolderBrowseButton.Click += new System.EventHandler(this.inputFolderBrowseButton_Click);
            // 
            // outputFolderBrowseButton
            // 
            this.outputFolderBrowseButton.Location = new System.Drawing.Point(447, 37);
            this.outputFolderBrowseButton.Name = "outputFolderBrowseButton";
            this.outputFolderBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.outputFolderBrowseButton.TabIndex = 5;
            this.outputFolderBrowseButton.Text = "Browse";
            this.outputFolderBrowseButton.UseVisualStyleBackColor = true;
            this.outputFolderBrowseButton.Click += new System.EventHandler(this.outputFolderBrowseButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(366, 90);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // HfdCalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 125);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputFolderBrowseButton);
            this.Controls.Add(this.inputFolderBrowseButton);
            this.Controls.Add(this.outputFolderTextBox);
            this.Controls.Add(this.inputFolderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HfdCalculateForm";
            this.Text = "CalculateHfdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputFolderTextBox;
        private System.Windows.Forms.TextBox outputFolderTextBox;
        private System.Windows.Forms.Button inputFolderBrowseButton;
        private System.Windows.Forms.Button outputFolderBrowseButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}