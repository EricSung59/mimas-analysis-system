namespace AnalysisSystem.Controls
{
    partial class ConvertingControlPanel
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
            this.choosingControlPanel1 = new AnalysisSystem.Controls.ChoosingControlPanel();
            this.SuspendLayout();
            // 
            // choosingControlPanel1
            // 
            this.choosingControlPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choosingControlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.choosingControlPanel1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosingControlPanel1.Location = new System.Drawing.Point(0, 0);
            this.choosingControlPanel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.choosingControlPanel1.Name = "choosingControlPanel1";
            this.choosingControlPanel1.Size = new System.Drawing.Size(1083, 467);
            this.choosingControlPanel1.TabIndex = 1;
            // 
            // ConvertingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.choosingControlPanel1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ConvertingControlPanel";
            this.Size = new System.Drawing.Size(1083, 508);
            this.ResumeLayout(false);

        }

        #endregion

        private ChoosingControlPanel choosingControlPanel1;

    }
}
