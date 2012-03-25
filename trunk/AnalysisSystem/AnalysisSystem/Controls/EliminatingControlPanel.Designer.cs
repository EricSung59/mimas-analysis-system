namespace AnalysisSystem.Controls
{
    partial class EliminatingControlPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.badSampleRadioButton = new System.Windows.Forms.RadioButton();
            this.goodSampleRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.doubleViewChoosingControlPanel = new AnalysisSystem.Controls.DoubleViewChoosingControlPanel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Deviation =";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inputTextBox.Location = new System.Drawing.Point(163, 15);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(63, 30);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.Text = "1.0";
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "* SD";
            // 
            // processButton
            // 
            this.processButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.processButton.Location = new System.Drawing.Point(442, 377);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(123, 52);
            this.processButton.TabIndex = 4;
            this.processButton.Text = "PROCESS";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(630, 377);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(123, 52);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.badSampleRadioButton);
            this.groupBox1.Controls.Add(this.goodSampleRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(64, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.inputTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 173);
            this.panel1.TabIndex = 7;
            // 
            // doubleViewChoosingControlPanel
            // 
            this.doubleViewChoosingControlPanel.AnalysisSystemForm = null;
            this.doubleViewChoosingControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doubleViewChoosingControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doubleViewChoosingControlPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleViewChoosingControlPanel.Location = new System.Drawing.Point(0, 0);
            this.doubleViewChoosingControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.doubleViewChoosingControlPanel.Name = "doubleViewChoosingControlPanel";
            this.doubleViewChoosingControlPanel.Size = new System.Drawing.Size(832, 307);
            this.doubleViewChoosingControlPanel.TabIndex = 8;
            // 
            // EliminatingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.doubleViewChoosingControlPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.processButton);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EliminatingControlPanel";
            this.Size = new System.Drawing.Size(832, 479);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton badSampleRadioButton;
        private System.Windows.Forms.RadioButton goodSampleRadioButton;
        private System.Windows.Forms.Panel panel1;
        private DoubleViewChoosingControlPanel doubleViewChoosingControlPanel;


    }
}
