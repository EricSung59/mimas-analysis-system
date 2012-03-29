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
            this.processButton = new System.Windows.Forms.Button();
            this.choosingControlPanel = new AnalysisSystem.Controls.ChoosingControlPanel();
            this.outFolderChooserControlPanel1 = new AnalysisSystem.Controls.OutFolderChooserControlPanel();
            this.tableLayoutPanel_00.SuspendLayout();
            this.tableLayoutPanel_00_10.SuspendLayout();
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
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_00.Size = new System.Drawing.Size(966, 549);
            this.tableLayoutPanel_00.TabIndex = 0;
            // 
            // tableLayoutPanel_00_10
            // 
            this.tableLayoutPanel_00_10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_00_10.ColumnCount = 1;
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00_10.Controls.Add(this.outFolderChooserControlPanel1, 0, 0);
            this.tableLayoutPanel_00_10.Controls.Add(this.processButton, 0, 1);
            this.tableLayoutPanel_00_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00_10.Location = new System.Drawing.Point(4, 441);
            this.tableLayoutPanel_00_10.Name = "tableLayoutPanel_00_10";
            this.tableLayoutPanel_00_10.RowCount = 2;
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_00_10.Size = new System.Drawing.Size(958, 104);
            this.tableLayoutPanel_00_10.TabIndex = 1;
            // 
            // processButton
            // 
            this.processButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.processButton.Location = new System.Drawing.Point(417, 55);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(123, 45);
            this.processButton.TabIndex = 1;
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
            this.choosingControlPanel.Size = new System.Drawing.Size(964, 436);
            this.choosingControlPanel.TabIndex = 0;
            // 
            // outFolderChooserControlPanel1
            // 
            this.outFolderChooserControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outFolderChooserControlPanel1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outFolderChooserControlPanel1.Location = new System.Drawing.Point(6, 6);
            this.outFolderChooserControlPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.outFolderChooserControlPanel1.Name = "outFolderChooserControlPanel1";
            this.outFolderChooserControlPanel1.Size = new System.Drawing.Size(946, 40);
            this.outFolderChooserControlPanel1.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00;
        private ChoosingControlPanel choosingControlPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00_10;
        private OutFolderChooserControlPanel outFolderChooserControlPanel1;
        private System.Windows.Forms.Button processButton;
    }
}
