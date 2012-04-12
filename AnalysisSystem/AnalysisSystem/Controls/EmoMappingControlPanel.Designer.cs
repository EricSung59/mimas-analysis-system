namespace AnalysisSystem.Controls
{
    partial class EmoMappingControlPanel
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
            this.EmoQuantityLabel = new System.Windows.Forms.Label();
            this.rowCountComboBox = new System.Windows.Forms.ComboBox();
            this.columnCountComboBox = new System.Windows.Forms.ComboBox();
            this.emotionParentPanel = new System.Windows.Forms.Panel();
            this.emotionParentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_00 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_00_10 = new System.Windows.Forms.TableLayoutPanel();
            this.quantityPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.outFolderChooserControlPanel = new AnalysisSystem.Controls.OutFolderChooserControlPanel();
            this.labelChoosingControlPanel = new AnalysisSystem.Controls.LabelChoosingControlPanel();
            this.emotionParentPanel.SuspendLayout();
            this.tableLayoutPanel_00.SuspendLayout();
            this.tableLayoutPanel_00_10.SuspendLayout();
            this.quantityPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmoQuantityLabel
            // 
            this.EmoQuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmoQuantityLabel.AutoSize = true;
            this.EmoQuantityLabel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmoQuantityLabel.Location = new System.Drawing.Point(76, 31);
            this.EmoQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmoQuantityLabel.Name = "EmoQuantityLabel";
            this.EmoQuantityLabel.Size = new System.Drawing.Size(181, 23);
            this.EmoQuantityLabel.TabIndex = 1;
            this.EmoQuantityLabel.Text = "Quantity of Emotions :";
            // 
            // rowCountComboBox
            // 
            this.rowCountComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rowCountComboBox.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowCountComboBox.FormattingEnabled = true;
            this.rowCountComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.rowCountComboBox.Location = new System.Drawing.Point(182, 60);
            this.rowCountComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rowCountComboBox.Name = "rowCountComboBox";
            this.rowCountComboBox.Size = new System.Drawing.Size(45, 31);
            this.rowCountComboBox.TabIndex = 2;
            this.rowCountComboBox.Text = "2";
            // 
            // columnCountComboBox
            // 
            this.columnCountComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnCountComboBox.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnCountComboBox.FormattingEnabled = true;
            this.columnCountComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.columnCountComboBox.Location = new System.Drawing.Point(182, 100);
            this.columnCountComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.columnCountComboBox.Name = "columnCountComboBox";
            this.columnCountComboBox.Size = new System.Drawing.Size(45, 31);
            this.columnCountComboBox.TabIndex = 3;
            this.columnCountComboBox.Text = "3";
            // 
            // emotionParentPanel
            // 
            this.emotionParentPanel.AutoScroll = true;
            this.emotionParentPanel.Controls.Add(this.emotionParentTableLayoutPanel);
            this.emotionParentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emotionParentPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emotionParentPanel.Location = new System.Drawing.Point(341, 1);
            this.emotionParentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.emotionParentPanel.Name = "emotionParentPanel";
            this.tableLayoutPanel_00_10.SetRowSpan(this.emotionParentPanel, 3);
            this.emotionParentPanel.Size = new System.Drawing.Size(794, 325);
            this.emotionParentPanel.TabIndex = 10;
            // 
            // emotionParentTableLayoutPanel
            // 
            this.emotionParentTableLayoutPanel.AutoScroll = true;
            this.emotionParentTableLayoutPanel.AutoSize = true;
            this.emotionParentTableLayoutPanel.ColumnCount = 2;
            this.emotionParentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.emotionParentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.emotionParentTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.emotionParentTableLayoutPanel.Name = "emotionParentTableLayoutPanel";
            this.emotionParentTableLayoutPanel.RowCount = 2;
            this.emotionParentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.emotionParentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.emotionParentTableLayoutPanel.Size = new System.Drawing.Size(832, 325);
            this.emotionParentTableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel_00
            // 
            this.tableLayoutPanel_00.ColumnCount = 1;
            this.tableLayoutPanel_00.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00.Controls.Add(this.tableLayoutPanel_00_10, 0, 1);
            this.tableLayoutPanel_00.Controls.Add(this.labelChoosingControlPanel, 0, 0);
            this.tableLayoutPanel_00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_00.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_00.Name = "tableLayoutPanel_00";
            this.tableLayoutPanel_00.RowCount = 2;
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_00.Size = new System.Drawing.Size(1142, 659);
            this.tableLayoutPanel_00.TabIndex = 11;
            // 
            // tableLayoutPanel_00_10
            // 
            this.tableLayoutPanel_00_10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_00_10.ColumnCount = 2;
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_00_10.Controls.Add(this.quantityPanel, 0, 0);
            this.tableLayoutPanel_00_10.Controls.Add(this.emotionParentPanel, 1, 0);
            this.tableLayoutPanel_00_10.Controls.Add(this.buttonsPanel, 0, 2);
            this.tableLayoutPanel_00_10.Controls.Add(this.outFolderChooserControlPanel, 0, 1);
            this.tableLayoutPanel_00_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00_10.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_00_10.Location = new System.Drawing.Point(3, 329);
            this.tableLayoutPanel_00_10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanel_00_10.Name = "tableLayoutPanel_00_10";
            this.tableLayoutPanel_00_10.RowCount = 3;
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_00_10.Size = new System.Drawing.Size(1136, 327);
            this.tableLayoutPanel_00_10.TabIndex = 6;
            // 
            // quantityPanel
            // 
            this.quantityPanel.Controls.Add(this.EmoQuantityLabel);
            this.quantityPanel.Controls.Add(this.label2);
            this.quantityPanel.Controls.Add(this.rowCountComboBox);
            this.quantityPanel.Controls.Add(this.label1);
            this.quantityPanel.Controls.Add(this.columnCountComboBox);
            this.quantityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityPanel.Location = new System.Drawing.Point(4, 4);
            this.quantityPanel.Name = "quantityPanel";
            this.quantityPanel.Size = new System.Drawing.Size(333, 155);
            this.quantityPanel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cols   =";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rows   =";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.exportButton);
            this.buttonsPanel.Controls.Add(this.okButton);
            this.buttonsPanel.Controls.Add(this.processButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(4, 247);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(333, 76);
            this.buttonsPanel.TabIndex = 13;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.AutoSize = true;
            this.okButton.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(15, 9);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 58);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // processButton
            // 
            this.processButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.processButton.Enabled = false;
            this.processButton.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.Location = new System.Drawing.Point(100, 9);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(106, 58);
            this.processButton.TabIndex = 10;
            this.processButton.Text = "PROCESS";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exportButton.Location = new System.Drawing.Point(211, 9);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(106, 58);
            this.exportButton.TabIndex = 11;
            this.exportButton.Text = "EXPORT";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // outFolderChooserControlPanel
            // 
            this.outFolderChooserControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outFolderChooserControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outFolderChooserControlPanel.Location = new System.Drawing.Point(6, 168);
            this.outFolderChooserControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.outFolderChooserControlPanel.Name = "outFolderChooserControlPanel";
            this.outFolderChooserControlPanel.Size = new System.Drawing.Size(329, 70);
            this.outFolderChooserControlPanel.TabIndex = 14;
            // 
            // labelChoosingControlPanel
            // 
            this.labelChoosingControlPanel.AnalysisSystemForm = null;
            this.labelChoosingControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelChoosingControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoosingControlPanel.Location = new System.Drawing.Point(3, 3);
            this.labelChoosingControlPanel.Name = "labelChoosingControlPanel";
            this.labelChoosingControlPanel.Size = new System.Drawing.Size(1136, 323);
            this.labelChoosingControlPanel.TabIndex = 7;
            // 
            // EmoMappingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel_00);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EmoMappingControlPanel";
            this.Size = new System.Drawing.Size(1142, 659);
            this.emotionParentPanel.ResumeLayout(false);
            this.emotionParentPanel.PerformLayout();
            this.tableLayoutPanel_00.ResumeLayout(false);
            this.tableLayoutPanel_00_10.ResumeLayout(false);
            this.quantityPanel.ResumeLayout(false);
            this.quantityPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.buttonsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EmoQuantityLabel;
        private System.Windows.Forms.ComboBox rowCountComboBox;
        private System.Windows.Forms.ComboBox columnCountComboBox;
        private System.Windows.Forms.Panel emotionParentPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00_10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel emotionParentTableLayoutPanel;
        private LabelChoosingControlPanel labelChoosingControlPanel;
        private System.Windows.Forms.Panel quantityPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button processButton;
        private OutFolderChooserControlPanel outFolderChooserControlPanel;
        private System.Windows.Forms.Button exportButton;

    }
}
