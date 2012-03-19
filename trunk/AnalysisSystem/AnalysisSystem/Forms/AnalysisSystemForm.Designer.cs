namespace AnalysisSystem.Forms
{
    partial class AnalysisSystemForm
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
            this.functionControlPanel = new AnalysisSystem.Controls.FunctionControlPanel();
            this.convertingControlPanel = new AnalysisSystem.Controls.ConvertingControlPanel();
            this.eliminatingControlPanel = new AnalysisSystem.Controls.EliminatingControlPanel();
            this.SuspendLayout();
            // 
            // functionControlPanel
            // 
            this.functionControlPanel.AnalysisSystemForm = null;
            this.functionControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.functionControlPanel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionControlPanel.Location = new System.Drawing.Point(0, 0);
            this.functionControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.functionControlPanel.Name = "functionsControlPanel";
            this.functionControlPanel.Size = new System.Drawing.Size(191, 403);
            this.functionControlPanel.TabIndex = 1;
            // 
            // convertingControlPanel
            // 
            this.convertingControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convertingControlPanel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertingControlPanel.Location = new System.Drawing.Point(191, 0);
            this.convertingControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.convertingControlPanel.Name = "convertingControlPanel";
            this.convertingControlPanel.Size = new System.Drawing.Size(376, 403);
            this.convertingControlPanel.TabIndex = 2;
            // 
            // eliminatingControlPanel
            // 
            this.eliminatingControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eliminatingControlPanel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminatingControlPanel.Location = new System.Drawing.Point(191, 0);
            this.eliminatingControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.eliminatingControlPanel.Name = "eliminatingControlPanel";
            this.eliminatingControlPanel.Size = new System.Drawing.Size(376, 403);
            this.eliminatingControlPanel.TabIndex = 3;
            // 
            // AnalysisSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 403);
            this.Controls.Add(this.eliminatingControlPanel);
            this.Controls.Add(this.convertingControlPanel);
            this.Controls.Add(this.functionControlPanel);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AnalysisSystemForm";
            this.Text = "EEG Analysis System";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.FunctionControlPanel functionControlPanel;
        private Controls.ConvertingControlPanel convertingControlPanel;
        private Controls.EliminatingControlPanel eliminatingControlPanel;
    }
}