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
            this.processButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.emotionParentPanel = new System.Windows.Forms.Panel();
            this.emotionParentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_00 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_00_10 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelChoosingControlPanel = new AnalysisSystem.Controls.LabelChoosingControlPanel();
            this.emotionParentPanel.SuspendLayout();
            this.tableLayoutPanel_00.SuspendLayout();
            this.tableLayoutPanel_00_10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmoQuantityLabel
            // 
            this.EmoQuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmoQuantityLabel.AutoSize = true;
            this.EmoQuantityLabel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmoQuantityLabel.Location = new System.Drawing.Point(7, 45);
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
            this.rowCountComboBox.Location = new System.Drawing.Point(119, 98);
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
            this.columnCountComboBox.Location = new System.Drawing.Point(119, 143);
            this.columnCountComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.columnCountComboBox.Name = "columnCountComboBox";
            this.columnCountComboBox.Size = new System.Drawing.Size(45, 31);
            this.columnCountComboBox.TabIndex = 3;
            this.columnCountComboBox.Text = "3";
            // 
            // processButton
            // 
            this.processButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.processButton.Enabled = false;
            this.processButton.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.Location = new System.Drawing.Point(74, 24);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(135, 63);
            this.processButton.TabIndex = 7;
            this.processButton.Text = "PROCESS";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.AutoSize = true;
            this.okButton.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(212, 84);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 58);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // emotionParentPanel
            // 
            this.emotionParentPanel.AutoScroll = true;
            this.emotionParentPanel.Controls.Add(this.emotionParentTableLayoutPanel);
            this.emotionParentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emotionParentPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emotionParentPanel.Location = new System.Drawing.Point(303, 1);
            this.emotionParentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.emotionParentPanel.Name = "emotionParentPanel";
            this.tableLayoutPanel_00_10.SetRowSpan(this.emotionParentPanel, 2);
            this.emotionParentPanel.Size = new System.Drawing.Size(832, 325);
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
            this.tableLayoutPanel_00_10.ColumnCount = 3;
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00_10.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel_00_10.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel_00_10.Controls.Add(this.emotionParentPanel, 2, 0);
            this.tableLayoutPanel_00_10.Controls.Add(this.okButton, 1, 0);
            this.tableLayoutPanel_00_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00_10.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_00_10.Location = new System.Drawing.Point(3, 329);
            this.tableLayoutPanel_00_10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanel_00_10.Name = "tableLayoutPanel_00_10";
            this.tableLayoutPanel_00_10.RowCount = 2;
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_00_10.Size = new System.Drawing.Size(1136, 327);
            this.tableLayoutPanel_00_10.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EmoQuantityLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rowCountComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.columnCountComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 218);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cols   =";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rows   =";
            // 
            // panel2
            // 
            this.tableLayoutPanel_00_10.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.processButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 226);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 100);
            this.panel2.TabIndex = 12;
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
            this.tableLayoutPanel_00_10.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EmoQuantityLabel;
        private System.Windows.Forms.ComboBox rowCountComboBox;
        private System.Windows.Forms.ComboBox columnCountComboBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel emotionParentPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00_10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel emotionParentTableLayoutPanel;
        private LabelChoosingControlPanel labelChoosingControlPanel;

    }
}
