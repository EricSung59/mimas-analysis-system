using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnalysisSystem.Controls
{
    public partial class OutFolderChooserControlPanel : UserControl
    {
        //----------------------- CONSTRUCTOR ----------------------//

        public OutFolderChooserControlPanel()
        {
            InitializeComponent();
        }

        //----------------------- EVENT HANDLERS -------------------//

        private void outFolderBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outFolderTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        //----------------------- PROPERTIES -----------------------//

        public Button BrowseButton
        {
            get { return outFolderBrowseButton; }
        }

        public TextBox OutFolderPathTextBox
        {
            get { return outFolderTextBox; }
        }
    }
}
