namespace AnalysisSystem.Controls
{
    partial class FunctionControlPanel
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
            this.convertingButton = new System.Windows.Forms.Button();
            this.eliminatingButton = new System.Windows.Forms.Button();
            this.icaProcessingButton = new System.Windows.Forms.Button();
            this.hfdCalculatingButton = new System.Windows.Forms.Button();
            this.emoMappingButton = new System.Windows.Forms.Button();
            this.svmTrainingButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertingButton
            // 
            this.convertingButton.AutoSize = true;
            this.convertingButton.Location = new System.Drawing.Point(15, 37);
            this.convertingButton.Name = "convertingButton";
            this.convertingButton.Size = new System.Drawing.Size(160, 33);
            this.convertingButton.TabIndex = 1;
            this.convertingButton.Text = "1. Converting";
            this.convertingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.convertingButton.UseVisualStyleBackColor = true;
            this.convertingButton.Click += new System.EventHandler(this.convertingButton_Click);
            // 
            // eliminatingButton
            // 
            this.eliminatingButton.AutoSize = true;
            this.eliminatingButton.Location = new System.Drawing.Point(15, 90);
            this.eliminatingButton.Name = "eliminatingButton";
            this.eliminatingButton.Size = new System.Drawing.Size(160, 33);
            this.eliminatingButton.TabIndex = 2;
            this.eliminatingButton.Text = "2. Eliminating";
            this.eliminatingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminatingButton.UseVisualStyleBackColor = true;
            this.eliminatingButton.Click += new System.EventHandler(this.eliminatingButton_Click);
            // 
            // icaProcessingButton
            // 
            this.icaProcessingButton.AutoSize = true;
            this.icaProcessingButton.Location = new System.Drawing.Point(15, 143);
            this.icaProcessingButton.Name = "icaProcessingButton";
            this.icaProcessingButton.Size = new System.Drawing.Size(160, 33);
            this.icaProcessingButton.TabIndex = 3;
            this.icaProcessingButton.Text = "3. ICA Processing";
            this.icaProcessingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icaProcessingButton.UseVisualStyleBackColor = true;
            // 
            // hfdCalculatingButton
            // 
            this.hfdCalculatingButton.AutoSize = true;
            this.hfdCalculatingButton.Location = new System.Drawing.Point(15, 196);
            this.hfdCalculatingButton.Name = "hfdCalculatingButton";
            this.hfdCalculatingButton.Size = new System.Drawing.Size(160, 33);
            this.hfdCalculatingButton.TabIndex = 4;
            this.hfdCalculatingButton.Text = "4. HFD Calculating";
            this.hfdCalculatingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hfdCalculatingButton.UseVisualStyleBackColor = true;
            // 
            // emoMappingButton
            // 
            this.emoMappingButton.AutoSize = true;
            this.emoMappingButton.Location = new System.Drawing.Point(15, 249);
            this.emoMappingButton.Name = "emoMappingButton";
            this.emoMappingButton.Size = new System.Drawing.Size(160, 33);
            this.emoMappingButton.TabIndex = 5;
            this.emoMappingButton.Text = "5. Emo Mapping";
            this.emoMappingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emoMappingButton.UseVisualStyleBackColor = true;
            // 
            // svmTrainingButton
            // 
            this.svmTrainingButton.AutoSize = true;
            this.svmTrainingButton.Location = new System.Drawing.Point(15, 302);
            this.svmTrainingButton.Name = "svmTrainingButton";
            this.svmTrainingButton.Size = new System.Drawing.Size(160, 33);
            this.svmTrainingButton.TabIndex = 6;
            this.svmTrainingButton.Text = "6. SVM Training";
            this.svmTrainingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.svmTrainingButton.UseVisualStyleBackColor = true;
            // 
            // testButton
            // 
            this.testButton.AutoSize = true;
            this.testButton.Location = new System.Drawing.Point(15, 355);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(160, 33);
            this.testButton.TabIndex = 7;
            this.testButton.Text = "7. Test";
            this.testButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.testButton);
            this.groupBox1.Controls.Add(this.convertingButton);
            this.groupBox1.Controls.Add(this.svmTrainingButton);
            this.groupBox1.Controls.Add(this.eliminatingButton);
            this.groupBox1.Controls.Add(this.emoMappingButton);
            this.groupBox1.Controls.Add(this.icaProcessingButton);
            this.groupBox1.Controls.Add(this.hfdCalculatingButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 406);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Function";
            // 
            // FunctionControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FunctionControlPanel";
            this.Size = new System.Drawing.Size(193, 406);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button convertingButton;
        private System.Windows.Forms.Button eliminatingButton;
        private System.Windows.Forms.Button icaProcessingButton;
        private System.Windows.Forms.Button hfdCalculatingButton;
        private System.Windows.Forms.Button emoMappingButton;
        private System.Windows.Forms.Button svmTrainingButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
