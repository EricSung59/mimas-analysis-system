namespace AnalysisSystem.Controls
{
    partial class EmotionSelectControlPanel
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
            this.emotionLabel = new System.Windows.Forms.Label();
            this.arousalLabel = new System.Windows.Forms.Label();
            this.valenceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.arousalStartComboBox = new System.Windows.Forms.ComboBox();
            this.arousalEndComboBox = new System.Windows.Forms.ComboBox();
            this.valenceStartComboBox = new System.Windows.Forms.ComboBox();
            this.valenceEndComboBox = new System.Windows.Forms.ComboBox();
            this.emotionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // emotionLabel
            // 
            this.emotionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emotionLabel.AutoSize = true;
            this.emotionLabel.Location = new System.Drawing.Point(22, 21);
            this.emotionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emotionLabel.Name = "emotionLabel";
            this.emotionLabel.Size = new System.Drawing.Size(68, 20);
            this.emotionLabel.TabIndex = 1;
            this.emotionLabel.Text = "Emotion";
            // 
            // arousalLabel
            // 
            this.arousalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arousalLabel.AutoSize = true;
            this.arousalLabel.Location = new System.Drawing.Point(22, 103);
            this.arousalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arousalLabel.Name = "arousalLabel";
            this.arousalLabel.Size = new System.Drawing.Size(28, 20);
            this.arousalLabel.TabIndex = 2;
            this.arousalLabel.Text = "A :";
            // 
            // valenceLabel
            // 
            this.valenceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.valenceLabel.AutoSize = true;
            this.valenceLabel.Location = new System.Drawing.Point(22, 64);
            this.valenceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valenceLabel.Name = "valenceLabel";
            this.valenceLabel.Size = new System.Drawing.Size(28, 20);
            this.valenceLabel.TabIndex = 3;
            this.valenceLabel.Text = "V: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "--";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "--";
            // 
            // arousalStartComboBox
            // 
            this.arousalStartComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arousalStartComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arousalStartComboBox.FormattingEnabled = true;
            this.arousalStartComboBox.Location = new System.Drawing.Point(63, 99);
            this.arousalStartComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.arousalStartComboBox.Name = "arousalStartComboBox";
            this.arousalStartComboBox.Size = new System.Drawing.Size(44, 28);
            this.arousalStartComboBox.TabIndex = 6;
            this.arousalStartComboBox.SelectionChangeCommitted += new System.EventHandler(this.arousalStartComboBox_SelectionChangeCommitted);
            // 
            // arousalEndComboBox
            // 
            this.arousalEndComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arousalEndComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arousalEndComboBox.FormattingEnabled = true;
            this.arousalEndComboBox.Location = new System.Drawing.Point(144, 99);
            this.arousalEndComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.arousalEndComboBox.Name = "arousalEndComboBox";
            this.arousalEndComboBox.Size = new System.Drawing.Size(43, 28);
            this.arousalEndComboBox.TabIndex = 7;
            this.arousalEndComboBox.SelectionChangeCommitted += new System.EventHandler(this.arousalEndComboBox_SelectionChangeCommitted);
            // 
            // valenceStartComboBox
            // 
            this.valenceStartComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.valenceStartComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valenceStartComboBox.FormattingEnabled = true;
            this.valenceStartComboBox.Location = new System.Drawing.Point(63, 60);
            this.valenceStartComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valenceStartComboBox.Name = "valenceStartComboBox";
            this.valenceStartComboBox.Size = new System.Drawing.Size(43, 28);
            this.valenceStartComboBox.TabIndex = 8;
            this.valenceStartComboBox.SelectionChangeCommitted += new System.EventHandler(this.valenceStartComboBox_SelectionChangeCommitted);
            // 
            // valenceEndComboBox
            // 
            this.valenceEndComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.valenceEndComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valenceEndComboBox.FormattingEnabled = true;
            this.valenceEndComboBox.Location = new System.Drawing.Point(145, 60);
            this.valenceEndComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valenceEndComboBox.Name = "valenceEndComboBox";
            this.valenceEndComboBox.Size = new System.Drawing.Size(43, 28);
            this.valenceEndComboBox.TabIndex = 9;
            this.valenceEndComboBox.SelectionChangeCommitted += new System.EventHandler(this.valenceEndComboBox_SelectionChangeCommitted);
            // 
            // emotionTextBox
            // 
            this.emotionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emotionTextBox.Location = new System.Drawing.Point(114, 18);
            this.emotionTextBox.Name = "emotionTextBox";
            this.emotionTextBox.ReadOnly = true;
            this.emotionTextBox.Size = new System.Drawing.Size(42, 26);
            this.emotionTextBox.TabIndex = 10;
            this.emotionTextBox.TabStop = false;
            // 
            // EmotionSelectControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.emotionTextBox);
            this.Controls.Add(this.valenceEndComboBox);
            this.Controls.Add(this.valenceStartComboBox);
            this.Controls.Add(this.arousalEndComboBox);
            this.Controls.Add(this.arousalStartComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valenceLabel);
            this.Controls.Add(this.arousalLabel);
            this.Controls.Add(this.emotionLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmotionSelectControlPanel";
            this.Size = new System.Drawing.Size(211, 149);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label emotionLabel;
        private System.Windows.Forms.Label arousalLabel;
        private System.Windows.Forms.Label valenceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emotionTextBox;
        private System.Windows.Forms.ComboBox arousalStartComboBox;
        private System.Windows.Forms.ComboBox arousalEndComboBox;
        private System.Windows.Forms.ComboBox valenceStartComboBox;
        private System.Windows.Forms.ComboBox valenceEndComboBox;

    }
}
