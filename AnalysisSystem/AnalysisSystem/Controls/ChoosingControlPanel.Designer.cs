namespace AnalysisSystem.Controls
{
    partial class ChoosingControlPanel
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
            this.selectSampleButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel_00 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.onlyGoodSampleCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel_00.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectSampleButton
            // 
            this.selectSampleButton.AutoSize = true;
            this.selectSampleButton.Location = new System.Drawing.Point(3, 1);
            this.selectSampleButton.Margin = new System.Windows.Forms.Padding(0);
            this.selectSampleButton.Name = "selectSampleButton";
            this.selectSampleButton.Size = new System.Drawing.Size(152, 33);
            this.selectSampleButton.TabIndex = 0;
            this.selectSampleButton.Text = "Select Sample  ID";
            this.selectSampleButton.UseVisualStyleBackColor = true;
            this.selectSampleButton.Click += new System.EventHandler(this.selectSampleButton_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(3, 44);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(905, 422);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // tableLayoutPanel_00
            // 
            this.tableLayoutPanel_00.ColumnCount = 1;
            this.tableLayoutPanel_00.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00.Controls.Add(this.listView, 0, 1);
            this.tableLayoutPanel_00.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel_00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_00.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_00.Name = "tableLayoutPanel_00";
            this.tableLayoutPanel_00.RowCount = 2;
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_00.Size = new System.Drawing.Size(911, 469);
            this.tableLayoutPanel_00.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.onlyGoodSampleCheckBox);
            this.panel1.Controls.Add(this.selectSampleButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 35);
            this.panel1.TabIndex = 2;
            // 
            // onlyGoodSampleCheckBox
            // 
            this.onlyGoodSampleCheckBox.AutoSize = true;
            this.onlyGoodSampleCheckBox.Checked = true;
            this.onlyGoodSampleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onlyGoodSampleCheckBox.Location = new System.Drawing.Point(158, 5);
            this.onlyGoodSampleCheckBox.Name = "onlyGoodSampleCheckBox";
            this.onlyGoodSampleCheckBox.Size = new System.Drawing.Size(180, 27);
            this.onlyGoodSampleCheckBox.TabIndex = 1;
            this.onlyGoodSampleCheckBox.Text = "Only Good Samples";
            this.onlyGoodSampleCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChoosingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel_00);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChoosingControlPanel";
            this.Size = new System.Drawing.Size(911, 469);
            this.tableLayoutPanel_00.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectSampleButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_00;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox onlyGoodSampleCheckBox;
    }
}
