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
            this.choosingControlPanel = new AnalysisSystem.Controls.ChoosingControlPanel();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.convertButton.AutoSize = true;
            this.convertButton.Location = new System.Drawing.Point(314, 563);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(136, 52);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "CONVERT";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // choosingControlPanel
            // 
            this.choosingControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choosingControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.choosingControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosingControlPanel.Location = new System.Drawing.Point(0, 0);
            this.choosingControlPanel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.choosingControlPanel.Name = "choosingControlPanel";
            this.choosingControlPanel.Size = new System.Drawing.Size(765, 544);
            this.choosingControlPanel.TabIndex = 1;
            // 
            // ConvertingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.choosingControlPanel);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ConvertingControlPanel";
            this.Size = new System.Drawing.Size(765, 627);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChoosingControlPanel choosingControlPanel;
        private System.Windows.Forms.Button convertButton;

    }
}
