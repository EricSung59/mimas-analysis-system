namespace AnalysisSystem.Controls
{
    partial class ResultChoosingControlPanel
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
            this.rightListView = new System.Windows.Forms.ListView();
            this.selectSampleButton = new System.Windows.Forms.Button();
            this.rightTitleLabel = new System.Windows.Forms.Label();
            this.leftListView = new System.Windows.Forms.ListView();
            this.leftTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightListView
            // 
            this.rightListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rightListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightListView.FullRowSelect = true;
            this.rightListView.GridLines = true;
            this.rightListView.Location = new System.Drawing.Point(427, 27);
            this.rightListView.Margin = new System.Windows.Forms.Padding(0);
            this.rightListView.Name = "rightListView";
            this.rightListView.Size = new System.Drawing.Size(426, 266);
            this.rightListView.TabIndex = 4;
            this.rightListView.UseCompatibleStateImageBehavior = false;
            this.rightListView.View = System.Windows.Forms.View.Details;
            // 
            // selectSampleButton
            // 
            this.selectSampleButton.AutoSize = true;
            this.selectSampleButton.Location = new System.Drawing.Point(6, 6);
            this.selectSampleButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.selectSampleButton.Name = "selectSampleButton";
            this.selectSampleButton.Size = new System.Drawing.Size(152, 40);
            this.selectSampleButton.TabIndex = 8;
            this.selectSampleButton.Text = "Select Sample  ID";
            this.selectSampleButton.UseVisualStyleBackColor = true;
            this.selectSampleButton.Click += new System.EventHandler(this.selectSampleButton_Click);
            // 
            // rightTitleLabel
            // 
            this.rightTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightTitleLabel.Location = new System.Drawing.Point(427, 1);
            this.rightTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.rightTitleLabel.Name = "rightTitleLabel";
            this.rightTitleLabel.Size = new System.Drawing.Size(426, 25);
            this.rightTitleLabel.TabIndex = 6;
            this.rightTitleLabel.Text = "Result";
            // 
            // leftListView
            // 
            this.leftListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leftListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftListView.FullRowSelect = true;
            this.leftListView.GridLines = true;
            this.leftListView.Location = new System.Drawing.Point(1, 27);
            this.leftListView.Margin = new System.Windows.Forms.Padding(0);
            this.leftListView.Name = "leftListView";
            this.leftListView.Size = new System.Drawing.Size(425, 266);
            this.leftListView.TabIndex = 3;
            this.leftListView.UseCompatibleStateImageBehavior = false;
            this.leftListView.View = System.Windows.Forms.View.Details;
            // 
            // leftTitleLabel
            // 
            this.leftTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftTitleLabel.Location = new System.Drawing.Point(1, 1);
            this.leftTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.leftTitleLabel.Name = "leftTitleLabel";
            this.leftTitleLabel.Size = new System.Drawing.Size(425, 25);
            this.leftTitleLabel.TabIndex = 5;
            this.leftTitleLabel.Text = "List of Sample ID";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.rightListView, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.rightTitleLabel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.leftListView, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.leftTitleLabel, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(5, 55);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(854, 294);
            this.tableLayoutPanel.TabIndex = 9;
            // 
            // DoubleViewChoosingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.selectSampleButton);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DoubleViewChoosingControlPanel";
            this.Size = new System.Drawing.Size(864, 354);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView rightListView;
        private System.Windows.Forms.Button selectSampleButton;
        private System.Windows.Forms.Label rightTitleLabel;
        private System.Windows.Forms.ListView leftListView;
        private System.Windows.Forms.Label leftTitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}
