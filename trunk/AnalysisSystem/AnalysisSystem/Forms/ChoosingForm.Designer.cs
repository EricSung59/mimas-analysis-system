namespace AnalysisSystem.Forms
{
    partial class ChoosingForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.deselectAllButton = new System.Windows.Forms.Button();
            this.volunteerIdGroupBox = new System.Windows.Forms.GroupBox();
            this.volunteerIdPullOutOneButton = new System.Windows.Forms.Button();
            this.volunteerIdPullOutAllButton = new System.Windows.Forms.Button();
            this.volunteerIdPushInOneButton = new System.Windows.Forms.Button();
            this.volunteerIdPushInAllButton = new System.Windows.Forms.Button();
            this.volunteerIdInListBox = new System.Windows.Forms.ListBox();
            this.volunteerIdOutListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureIdPullOutOneButton = new System.Windows.Forms.Button();
            this.pictureIdPullOutAllButton = new System.Windows.Forms.Button();
            this.pictureIdPushInOneButton = new System.Windows.Forms.Button();
            this.pictureIdPushInAllButton = new System.Windows.Forms.Button();
            this.pictureIdInListBox = new System.Windows.Forms.ListBox();
            this.pictureIdOutListBox = new System.Windows.Forms.ListBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.volunteerIdGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.AutoSize = true;
            this.okButton.Location = new System.Drawing.Point(731, 591);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(79, 33);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(816, 591);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(79, 33);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(519, 550);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_ItemSelectionChanged);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectAllButton.AutoSize = true;
            this.selectAllButton.Location = new System.Drawing.Point(12, 591);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(88, 33);
            this.selectAllButton.TabIndex = 3;
            this.selectAllButton.Text = "Select all";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // deselectAllButton
            // 
            this.deselectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deselectAllButton.AutoSize = true;
            this.deselectAllButton.Location = new System.Drawing.Point(106, 591);
            this.deselectAllButton.Name = "deselectAllButton";
            this.deselectAllButton.Size = new System.Drawing.Size(107, 33);
            this.deselectAllButton.TabIndex = 4;
            this.deselectAllButton.Text = "Deselect all";
            this.deselectAllButton.UseVisualStyleBackColor = true;
            this.deselectAllButton.Click += new System.EventHandler(this.deselectAllButton_Click);
            // 
            // volunteerIdGroupBox
            // 
            this.volunteerIdGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volunteerIdGroupBox.Controls.Add(this.volunteerIdPullOutOneButton);
            this.volunteerIdGroupBox.Controls.Add(this.volunteerIdPullOutAllButton);
            this.volunteerIdGroupBox.Controls.Add(this.volunteerIdPushInOneButton);
            this.volunteerIdGroupBox.Controls.Add(this.volunteerIdPushInAllButton);
            this.volunteerIdGroupBox.Controls.Add(this.volunteerIdInListBox);
            this.volunteerIdGroupBox.Controls.Add(this.volunteerIdOutListBox);
            this.volunteerIdGroupBox.Location = new System.Drawing.Point(538, 12);
            this.volunteerIdGroupBox.Name = "volunteerIdGroupBox";
            this.volunteerIdGroupBox.Size = new System.Drawing.Size(357, 270);
            this.volunteerIdGroupBox.TabIndex = 5;
            this.volunteerIdGroupBox.TabStop = false;
            this.volunteerIdGroupBox.Text = "Volunteer ID";
            // 
            // volunteerIdPullOutOneButton
            // 
            this.volunteerIdPullOutOneButton.AutoSize = true;
            this.volunteerIdPullOutOneButton.Location = new System.Drawing.Point(159, 162);
            this.volunteerIdPullOutOneButton.Name = "volunteerIdPullOutOneButton";
            this.volunteerIdPullOutOneButton.Size = new System.Drawing.Size(38, 33);
            this.volunteerIdPullOutOneButton.TabIndex = 5;
            this.volunteerIdPullOutOneButton.Text = "<";
            this.volunteerIdPullOutOneButton.UseVisualStyleBackColor = true;
            this.volunteerIdPullOutOneButton.Click += new System.EventHandler(this.volunteerIdPullOutOneButton_Click);
            // 
            // volunteerIdPullOutAllButton
            // 
            this.volunteerIdPullOutAllButton.AutoSize = true;
            this.volunteerIdPullOutAllButton.Location = new System.Drawing.Point(159, 201);
            this.volunteerIdPullOutAllButton.Name = "volunteerIdPullOutAllButton";
            this.volunteerIdPullOutAllButton.Size = new System.Drawing.Size(38, 33);
            this.volunteerIdPullOutAllButton.TabIndex = 4;
            this.volunteerIdPullOutAllButton.Text = "<<";
            this.volunteerIdPullOutAllButton.UseVisualStyleBackColor = true;
            this.volunteerIdPullOutAllButton.Click += new System.EventHandler(this.volunteerIdPullOutAllButton_Click);
            // 
            // volunteerIdPushInOneButton
            // 
            this.volunteerIdPushInOneButton.AutoSize = true;
            this.volunteerIdPushInOneButton.Location = new System.Drawing.Point(159, 48);
            this.volunteerIdPushInOneButton.Name = "volunteerIdPushInOneButton";
            this.volunteerIdPushInOneButton.Size = new System.Drawing.Size(38, 33);
            this.volunteerIdPushInOneButton.TabIndex = 3;
            this.volunteerIdPushInOneButton.Text = ">";
            this.volunteerIdPushInOneButton.UseVisualStyleBackColor = true;
            this.volunteerIdPushInOneButton.Click += new System.EventHandler(this.volunteerIdPushInOneButton_Click);
            // 
            // volunteerIdPushInAllButton
            // 
            this.volunteerIdPushInAllButton.AutoSize = true;
            this.volunteerIdPushInAllButton.Location = new System.Drawing.Point(159, 87);
            this.volunteerIdPushInAllButton.Name = "volunteerIdPushInAllButton";
            this.volunteerIdPushInAllButton.Size = new System.Drawing.Size(38, 33);
            this.volunteerIdPushInAllButton.TabIndex = 2;
            this.volunteerIdPushInAllButton.Text = ">>";
            this.volunteerIdPushInAllButton.UseVisualStyleBackColor = true;
            this.volunteerIdPushInAllButton.Click += new System.EventHandler(this.volunteerIdPushInAllButton_Click);
            // 
            // volunteerIdInListBox
            // 
            this.volunteerIdInListBox.FormattingEnabled = true;
            this.volunteerIdInListBox.ItemHeight = 23;
            this.volunteerIdInListBox.Location = new System.Drawing.Point(230, 30);
            this.volunteerIdInListBox.Name = "volunteerIdInListBox";
            this.volunteerIdInListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.volunteerIdInListBox.Size = new System.Drawing.Size(120, 234);
            this.volunteerIdInListBox.Sorted = true;
            this.volunteerIdInListBox.TabIndex = 1;
            this.volunteerIdInListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.volunteerIdInListBox_MouseDoubleClick);
            // 
            // volunteerIdOutListBox
            // 
            this.volunteerIdOutListBox.FormattingEnabled = true;
            this.volunteerIdOutListBox.ItemHeight = 23;
            this.volunteerIdOutListBox.Location = new System.Drawing.Point(6, 29);
            this.volunteerIdOutListBox.Name = "volunteerIdOutListBox";
            this.volunteerIdOutListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.volunteerIdOutListBox.Size = new System.Drawing.Size(120, 234);
            this.volunteerIdOutListBox.Sorted = true;
            this.volunteerIdOutListBox.TabIndex = 0;
            this.volunteerIdOutListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.volunteerIdOutListBox_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureIdPullOutOneButton);
            this.groupBox1.Controls.Add(this.pictureIdPullOutAllButton);
            this.groupBox1.Controls.Add(this.pictureIdPushInOneButton);
            this.groupBox1.Controls.Add(this.pictureIdPushInAllButton);
            this.groupBox1.Controls.Add(this.pictureIdInListBox);
            this.groupBox1.Controls.Add(this.pictureIdOutListBox);
            this.groupBox1.Location = new System.Drawing.Point(538, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 270);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture ID";
            // 
            // pictureIdPullOutOneButton
            // 
            this.pictureIdPullOutOneButton.AutoSize = true;
            this.pictureIdPullOutOneButton.Location = new System.Drawing.Point(159, 162);
            this.pictureIdPullOutOneButton.Name = "pictureIdPullOutOneButton";
            this.pictureIdPullOutOneButton.Size = new System.Drawing.Size(38, 33);
            this.pictureIdPullOutOneButton.TabIndex = 5;
            this.pictureIdPullOutOneButton.Text = "<";
            this.pictureIdPullOutOneButton.UseVisualStyleBackColor = true;
            this.pictureIdPullOutOneButton.Click += new System.EventHandler(this.pictureIdPullOutOneButton_Click);
            // 
            // pictureIdPullOutAllButton
            // 
            this.pictureIdPullOutAllButton.AutoSize = true;
            this.pictureIdPullOutAllButton.Location = new System.Drawing.Point(159, 201);
            this.pictureIdPullOutAllButton.Name = "pictureIdPullOutAllButton";
            this.pictureIdPullOutAllButton.Size = new System.Drawing.Size(38, 33);
            this.pictureIdPullOutAllButton.TabIndex = 4;
            this.pictureIdPullOutAllButton.Text = "<<";
            this.pictureIdPullOutAllButton.UseVisualStyleBackColor = true;
            this.pictureIdPullOutAllButton.Click += new System.EventHandler(this.pictureIdPullOutAllButton_Click);
            // 
            // pictureIdPushInOneButton
            // 
            this.pictureIdPushInOneButton.AutoSize = true;
            this.pictureIdPushInOneButton.Location = new System.Drawing.Point(159, 48);
            this.pictureIdPushInOneButton.Name = "pictureIdPushInOneButton";
            this.pictureIdPushInOneButton.Size = new System.Drawing.Size(38, 33);
            this.pictureIdPushInOneButton.TabIndex = 3;
            this.pictureIdPushInOneButton.Text = ">";
            this.pictureIdPushInOneButton.UseVisualStyleBackColor = true;
            this.pictureIdPushInOneButton.Click += new System.EventHandler(this.pictureIdPushInOneButton_Click);
            // 
            // pictureIdPushInAllButton
            // 
            this.pictureIdPushInAllButton.AutoSize = true;
            this.pictureIdPushInAllButton.Location = new System.Drawing.Point(159, 87);
            this.pictureIdPushInAllButton.Name = "pictureIdPushInAllButton";
            this.pictureIdPushInAllButton.Size = new System.Drawing.Size(38, 33);
            this.pictureIdPushInAllButton.TabIndex = 2;
            this.pictureIdPushInAllButton.Text = ">>";
            this.pictureIdPushInAllButton.UseVisualStyleBackColor = true;
            this.pictureIdPushInAllButton.Click += new System.EventHandler(this.pictureIdPushInAllButton_Click);
            // 
            // pictureIdInListBox
            // 
            this.pictureIdInListBox.FormattingEnabled = true;
            this.pictureIdInListBox.ItemHeight = 23;
            this.pictureIdInListBox.Location = new System.Drawing.Point(230, 30);
            this.pictureIdInListBox.Name = "pictureIdInListBox";
            this.pictureIdInListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.pictureIdInListBox.Size = new System.Drawing.Size(120, 234);
            this.pictureIdInListBox.Sorted = true;
            this.pictureIdInListBox.TabIndex = 1;
            this.pictureIdInListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureIdInListBox_MouseDoubleClick);
            // 
            // pictureIdOutListBox
            // 
            this.pictureIdOutListBox.FormattingEnabled = true;
            this.pictureIdOutListBox.ItemHeight = 23;
            this.pictureIdOutListBox.Location = new System.Drawing.Point(6, 29);
            this.pictureIdOutListBox.Name = "pictureIdOutListBox";
            this.pictureIdOutListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.pictureIdOutListBox.Size = new System.Drawing.Size(120, 234);
            this.pictureIdOutListBox.Sorted = true;
            this.pictureIdOutListBox.TabIndex = 0;
            this.pictureIdOutListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureIdOutListBox_MouseDoubleClick);
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Location = new System.Drawing.Point(0, 645);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(907, 26);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Status:";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChoosingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 671);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.volunteerIdGroupBox);
            this.Controls.Add(this.deselectAllButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ChoosingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choosing Form";
            this.volunteerIdGroupBox.ResumeLayout(false);
            this.volunteerIdGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button deselectAllButton;
        private System.Windows.Forms.GroupBox volunteerIdGroupBox;
        private System.Windows.Forms.Button volunteerIdPullOutOneButton;
        private System.Windows.Forms.Button volunteerIdPullOutAllButton;
        private System.Windows.Forms.Button volunteerIdPushInOneButton;
        private System.Windows.Forms.Button volunteerIdPushInAllButton;
        private System.Windows.Forms.ListBox volunteerIdInListBox;
        private System.Windows.Forms.ListBox volunteerIdOutListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pictureIdPullOutOneButton;
        private System.Windows.Forms.Button pictureIdPullOutAllButton;
        private System.Windows.Forms.Button pictureIdPushInOneButton;
        private System.Windows.Forms.Button pictureIdPushInAllButton;
        private System.Windows.Forms.ListBox pictureIdInListBox;
        private System.Windows.Forms.ListBox pictureIdOutListBox;
        private System.Windows.Forms.Label statusLabel;
    }
}