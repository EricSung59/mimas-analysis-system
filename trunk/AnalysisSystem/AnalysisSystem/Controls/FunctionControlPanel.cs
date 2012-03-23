using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnalysisSystem.Forms;

namespace AnalysisSystem.Controls
{
    public partial class FunctionControlPanel : UserControl
    {
        AnalysisSystemForm _analysisSystemForm;
        public AnalysisSystemForm AnalysisSystemForm
        {
            get { return _analysisSystemForm; }
            set { _analysisSystemForm = value; }
        }

        Button _currentPressedButton = null;

        public FunctionControlPanel()
        {
            InitializeComponent();
        }

        public FunctionControlPanel(AnalysisSystemForm form)
            : this()
        {
            _analysisSystemForm = form;
        }

        private void convertingButton_Click(object sender, EventArgs e)
        {

            _analysisSystemForm.CurrentVisibleControlPanel.Visible = false;
            _analysisSystemForm.ConvertingControlPanel.Visible = true;
            _analysisSystemForm.CurrentVisibleControlPanel = _analysisSystemForm.ConvertingControlPanel;

            if (_currentPressedButton != null)
                _currentPressedButton.Enabled = true;
            _currentPressedButton = convertingButton;
            _currentPressedButton.Enabled = false;
        }

        private void eliminatingButton_Click(object sender, EventArgs e)
        {
            _analysisSystemForm.CurrentVisibleControlPanel.Visible = false;
            _analysisSystemForm.EliminatingControlPanel.Visible = true;
            _analysisSystemForm.CurrentVisibleControlPanel = _analysisSystemForm.EliminatingControlPanel;

            if (_currentPressedButton != null)
                _currentPressedButton.Enabled = true;
            _currentPressedButton = eliminatingButton;
            _currentPressedButton.Enabled = false;
        }
    }
}
