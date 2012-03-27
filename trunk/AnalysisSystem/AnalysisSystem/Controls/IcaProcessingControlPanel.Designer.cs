namespace AnalysisSystem.Controls
{
    partial class IcaProcessingControlPanel
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
            this.tableLayoutPanel_00 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_00_10 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outFolderLabel = new System.Windows.Forms.Label();
            this.outFolderTextBox = new System.Windows.Forms.TextBox();
            this.outFolderBrowseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.processButton = new System.Windows.Forms.Button();
            this.choosingControlPanel = new AnalysisSystem.Controls.ChoosingControlPanel();
            this.tableLayoutPanel_00.SuspendLayout();
            this.tableLayoutPanel_00_10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_00
            // 
            this.tableLayoutPanel_00.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_00.ColumnCount = 1;
            this.tableLayoutPanel_00.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00.Controls.Add(this.choosingControlPanel, 0, 0);
            this.tableLayoutPanel_00.Controls.Add(this.tableLayoutPanel_00_10, 0, 1);
            this.tableLayoutPanel_00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_00.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel_00.Name = "tableLayoutPanel_00";
            this.tableLayoutPanel_00.RowCount = 2;
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel_00.Size = new System.Drawing.Size(966, 549);
            this.tableLayoutPanel_00.TabIndex = 0;
            // 
            // tableLayoutPanel_00_10
            // 
            this.tableLayoutPanel_00_10.ColumnCount = 1;
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00_10.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel_00_10.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel_00_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00_10.Location = new System.Drawing.Point(6, 393);
            this.tableLayoutPanel_00_10.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel_00_10.Name = "tableLayoutPanel_00_10";
            this.tableLayoutPanel_00_10.RowCount = 2;
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_00_10.Size = new System.Drawing.Size(954, 150);
            this.tableLayoutPanel_00_10.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.outFolderBrowseButton);
            this.panel1.Controls.Add(this.outFolderTextBox);
            this.panel1.Controls.Add(this.outFolderLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 45);
            this.panel1.TabIndex = 0;
            // 
            // outFolderLabel
            // 
            this.outFolderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outFolderLabel.AutoSize = true;
            this.outFolderLabel.Location = new System.Drawing.Point(3, 11);
            this.outFolderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.outFolderLabel.Name = "outFolderLabel";
            this.outFolderLabel.Size = new System.Drawing.Size(91, 23);
            this.outFolderLabel.TabIndex = 0;
            this.outFolderLabel.Text = "Out Folder";
            // 
            // outFolderTextBox
            // 
            this.outFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outFolderTextBox.Location = new System.Drawing.Point(94, 7);
            this.outFolderTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.outFolderTextBox.Name = "outFolderTextBox";
            this.outFolderTextBox.Size = new System.Drawing.Size(779, 30);
            this.outFolderTextBox.TabIndex = 1;
            // 
            // outFolderBrowseButton
            // 
            this.outFolderBrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.outFolderBrowseButton.AutoSize = true;
            this.outFolderBrowseButton.Location = new System.Drawing.Point(879, 6);
            this.outFolderBrowseButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.outFolderBrowseButton.Name = "outFolderBrowseButton";
            this.outFolderBrowseButton.Size = new System.Drawing.Size(75, 33);
            this.outFolderBrowseButton.TabIndex = 2;
            this.outFolderBrowseButton.Text = "Browse";
            this.outFolderBrowseButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.processButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 99);
            this.panel2.TabIndex = 1;
            // 
            // processButton
            // 
            this.processButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.processButton.Location = new System.Drawing.Point(413, 21);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(123, 57);
            this.processButton.TabIndex = 0;
            this.processButton.Text = "PROCESS";
            this.processButton.UseVisualStyleBackColor = true;
            // 
            // choosingControlPanel
            // 
            this.choosingControlPanel.AnalysisSystemForm = null;
            this.choosingControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.choosingControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosingControlPanel.Location = new System.Drawing.Point(1, 1);
            this.choosingControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.choosingControlPanel.Name = "choosingControlPanel";
            this.choosingControlPanel.Size = new System.Drawing.Size(964, 386);
            this.choosingControlPanel.TabIndex = 0;
            // 
            // IcaProcessingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel_00);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "IcaProcessingControlPanel";
            this.Size = new System.Drawing.Size(966, 549);
            this.tableLayoutPanel_00.ResumeLayout(false);
            this.tableLayoutPanel_00_10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00;
        private ChoosingControlPanel choosingControlPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00_10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button outFolderBrowseButton;
        private System.Windows.Forms.TextBox outFolderTextBox;
        private System.Windows.Forms.Label outFolderLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button processButton;
    }
}
