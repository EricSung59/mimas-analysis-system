namespace AnalysisSystem.Controls
{
    partial class EdfConvertingControlPanel
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel_00 = new System.Windows.Forms.TableLayoutPanel();
            this.choosingControlPanel = new AnalysisSystem.Controls.ChoosingControlPanel();
            this.tableLayoutPanel_00_10 = new System.Windows.Forms.TableLayoutPanel();
            this.outFolderChooserControlPanel = new AnalysisSystem.Controls.OutFolderChooserControlPanel();
            this.tableLayoutPanel_00.SuspendLayout();
            this.tableLayoutPanel_00_10.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.convertButton.AutoSize = true;
            this.convertButton.Location = new System.Drawing.Point(404, 51);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(136, 41);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "CONVERT";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
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
            this.tableLayoutPanel_00.Name = "tableLayoutPanel_00";
            this.tableLayoutPanel_00.RowCount = 2;
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_00.Size = new System.Drawing.Size(953, 509);
            this.tableLayoutPanel_00.TabIndex = 6;
            // 
            // choosingControlPanel
            // 
            this.choosingControlPanel.AnalysisSystemForm = null;
            this.choosingControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.choosingControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosingControlPanel.Location = new System.Drawing.Point(1, 1);
            this.choosingControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.choosingControlPanel.Name = "choosingControlPanel";
            this.choosingControlPanel.Size = new System.Drawing.Size(951, 404);
            this.choosingControlPanel.TabIndex = 1;
            // 
            // tableLayoutPanel_00_10
            // 
            this.tableLayoutPanel_00_10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_00_10.ColumnCount = 1;
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_00_10.Controls.Add(this.convertButton, 0, 1);
            this.tableLayoutPanel_00_10.Controls.Add(this.outFolderChooserControlPanel, 0, 0);
            this.tableLayoutPanel_00_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00_10.Location = new System.Drawing.Point(4, 409);
            this.tableLayoutPanel_00_10.Name = "tableLayoutPanel_00_10";
            this.tableLayoutPanel_00_10.RowCount = 2;
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_00_10.Size = new System.Drawing.Size(945, 96);
            this.tableLayoutPanel_00_10.TabIndex = 2;
            // 
            // outFolderChooserControlPanel
            // 
            this.outFolderChooserControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outFolderChooserControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outFolderChooserControlPanel.Location = new System.Drawing.Point(6, 6);
            this.outFolderChooserControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.outFolderChooserControlPanel.Name = "outFolderChooserControlPanel";
            this.outFolderChooserControlPanel.Size = new System.Drawing.Size(933, 36);
            this.outFolderChooserControlPanel.TabIndex = 3;
            // 
            // EdfConvertingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel_00);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EdfConvertingControlPanel";
            this.Size = new System.Drawing.Size(953, 509);
            this.tableLayoutPanel_00.ResumeLayout(false);
            this.tableLayoutPanel_00_10.ResumeLayout(false);
            this.tableLayoutPanel_00_10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ChoosingControlPanel choosingControlPanel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00_10;
        private OutFolderChooserControlPanel outFolderChooserControlPanel;

    }
}
