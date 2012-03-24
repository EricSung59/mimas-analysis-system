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
            this.SuspendLayout();
            // 
            // selectSampleButton
            // 
            this.selectSampleButton.AutoSize = true;
            this.selectSampleButton.Location = new System.Drawing.Point(4, 6);
            this.selectSampleButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.selectSampleButton.Name = "selectSampleButton";
            this.selectSampleButton.Size = new System.Drawing.Size(152, 40);
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
            this.listView.Location = new System.Drawing.Point(4, 58);
            this.listView.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(635, 403);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // ChoosingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.listView);
            this.Controls.Add(this.selectSampleButton);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ChoosingControlPanel";
            this.Size = new System.Drawing.Size(644, 467);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectSampleButton;
        private System.Windows.Forms.ListView listView;
    }
}
