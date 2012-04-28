namespace AnalysisSystem.Controls
{
    partial class TestingControlPanel
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
            this.components = new System.ComponentModel.Container();
            this.rawDataModelTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.modelFilePathTextBox = new System.Windows.Forms.TextBox();
            this.modelFilePathBrowseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.labelLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lowerTextBox = new System.Windows.Forms.TextBox();
            this.upperTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.arousalMinTextBox = new System.Windows.Forms.TextBox();
            this.valenceMinTextBox = new System.Windows.Forms.TextBox();
            this.valenceMaxTextBox = new System.Windows.Forms.TextBox();
            this.arousalMaxTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rawDataModelTimer
            // 
            this.rawDataModelTimer.Tick += new System.EventHandler(this.rawDataModelTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model file path";
            // 
            // modelFilePathTextBox
            // 
            this.modelFilePathTextBox.Location = new System.Drawing.Point(185, 34);
            this.modelFilePathTextBox.Name = "modelFilePathTextBox";
            this.modelFilePathTextBox.Size = new System.Drawing.Size(498, 30);
            this.modelFilePathTextBox.TabIndex = 1;
            // 
            // modelFilePathBrowseButton
            // 
            this.modelFilePathBrowseButton.AutoSize = true;
            this.modelFilePathBrowseButton.Location = new System.Drawing.Point(689, 33);
            this.modelFilePathBrowseButton.Name = "modelFilePathBrowseButton";
            this.modelFilePathBrowseButton.Size = new System.Drawing.Size(79, 33);
            this.modelFilePathBrowseButton.TabIndex = 2;
            this.modelFilePathBrowseButton.Text = "Browse";
            this.modelFilePathBrowseButton.UseVisualStyleBackColor = true;
            this.modelFilePathBrowseButton.Click += new System.EventHandler(this.modelFilePathBrowseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Location = new System.Drawing.Point(60, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelLabel);
            this.groupBox2.Location = new System.Drawing.Point(389, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 160);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Label";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(37, 39);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(107, 83);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(179, 39);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(107, 83);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // labelLabel
            // 
            this.labelLabel.AutoSize = true;
            this.labelLabel.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLabel.Location = new System.Drawing.Point(114, 69);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(29, 36);
            this.labelLabel.TabIndex = 0;
            this.labelLabel.Text = "0";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "model";
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Model files (*.model)|*.model";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Controls.Add(this.upperTextBox);
            this.groupBox3.Controls.Add(this.lowerTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(60, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 233);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scale parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lower";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Upper";
            // 
            // lowerTextBox
            // 
            this.lowerTextBox.Location = new System.Drawing.Point(79, 103);
            this.lowerTextBox.Name = "lowerTextBox";
            this.lowerTextBox.Size = new System.Drawing.Size(40, 30);
            this.lowerTextBox.TabIndex = 2;
            this.lowerTextBox.Text = "-1";
            this.lowerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // upperTextBox
            // 
            this.upperTextBox.Location = new System.Drawing.Point(79, 57);
            this.upperTextBox.Name = "upperTextBox";
            this.upperTextBox.Size = new System.Drawing.Size(40, 30);
            this.upperTextBox.TabIndex = 3;
            this.upperTextBox.Text = "1";
            this.upperTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.arousalMinTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.valenceMinTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.valenceMaxTextBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.arousalMaxTextBox, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(142, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 186);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Index";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Arousal";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Valence";
            // 
            // arousalMinTextBox
            // 
            this.arousalMinTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arousalMinTextBox.Location = new System.Drawing.Point(160, 49);
            this.arousalMinTextBox.Name = "arousalMinTextBox";
            this.arousalMinTextBox.Size = new System.Drawing.Size(116, 30);
            this.arousalMinTextBox.TabIndex = 5;
            this.arousalMinTextBox.Text = "1.8679";
            // 
            // valenceMinTextBox
            // 
            this.valenceMinTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.valenceMinTextBox.Location = new System.Drawing.Point(160, 130);
            this.valenceMinTextBox.Name = "valenceMinTextBox";
            this.valenceMinTextBox.Size = new System.Drawing.Size(116, 30);
            this.valenceMinTextBox.TabIndex = 6;
            this.valenceMinTextBox.Text = "-0.1817";
            // 
            // valenceMaxTextBox
            // 
            this.valenceMaxTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.valenceMaxTextBox.Location = new System.Drawing.Point(306, 130);
            this.valenceMaxTextBox.Name = "valenceMaxTextBox";
            this.valenceMaxTextBox.Size = new System.Drawing.Size(116, 30);
            this.valenceMaxTextBox.TabIndex = 7;
            this.valenceMaxTextBox.Text = "0.0544";
            // 
            // arousalMaxTextBox
            // 
            this.arousalMaxTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arousalMaxTextBox.Location = new System.Drawing.Point(306, 49);
            this.arousalMaxTextBox.Name = "arousalMaxTextBox";
            this.arousalMaxTextBox.Size = new System.Drawing.Size(116, 30);
            this.arousalMaxTextBox.TabIndex = 8;
            this.arousalMaxTextBox.Text = "2.0359";
            // 
            // TestingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modelFilePathBrowseButton);
            this.Controls.Add(this.modelFilePathTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TestingControlPanel";
            this.Size = new System.Drawing.Size(957, 607);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer rawDataModelTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modelFilePathTextBox;
        private System.Windows.Forms.Button modelFilePathBrowseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox upperTextBox;
        private System.Windows.Forms.TextBox lowerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox arousalMinTextBox;
        private System.Windows.Forms.TextBox valenceMinTextBox;
        private System.Windows.Forms.TextBox valenceMaxTextBox;
        private System.Windows.Forms.TextBox arousalMaxTextBox;
    }
}
