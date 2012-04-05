namespace AnalysisSystem.Controls
{
    partial class EmoSelectControlPanel
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
            this.EmoLabel = new System.Windows.Forms.Label();
            this.MinALabel = new System.Windows.Forms.Label();
            this.MinVLabel = new System.Windows.Forms.Label();
            this.MaxALabel = new System.Windows.Forms.Label();
            this.MaxVLabel = new System.Windows.Forms.Label();
            this.MinACombobox = new System.Windows.Forms.ComboBox();
            this.MaxACombobox = new System.Windows.Forms.ComboBox();
            this.MinVCombobox = new System.Windows.Forms.ComboBox();
            this.MaxVCombobox = new System.Windows.Forms.ComboBox();
            this.EmoTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EmoLabel
            // 
            this.EmoLabel.AutoSize = true;
            this.EmoLabel.Location = new System.Drawing.Point(3, 10);
            this.EmoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmoLabel.Name = "EmoLabel";
            this.EmoLabel.Size = new System.Drawing.Size(68, 20);
            this.EmoLabel.TabIndex = 1;
            this.EmoLabel.Text = "Emotion";
            // 
            // MinALabel
            // 
            this.MinALabel.AutoSize = true;
            this.MinALabel.Location = new System.Drawing.Point(3, 53);
            this.MinALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinALabel.Name = "MinALabel";
            this.MinALabel.Size = new System.Drawing.Size(28, 20);
            this.MinALabel.TabIndex = 2;
            this.MinALabel.Text = "A :";
            // 
            // MinVLabel
            // 
            this.MinVLabel.AutoSize = true;
            this.MinVLabel.Location = new System.Drawing.Point(3, 95);
            this.MinVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinVLabel.Name = "MinVLabel";
            this.MinVLabel.Size = new System.Drawing.Size(28, 20);
            this.MinVLabel.TabIndex = 3;
            this.MinVLabel.Text = "V: ";
            // 
            // MaxALabel
            // 
            this.MaxALabel.AutoSize = true;
            this.MaxALabel.Location = new System.Drawing.Point(97, 54);
            this.MaxALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxALabel.Name = "MaxALabel";
            this.MaxALabel.Size = new System.Drawing.Size(19, 20);
            this.MaxALabel.TabIndex = 4;
            this.MaxALabel.Text = "--";
            // 
            // MaxVLabel
            // 
            this.MaxVLabel.AutoSize = true;
            this.MaxVLabel.Location = new System.Drawing.Point(97, 96);
            this.MaxVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxVLabel.Name = "MaxVLabel";
            this.MaxVLabel.Size = new System.Drawing.Size(19, 20);
            this.MaxVLabel.TabIndex = 5;
            this.MaxVLabel.Text = "--";
            // 
            // MinACombobox
            // 
            this.MinACombobox.FormattingEnabled = true;
            this.MinACombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.MinACombobox.Location = new System.Drawing.Point(44, 50);
            this.MinACombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinACombobox.Name = "MinACombobox";
            this.MinACombobox.Size = new System.Drawing.Size(44, 28);
            this.MinACombobox.TabIndex = 6;
            this.MinACombobox.SelectedValueChanged += new System.EventHandler(this.MinACombobox_SelectedIndexChanged);
            this.MinACombobox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // MaxACombobox
            // 
            this.MaxACombobox.FormattingEnabled = true;
            this.MaxACombobox.Location = new System.Drawing.Point(125, 50);
            this.MaxACombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaxACombobox.Name = "MaxACombobox";
            this.MaxACombobox.Size = new System.Drawing.Size(43, 28);
            this.MaxACombobox.TabIndex = 7;
            this.MaxACombobox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // MinVCombobox
            // 
            this.MinVCombobox.FormattingEnabled = true;
            this.MinVCombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.MinVCombobox.Location = new System.Drawing.Point(44, 92);
            this.MinVCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinVCombobox.Name = "MinVCombobox";
            this.MinVCombobox.Size = new System.Drawing.Size(43, 28);
            this.MinVCombobox.TabIndex = 8;
            this.MinVCombobox.SelectedValueChanged += new System.EventHandler(this.MinVCombobox_SelectedValueChanged);
            this.MinVCombobox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // MaxVCombobox
            // 
            this.MaxVCombobox.FormattingEnabled = true;
            this.MaxVCombobox.Location = new System.Drawing.Point(126, 92);
            this.MaxVCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaxVCombobox.Name = "MaxVCombobox";
            this.MaxVCombobox.Size = new System.Drawing.Size(43, 28);
            this.MaxVCombobox.TabIndex = 9;
            this.MaxVCombobox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // EmoTextbox
            // 
            this.EmoTextbox.Location = new System.Drawing.Point(95, 10);
            this.EmoTextbox.Name = "EmoTextbox";
            this.EmoTextbox.ReadOnly = true;
            this.EmoTextbox.Size = new System.Drawing.Size(42, 26);
            this.EmoTextbox.TabIndex = 10;
            // 
            // EmoSelectControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.EmoTextbox);
            this.Controls.Add(this.MaxVCombobox);
            this.Controls.Add(this.MinVCombobox);
            this.Controls.Add(this.MaxACombobox);
            this.Controls.Add(this.MinACombobox);
            this.Controls.Add(this.MaxVLabel);
            this.Controls.Add(this.MaxALabel);
            this.Controls.Add(this.MinVLabel);
            this.Controls.Add(this.MinALabel);
            this.Controls.Add(this.EmoLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmoSelectControlPanel";
            this.Size = new System.Drawing.Size(173, 128);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label EmoLabel;
        private System.Windows.Forms.Label MinALabel;
        private System.Windows.Forms.Label MinVLabel;
        private System.Windows.Forms.Label MaxALabel;
        private System.Windows.Forms.Label MaxVLabel;
        public System.Windows.Forms.TextBox EmoTextbox;
        public System.Windows.Forms.ComboBox MinACombobox;
        public System.Windows.Forms.ComboBox MaxACombobox;
        public System.Windows.Forms.ComboBox MinVCombobox;
        public System.Windows.Forms.ComboBox MaxVCombobox;

    }
}
