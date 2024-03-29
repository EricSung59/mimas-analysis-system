﻿namespace AnalysisSystem.Controls
{
    partial class SampleEliminatingControlPanel
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
            this.deviationLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.sdLabel = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.badSampleRadioButton = new System.Windows.Forms.RadioButton();
            this.goodSampleRadioButton = new System.Windows.Forms.RadioButton();
            this.conditionPanel = new System.Windows.Forms.Panel();
            this.commandPanel = new System.Windows.Forms.Panel();
            this.leftListViewGroupBox = new System.Windows.Forms.GroupBox();
            this.leftListViewGroupBoxTotalLabel = new System.Windows.Forms.Label();
            this.rightListViewGroupBox = new System.Windows.Forms.GroupBox();
            this.rightListViewGroupBoxFaultLabel = new System.Windows.Forms.Label();
            this.rightListViewGroupBoxBadLabel = new System.Windows.Forms.Label();
            this.rightListViewGroupBoxGoodLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel_00 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_00_10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_00_10_01 = new System.Windows.Forms.TableLayoutPanel();
            this.resultChoosingControlPanel = new AnalysisSystem.Controls.ResultChoosingControlPanel();
            this.resultGroupBox.SuspendLayout();
            this.conditionPanel.SuspendLayout();
            this.commandPanel.SuspendLayout();
            this.leftListViewGroupBox.SuspendLayout();
            this.rightListViewGroupBox.SuspendLayout();
            this.tableLayoutPanel_00.SuspendLayout();
            this.tableLayoutPanel_00_10.SuspendLayout();
            this.tableLayoutPanel_00_10_01.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviationLabel
            // 
            this.deviationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deviationLabel.AutoSize = true;
            this.deviationLabel.Location = new System.Drawing.Point(27, 9);
            this.deviationLabel.Name = "deviationLabel";
            this.deviationLabel.Size = new System.Drawing.Size(97, 23);
            this.deviationLabel.TabIndex = 1;
            this.deviationLabel.Text = "Deviation =";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputTextBox.Location = new System.Drawing.Point(130, 6);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(63, 30);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.Text = "1.0";
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sdLabel
            // 
            this.sdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sdLabel.AutoSize = true;
            this.sdLabel.Location = new System.Drawing.Point(201, 9);
            this.sdLabel.Name = "sdLabel";
            this.sdLabel.Size = new System.Drawing.Size(43, 23);
            this.sdLabel.TabIndex = 3;
            this.sdLabel.Text = "* SD";
            // 
            // processButton
            // 
            this.processButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.processButton.Location = new System.Drawing.Point(29, 15);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(123, 52);
            this.processButton.TabIndex = 4;
            this.processButton.Text = "PROCESS";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(29, 87);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(123, 52);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultGroupBox.Controls.Add(this.badSampleRadioButton);
            this.resultGroupBox.Controls.Add(this.goodSampleRadioButton);
            this.resultGroupBox.Location = new System.Drawing.Point(31, 43);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(213, 105);
            this.resultGroupBox.TabIndex = 6;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Result";
            // 
            // badSampleRadioButton
            // 
            this.badSampleRadioButton.AutoSize = true;
            this.badSampleRadioButton.Location = new System.Drawing.Point(15, 63);
            this.badSampleRadioButton.Name = "badSampleRadioButton";
            this.badSampleRadioButton.Size = new System.Drawing.Size(116, 27);
            this.badSampleRadioButton.TabIndex = 1;
            this.badSampleRadioButton.Text = "Bad sample";
            this.badSampleRadioButton.UseVisualStyleBackColor = true;
            // 
            // goodSampleRadioButton
            // 
            this.goodSampleRadioButton.AutoSize = true;
            this.goodSampleRadioButton.Checked = true;
            this.goodSampleRadioButton.Location = new System.Drawing.Point(15, 30);
            this.goodSampleRadioButton.Name = "goodSampleRadioButton";
            this.goodSampleRadioButton.Size = new System.Drawing.Size(128, 27);
            this.goodSampleRadioButton.TabIndex = 0;
            this.goodSampleRadioButton.TabStop = true;
            this.goodSampleRadioButton.Text = "Good sample";
            this.goodSampleRadioButton.UseVisualStyleBackColor = true;
            // 
            // conditionPanel
            // 
            this.conditionPanel.Controls.Add(this.deviationLabel);
            this.conditionPanel.Controls.Add(this.resultGroupBox);
            this.conditionPanel.Controls.Add(this.inputTextBox);
            this.conditionPanel.Controls.Add(this.sdLabel);
            this.conditionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conditionPanel.Location = new System.Drawing.Point(1, 1);
            this.conditionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.conditionPanel.Name = "conditionPanel";
            this.conditionPanel.Size = new System.Drawing.Size(270, 155);
            this.conditionPanel.TabIndex = 7;
            // 
            // commandPanel
            // 
            this.commandPanel.Controls.Add(this.processButton);
            this.commandPanel.Controls.Add(this.updateButton);
            this.commandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandPanel.Location = new System.Drawing.Point(724, 1);
            this.commandPanel.Margin = new System.Windows.Forms.Padding(0);
            this.commandPanel.Name = "commandPanel";
            this.commandPanel.Size = new System.Drawing.Size(181, 155);
            this.commandPanel.TabIndex = 10;
            // 
            // leftListViewGroupBox
            // 
            this.leftListViewGroupBox.Controls.Add(this.leftListViewGroupBoxTotalLabel);
            this.leftListViewGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftListViewGroupBox.Location = new System.Drawing.Point(3, 3);
            this.leftListViewGroupBox.Name = "leftListViewGroupBox";
            this.leftListViewGroupBox.Size = new System.Drawing.Size(216, 143);
            this.leftListViewGroupBox.TabIndex = 0;
            this.leftListViewGroupBox.TabStop = false;
            this.leftListViewGroupBox.Text = "Sample ID";
            // 
            // leftListViewGroupBoxTotalLabel
            // 
            this.leftListViewGroupBoxTotalLabel.AutoSize = true;
            this.leftListViewGroupBoxTotalLabel.Location = new System.Drawing.Point(16, 34);
            this.leftListViewGroupBoxTotalLabel.Name = "leftListViewGroupBoxTotalLabel";
            this.leftListViewGroupBoxTotalLabel.Size = new System.Drawing.Size(54, 23);
            this.leftListViewGroupBoxTotalLabel.TabIndex = 0;
            this.leftListViewGroupBoxTotalLabel.Text = "Total:";
            // 
            // rightListViewGroupBox
            // 
            this.rightListViewGroupBox.Controls.Add(this.rightListViewGroupBoxFaultLabel);
            this.rightListViewGroupBox.Controls.Add(this.rightListViewGroupBoxBadLabel);
            this.rightListViewGroupBox.Controls.Add(this.rightListViewGroupBoxGoodLabel);
            this.rightListViewGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightListViewGroupBox.Location = new System.Drawing.Point(225, 3);
            this.rightListViewGroupBox.Name = "rightListViewGroupBox";
            this.rightListViewGroupBox.Size = new System.Drawing.Size(217, 143);
            this.rightListViewGroupBox.TabIndex = 1;
            this.rightListViewGroupBox.TabStop = false;
            this.rightListViewGroupBox.Text = "Result";
            // 
            // rightListViewGroupBoxFaultLabel
            // 
            this.rightListViewGroupBoxFaultLabel.AutoSize = true;
            this.rightListViewGroupBoxFaultLabel.Location = new System.Drawing.Point(19, 96);
            this.rightListViewGroupBoxFaultLabel.Name = "rightListViewGroupBoxFaultLabel";
            this.rightListViewGroupBoxFaultLabel.Size = new System.Drawing.Size(53, 23);
            this.rightListViewGroupBoxFaultLabel.TabIndex = 3;
            this.rightListViewGroupBoxFaultLabel.Text = "Fault:";
            // 
            // rightListViewGroupBoxBadLabel
            // 
            this.rightListViewGroupBoxBadLabel.AutoSize = true;
            this.rightListViewGroupBoxBadLabel.Location = new System.Drawing.Point(19, 65);
            this.rightListViewGroupBoxBadLabel.Name = "rightListViewGroupBoxBadLabel";
            this.rightListViewGroupBoxBadLabel.Size = new System.Drawing.Size(43, 23);
            this.rightListViewGroupBoxBadLabel.TabIndex = 2;
            this.rightListViewGroupBoxBadLabel.Text = "Bad:";
            // 
            // rightListViewGroupBoxGoodLabel
            // 
            this.rightListViewGroupBoxGoodLabel.AutoSize = true;
            this.rightListViewGroupBoxGoodLabel.Location = new System.Drawing.Point(19, 34);
            this.rightListViewGroupBoxGoodLabel.Name = "rightListViewGroupBoxGoodLabel";
            this.rightListViewGroupBoxGoodLabel.Size = new System.Drawing.Size(55, 23);
            this.rightListViewGroupBoxGoodLabel.TabIndex = 1;
            this.rightListViewGroupBoxGoodLabel.Text = "Good:";
            // 
            // tableLayoutPanel_00
            // 
            this.tableLayoutPanel_00.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_00.ColumnCount = 1;
            this.tableLayoutPanel_00.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00.Controls.Add(this.resultChoosingControlPanel, 0, 0);
            this.tableLayoutPanel_00.Controls.Add(this.tableLayoutPanel_00_10, 0, 1);
            this.tableLayoutPanel_00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_00.Name = "tableLayoutPanel_00";
            this.tableLayoutPanel_00.RowCount = 2;
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_00.Size = new System.Drawing.Size(914, 546);
            this.tableLayoutPanel_00.TabIndex = 11;
            // 
            // tableLayoutPanel_00_10
            // 
            this.tableLayoutPanel_00_10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_00_10.ColumnCount = 3;
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_00_10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_00_10.Controls.Add(this.conditionPanel, 0, 0);
            this.tableLayoutPanel_00_10.Controls.Add(this.commandPanel, 2, 0);
            this.tableLayoutPanel_00_10.Controls.Add(this.tableLayoutPanel_00_10_01, 1, 0);
            this.tableLayoutPanel_00_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00_10.Location = new System.Drawing.Point(4, 385);
            this.tableLayoutPanel_00_10.Name = "tableLayoutPanel_00_10";
            this.tableLayoutPanel_00_10.RowCount = 1;
            this.tableLayoutPanel_00_10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00_10.Size = new System.Drawing.Size(906, 157);
            this.tableLayoutPanel_00_10.TabIndex = 9;
            // 
            // tableLayoutPanel_00_10_01
            // 
            this.tableLayoutPanel_00_10_01.ColumnCount = 2;
            this.tableLayoutPanel_00_10_01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_00_10_01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_00_10_01.Controls.Add(this.leftListViewGroupBox, 0, 0);
            this.tableLayoutPanel_00_10_01.Controls.Add(this.rightListViewGroupBox, 1, 0);
            this.tableLayoutPanel_00_10_01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00_10_01.Location = new System.Drawing.Point(275, 4);
            this.tableLayoutPanel_00_10_01.Name = "tableLayoutPanel_00_10_01";
            this.tableLayoutPanel_00_10_01.RowCount = 1;
            this.tableLayoutPanel_00_10_01.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_00_10_01.Size = new System.Drawing.Size(445, 149);
            this.tableLayoutPanel_00_10_01.TabIndex = 11;
            // 
            // resultChoosingControlPanel
            // 
            this.resultChoosingControlPanel.AnalysisSystemForm = null;
            this.resultChoosingControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultChoosingControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultChoosingControlPanel.Location = new System.Drawing.Point(4, 4);
            this.resultChoosingControlPanel.Name = "resultChoosingControlPanel";
            this.resultChoosingControlPanel.Size = new System.Drawing.Size(906, 374);
            this.resultChoosingControlPanel.TabIndex = 8;
            // 
            // SampleEliminatingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel_00);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SampleEliminatingControlPanel";
            this.Size = new System.Drawing.Size(914, 546);
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.conditionPanel.ResumeLayout(false);
            this.conditionPanel.PerformLayout();
            this.commandPanel.ResumeLayout(false);
            this.leftListViewGroupBox.ResumeLayout(false);
            this.leftListViewGroupBox.PerformLayout();
            this.rightListViewGroupBox.ResumeLayout(false);
            this.rightListViewGroupBox.PerformLayout();
            this.tableLayoutPanel_00.ResumeLayout(false);
            this.tableLayoutPanel_00_10.ResumeLayout(false);
            this.tableLayoutPanel_00_10_01.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label deviationLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label sdLabel;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.RadioButton badSampleRadioButton;
        private System.Windows.Forms.RadioButton goodSampleRadioButton;
        private System.Windows.Forms.Panel conditionPanel;
        private ResultChoosingControlPanel resultChoosingControlPanel;
        private System.Windows.Forms.Panel commandPanel;
        private System.Windows.Forms.GroupBox leftListViewGroupBox;
        private System.Windows.Forms.GroupBox rightListViewGroupBox;
        private System.Windows.Forms.Label leftListViewGroupBoxTotalLabel;
        private System.Windows.Forms.Label rightListViewGroupBoxGoodLabel;
        private System.Windows.Forms.Label rightListViewGroupBoxBadLabel;
        private System.Windows.Forms.Label rightListViewGroupBoxFaultLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00_10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00_10_01;


    }
}
