namespace AnalysisSystem.Controls
{
    partial class LabelChoosingControlPanel
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
            this.selectSampleButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel_00_10 = new System.Windows.Forms.TableLayoutPanel();
            this.rightListView = new System.Windows.Forms.ListView();
            this.rightTitleLabel = new System.Windows.Forms.Label();
            this.leftListView = new System.Windows.Forms.ListView();
            this.leftTitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.onlyGoodSamplesCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel_00.SuspendLayout();
            this.tableLayoutPanel_00_10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_00
            // 
            this.tableLayoutPanel_00.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_00.ColumnCount = 1;
            this.tableLayoutPanel_00.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00.Controls.Add(this.tableLayoutPanel_00_10, 0, 1);
            this.tableLayoutPanel_00.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel_00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_00.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel_00.Name = "tableLayoutPanel_00";
            this.tableLayoutPanel_00.RowCount = 2;
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00.Size = new System.Drawing.Size(947, 406);
            this.tableLayoutPanel_00.TabIndex = 11;
            // 
            // selectSampleButton
            // 
            this.selectSampleButton.AutoSize = true;
            this.selectSampleButton.Location = new System.Drawing.Point(5, 3);
            this.selectSampleButton.Margin = new System.Windows.Forms.Padding(5);
            this.selectSampleButton.Name = "selectSampleButton";
            this.selectSampleButton.Size = new System.Drawing.Size(160, 35);
            this.selectSampleButton.TabIndex = 8;
            this.selectSampleButton.Text = "Select Sample  ID";
            this.selectSampleButton.UseVisualStyleBackColor = true;
            this.selectSampleButton.Click += new System.EventHandler(this.selectSampleButton_Click);
            // 
            // tableLayoutPanel_00_10
            // 
            this.tableLayoutPanel_00_10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_00_10.ColumnCount = 2;
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_00_10.Controls.Add(this.rightListView, 1, 1);
            this.tableLayoutPanel_00_10.Controls.Add(this.rightTitleLabel, 1, 0);
            this.tableLayoutPanel_00_10.Controls.Add(this.leftListView, 0, 1);
            this.tableLayoutPanel_00_10.Controls.Add(this.leftTitleLabel, 0, 0);
            this.tableLayoutPanel_00_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00_10.Location = new System.Drawing.Point(4, 51);
            this.tableLayoutPanel_00_10.Name = "tableLayoutPanel_00_10";
            this.tableLayoutPanel_00_10.RowCount = 2;
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00_10.Size = new System.Drawing.Size(939, 351);
            this.tableLayoutPanel_00_10.TabIndex = 9;
            // 
            // rightListView
            // 
            this.rightListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rightListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightListView.FullRowSelect = true;
            this.rightListView.GridLines = true;
            this.rightListView.Location = new System.Drawing.Point(563, 32);
            this.rightListView.Margin = new System.Windows.Forms.Padding(0);
            this.rightListView.Name = "rightListView";
            this.rightListView.Size = new System.Drawing.Size(375, 318);
            this.rightListView.TabIndex = 4;
            this.rightListView.UseCompatibleStateImageBehavior = false;
            this.rightListView.View = System.Windows.Forms.View.Details;
            // 
            // rightTitleLabel
            // 
            this.rightTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightTitleLabel.Location = new System.Drawing.Point(563, 1);
            this.rightTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.rightTitleLabel.Name = "rightTitleLabel";
            this.rightTitleLabel.Size = new System.Drawing.Size(375, 30);
            this.rightTitleLabel.TabIndex = 6;
            this.rightTitleLabel.Text = "Label";
            this.rightTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // leftListView
            // 
            this.leftListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leftListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftListView.FullRowSelect = true;
            this.leftListView.GridLines = true;
            this.leftListView.Location = new System.Drawing.Point(1, 32);
            this.leftListView.Margin = new System.Windows.Forms.Padding(0);
            this.leftListView.Name = "leftListView";
            this.leftListView.Size = new System.Drawing.Size(561, 318);
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
            this.leftTitleLabel.Size = new System.Drawing.Size(561, 30);
            this.leftTitleLabel.TabIndex = 5;
            this.leftTitleLabel.Text = "List of Sample ID";
            this.leftTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.onlyGoodSamplesCheckBox);
            this.panel1.Controls.Add(this.selectSampleButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 40);
            this.panel1.TabIndex = 10;
            // 
            // onlyGoodSamplesCheckBox
            // 
            this.onlyGoodSamplesCheckBox.AutoSize = true;
            this.onlyGoodSamplesCheckBox.Checked = true;
            this.onlyGoodSamplesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onlyGoodSamplesCheckBox.Location = new System.Drawing.Point(173, 7);
            this.onlyGoodSamplesCheckBox.Name = "onlyGoodSamplesCheckBox";
            this.onlyGoodSamplesCheckBox.Size = new System.Drawing.Size(174, 27);
            this.onlyGoodSamplesCheckBox.TabIndex = 9;
            this.onlyGoodSamplesCheckBox.Text = "Only good samples";
            this.onlyGoodSamplesCheckBox.UseVisualStyleBackColor = true;
            // 
            // LabelChoosingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel_00);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LabelChoosingControlPanel";
            this.Size = new System.Drawing.Size(947, 406);
            this.tableLayoutPanel_00.ResumeLayout(false);
            this.tableLayoutPanel_00_10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00;
        private System.Windows.Forms.Button selectSampleButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00_10;
        private System.Windows.Forms.ListView rightListView;
        private System.Windows.Forms.Label rightTitleLabel;
        private System.Windows.Forms.ListView leftListView;
        private System.Windows.Forms.Label leftTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox onlyGoodSamplesCheckBox;
    }
}
