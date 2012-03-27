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
            this.settings1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settings3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settings5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settings4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settings2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel_00 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_00_10 = new System.Windows.Forms.TableLayoutPanel();
            this.functionChoosingControlPanel = new AnalysisSystem.Controls.FunctionChoosingControlPanel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.hfdCalculatingControlPanel = new AnalysisSystem.Controls.HfdCalculatingControlPanel();
            this.icaProcessingControlPanel = new AnalysisSystem.Controls.IcaProcessingControlPanel();
            this.sampleEliminatingControlPanel = new AnalysisSystem.Controls.SampleEliminatingControlPanel();
            this.edfConvertingControlPanel = new AnalysisSystem.Controls.EdfConvertingControlPanel();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel_00.SuspendLayout();
            this.tableLayoutPanel_00_10.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(1, 1);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip.Size = new System.Drawing.Size(913, 27);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings1ToolStripMenuItem,
            this.settings2ToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // settings1ToolStripMenuItem
            // 
            this.settings1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings3ToolStripMenuItem,
            this.settings4ToolStripMenuItem});
            this.settings1ToolStripMenuItem.Name = "settings1ToolStripMenuItem";
            this.settings1ToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.settings1ToolStripMenuItem.Text = "Settings1";
            // 
            // settings3ToolStripMenuItem
            // 
            this.settings3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings5ToolStripMenuItem});
            this.settings3ToolStripMenuItem.Name = "settings3ToolStripMenuItem";
            this.settings3ToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.settings3ToolStripMenuItem.Text = "Settings3";
            // 
            // settings5ToolStripMenuItem
            // 
            this.settings5ToolStripMenuItem.Name = "settings5ToolStripMenuItem";
            this.settings5ToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.settings5ToolStripMenuItem.Text = "Settings5";
            // 
            // settings4ToolStripMenuItem
            // 
            this.settings4ToolStripMenuItem.Name = "settings4ToolStripMenuItem";
            this.settings4ToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.settings4ToolStripMenuItem.Text = "Settings4";
            // 
            // settings2ToolStripMenuItem
            // 
            this.settings2ToolStripMenuItem.Name = "settings2ToolStripMenuItem";
            this.settings2ToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.settings2ToolStripMenuItem.Text = "Settings2";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(70, 27);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Location = new System.Drawing.Point(1, 572);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(913, 30);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status:";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLabel.TextChanged += new System.EventHandler(this.statusLabel_TextChanged);
            // 
            // tableLayoutPanel_00
            // 
            this.tableLayoutPanel_00.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_00.ColumnCount = 1;
            this.tableLayoutPanel_00.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00.Controls.Add(this.statusLabel, 0, 2);
            this.tableLayoutPanel_00.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel_00.Controls.Add(this.tableLayoutPanel_00_10, 0, 1);
            this.tableLayoutPanel_00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_00.Name = "tableLayoutPanel_00";
            this.tableLayoutPanel_00.RowCount = 3;
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_00.Size = new System.Drawing.Size(915, 603);
            this.tableLayoutPanel_00.TabIndex = 9;
            // 
            // tableLayoutPanel_00_10
            // 
            this.tableLayoutPanel_00_10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_00_10.ColumnCount = 2;
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00_10.Controls.Add(this.functionChoosingControlPanel, 0, 0);
            this.tableLayoutPanel_00_10.Controls.Add(this.mainPanel, 1, 0);
            this.tableLayoutPanel_00_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00_10.Location = new System.Drawing.Point(1, 29);
            this.tableLayoutPanel_00_10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_00_10.Name = "tableLayoutPanel_00_10";
            this.tableLayoutPanel_00_10.RowCount = 1;
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00_10.Size = new System.Drawing.Size(913, 542);
            this.tableLayoutPanel_00_10.TabIndex = 9;
            // 
            // functionChoosingControlPanel
            // 
            this.functionChoosingControlPanel.AnalysisSystemForm = null;
            this.functionChoosingControlPanel.CurrentPressedButton = null;
            this.functionChoosingControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.functionChoosingControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionChoosingControlPanel.Location = new System.Drawing.Point(6, 6);
            this.functionChoosingControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.functionChoosingControlPanel.Name = "functionChoosingControlPanel";
            this.functionChoosingControlPanel.Size = new System.Drawing.Size(205, 530);
            this.functionChoosingControlPanel.TabIndex = 5;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.hfdCalculatingControlPanel);
            this.mainPanel.Controls.Add(this.icaProcessingControlPanel);
            this.mainPanel.Controls.Add(this.sampleEliminatingControlPanel);
            this.mainPanel.Controls.Add(this.edfConvertingControlPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(217, 1);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(695, 540);
            this.mainPanel.TabIndex = 0;
            // 
            // hfdCalculatingControlPanel
            // 
            this.hfdCalculatingControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hfdCalculatingControlPanel.Location = new System.Drawing.Point(0, 0);
            this.hfdCalculatingControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.hfdCalculatingControlPanel.Name = "hfdCalculatingControlPanel";
            this.hfdCalculatingControlPanel.Size = new System.Drawing.Size(695, 540);
            this.hfdCalculatingControlPanel.TabIndex = 9;
            // 
            // icaProcessingControlPanel
            // 
            this.icaProcessingControlPanel.AnalysisSystemForm = null;
            this.icaProcessingControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icaProcessingControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icaProcessingControlPanel.Location = new System.Drawing.Point(0, 0);
            this.icaProcessingControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.icaProcessingControlPanel.Name = "icaProcessingControlPanel";
            this.icaProcessingControlPanel.Size = new System.Drawing.Size(695, 540);
            this.icaProcessingControlPanel.TabIndex = 8;
            this.icaProcessingControlPanel.Visible = false;
            // 
            // sampleEliminatingControlPanel
            // 
            this.sampleEliminatingControlPanel.AnalysisSystemForm = null;
            this.sampleEliminatingControlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.sampleEliminatingControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleEliminatingControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleEliminatingControlPanel.Location = new System.Drawing.Point(0, 0);
            this.sampleEliminatingControlPanel.Name = "sampleEliminatingControlPanel";
            this.sampleEliminatingControlPanel.Size = new System.Drawing.Size(695, 540);
            this.sampleEliminatingControlPanel.TabIndex = 7;
            this.sampleEliminatingControlPanel.Visible = false;
            // 
            // edfConvertingControlPanel
            // 
            this.edfConvertingControlPanel.AnalysisSystemForm = null;
            this.edfConvertingControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edfConvertingControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edfConvertingControlPanel.Location = new System.Drawing.Point(0, 0);
            this.edfConvertingControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.edfConvertingControlPanel.Name = "edfConvertingControlPanel";
            this.edfConvertingControlPanel.Size = new System.Drawing.Size(695, 540);
            this.edfConvertingControlPanel.TabIndex = 6;
            this.edfConvertingControlPanel.Visible = false;
            // 
            // AnalysisSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 603);
            this.Controls.Add(this.tableLayoutPanel_00);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AnalysisSystemForm";
            this.Text = "EEG Analysis System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel_00.ResumeLayout(false);
            this.tableLayoutPanel_00.PerformLayout();
            this.tableLayoutPanel_00_10.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Controls.FunctionChoosingControlPanel functionChoosingControlPanel;
        private Controls.EdfConvertingControlPanel edfConvertingControlPanel;
        private Controls.SampleEliminatingControlPanel sampleEliminatingControlPanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00_10;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem settings1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settings3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settings5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settings4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settings2ToolStripMenuItem;
        private Controls.IcaProcessingControlPanel icaProcessingControlPanel;
        private Controls.HfdCalculatingControlPanel hfdCalculatingControlPanel;
    }
}