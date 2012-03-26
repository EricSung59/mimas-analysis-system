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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLabel = new System.Windows.Forms.Label();
            this.functionControlPanel = new AnalysisSystem.Controls.FunctionControlPanel();
            this.convertingControlPanel = new AnalysisSystem.Controls.ConvertingControlPanel();
            this.eliminatingControlPanel = new AnalysisSystem.Controls.EliminatingControlPanel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(975, 34);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(89, 30);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(77, 30);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Location = new System.Drawing.Point(0, 675);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(975, 28);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status:";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLabel.TextChanged += new System.EventHandler(this.statusLabel_TextChanged);
            // 
            // functionControlPanel
            // 
            this.functionControlPanel.AnalysisSystemForm = null;
            this.functionControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.functionControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.functionControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionControlPanel.Location = new System.Drawing.Point(0, 34);
            this.functionControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.functionControlPanel.Name = "functionControlPanel";
            this.functionControlPanel.Size = new System.Drawing.Size(185, 641);
            this.functionControlPanel.TabIndex = 5;
            // 
            // convertingControlPanel
            // 
            this.convertingControlPanel.AnalysisSystemForm = null;
            this.convertingControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertingControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertingControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertingControlPanel.Location = new System.Drawing.Point(185, 34);
            this.convertingControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.convertingControlPanel.Name = "convertingControlPanel";
            this.convertingControlPanel.Size = new System.Drawing.Size(790, 641);
            this.convertingControlPanel.TabIndex = 6;
            // 
            // eliminatingControlPanel
            // 
            this.eliminatingControlPanel.AnalysisSystemForm = null;
            this.eliminatingControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminatingControlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.eliminatingControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eliminatingControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminatingControlPanel.Location = new System.Drawing.Point(185, 34);
            this.eliminatingControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.eliminatingControlPanel.Name = "eliminatingControlPanel";
            this.eliminatingControlPanel.Size = new System.Drawing.Size(790, 641);
            this.eliminatingControlPanel.TabIndex = 7;
            // 
            // AnalysisSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 703);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.functionControlPanel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.convertingControlPanel);
            this.Controls.Add(this.eliminatingControlPanel);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AnalysisSystemForm";
            this.Text = "EEG Analysis System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Controls.FunctionControlPanel functionControlPanel;
        private Controls.ConvertingControlPanel convertingControlPanel;
        private Controls.EliminatingControlPanel eliminatingControlPanel;
        private System.Windows.Forms.Label statusLabel;
    }
}