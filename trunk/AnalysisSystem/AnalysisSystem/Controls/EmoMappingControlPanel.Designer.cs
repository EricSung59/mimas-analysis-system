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
            this.AQuantityCombobox = new System.Windows.Forms.ComboBox();
            this.VQuantityCombobox = new System.Windows.Forms.ComboBox();
            this.MultipliLabel = new System.Windows.Forms.Label();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.EmoQuantityPanel = new System.Windows.Forms.Panel();
            this.EmoPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.resultChoosingControlPanel = new AnalysisSystem.Controls.ResultChoosingControlPanel();
            this.EmoQuantityPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmoQuantityLabel
            // 
            this.EmoQuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmoQuantityLabel.AutoSize = true;
            this.EmoQuantityLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmoQuantityLabel.Location = new System.Drawing.Point(34, 77);
            this.EmoQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmoQuantityLabel.Name = "EmoQuantityLabel";
            this.EmoQuantityLabel.Size = new System.Drawing.Size(187, 18);
            this.EmoQuantityLabel.TabIndex = 1;
            this.EmoQuantityLabel.Text = "Quantity of Emotion :";
            // 
            // AQuantityCombobox
            // 
            this.AQuantityCombobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AQuantityCombobox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AQuantityCombobox.FormattingEnabled = true;
            this.AQuantityCombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.AQuantityCombobox.Location = new System.Drawing.Point(34, 109);
            this.AQuantityCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AQuantityCombobox.Name = "AQuantityCombobox";
            this.AQuantityCombobox.Size = new System.Drawing.Size(41, 26);
            this.AQuantityCombobox.TabIndex = 2;
            this.AQuantityCombobox.Text = "3";
            // 
            // VQuantityCombobox
            // 
            this.VQuantityCombobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VQuantityCombobox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VQuantityCombobox.FormattingEnabled = true;
            this.VQuantityCombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.VQuantityCombobox.Location = new System.Drawing.Point(108, 109);
            this.VQuantityCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VQuantityCombobox.Name = "VQuantityCombobox";
            this.VQuantityCombobox.Size = new System.Drawing.Size(43, 26);
            this.VQuantityCombobox.TabIndex = 3;
            this.VQuantityCombobox.Text = "4";
            // 
            // MultipliLabel
            // 
            this.MultipliLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MultipliLabel.AutoSize = true;
            this.MultipliLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultipliLabel.Location = new System.Drawing.Point(82, 112);
            this.MultipliLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MultipliLabel.Name = "MultipliLabel";
            this.MultipliLabel.Size = new System.Drawing.Size(18, 18);
            this.MultipliLabel.TabIndex = 4;
            this.MultipliLabel.Text = "*";
            this.MultipliLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProcessButton
            // 
            this.ProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcessButton.Location = new System.Drawing.Point(3, 228);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(105, 42);
            this.ProcessButton.TabIndex = 7;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OkButton.Location = new System.Drawing.Point(45, 152);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(55, 38);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // EmoQuantityPanel
            // 
            this.EmoQuantityPanel.Controls.Add(this.ProcessButton);
            this.EmoQuantityPanel.Controls.Add(this.VQuantityCombobox);
            this.EmoQuantityPanel.Controls.Add(this.OkButton);
            this.EmoQuantityPanel.Controls.Add(this.EmoQuantityLabel);
            this.EmoQuantityPanel.Controls.Add(this.AQuantityCombobox);
            this.EmoQuantityPanel.Controls.Add(this.MultipliLabel);
            this.EmoQuantityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmoQuantityPanel.Location = new System.Drawing.Point(4, 4);
            this.EmoQuantityPanel.Name = "EmoQuantityPanel";
            this.EmoQuantityPanel.Size = new System.Drawing.Size(299, 273);
            this.EmoQuantityPanel.TabIndex = 9;
            // 
            // EmoPanel
            // 
            this.EmoPanel.AutoScroll = true;
            this.EmoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmoPanel.Location = new System.Drawing.Point(310, 4);
            this.EmoPanel.Name = "EmoPanel";
            this.EmoPanel.Size = new System.Drawing.Size(708, 273);
            this.EmoPanel.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.resultChoosingControlPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 573);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.EmoQuantityPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.EmoPanel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 289);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1022, 281);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // doubleViewChoosingControlPanel
            // 
            this.resultChoosingControlPanel.AnalysisSystemForm = null;
            this.resultChoosingControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultChoosingControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultChoosingControlPanel.Location = new System.Drawing.Point(5, 5);
            this.resultChoosingControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.resultChoosingControlPanel.Name = "doubleViewChoosingControlPanel";
            this.resultChoosingControlPanel.Size = new System.Drawing.Size(1018, 276);
            this.resultChoosingControlPanel.TabIndex = 7;
            // 
            // EmoMappingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmoMappingControlPanel";
            this.Size = new System.Drawing.Size(1028, 573);
            this.EmoQuantityPanel.ResumeLayout(false);
            this.EmoQuantityPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EmoQuantityLabel;
        private System.Windows.Forms.ComboBox AQuantityCombobox;
        private System.Windows.Forms.ComboBox VQuantityCombobox;
        private System.Windows.Forms.Label MultipliLabel;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Panel EmoQuantityPanel;
        private System.Windows.Forms.Panel EmoPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public ResultChoosingControlPanel resultChoosingControlPanel;

    }
}
