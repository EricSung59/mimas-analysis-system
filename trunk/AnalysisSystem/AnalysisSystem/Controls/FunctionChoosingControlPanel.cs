using System;
using System.Windows.Forms;
using AnalysisSystem.Forms;

namespace AnalysisSystem.Controls
{
    public partial class FunctionChoosingControlPanel : UserControl
    {
        AnalysisSystemForm _analysisSystemForm;
        Button _currentPressedButton;

        //----------------------- CONSTRUCTOR --------------------------//

        public FunctionChoosingControlPanel()
        {
            InitializeComponent();
        }

        //----------------------- EVENT HANDLERS -----------------------//

        private void functionButton_Click(object sender, EventArgs e)
        {
            if (_currentPressedButton != null)
            {
                _currentPressedButton.Enabled = true;
            }
            _analysisSystemForm.CurrentVisibleControlPanel.Visible = false;

            Button pressedButton = sender as Button;
            _currentPressedButton = pressedButton;
            _currentPressedButton.Enabled = false;

            if (pressedButton == edfConvertingButton)
            {
                _analysisSystemForm.CurrentVisibleControlPanel = _analysisSystemForm.EdfConvertingControlPanel;
            }
            else if (pressedButton == sampleEliminatingButton)
            {
                _analysisSystemForm.CurrentVisibleControlPanel = _analysisSystemForm.SampleEliminatingControlPanel;
            }
            else if (pressedButton == icaProcessingButton)
            {
                _analysisSystemForm.CurrentVisibleControlPanel = _analysisSystemForm.IcaProcessingControlPanel;
            }

            _analysisSystemForm.CurrentVisibleControlPanel.Visible = true;
        }

        //----------------------- PROPERTIES ---------------------------//

        public AnalysisSystemForm AnalysisSystemForm
        {
            get { return _analysisSystemForm; }
            set { _analysisSystemForm = value; }
        }

        public Button CurrentPressedButton
        {
            get { return _currentPressedButton; }
            set { _currentPressedButton = value; }
        }

        public Button EdfConvertingButton
        {
            get { return edfConvertingButton; }
        }

        public Button SampleEliminatingButton
        {
            get { return sampleEliminatingButton; }
        }

        public Button IcaProcessingButton
        {
            get { return icaProcessingButton; }
        }

        public Button HfdCalculatingButton
        {
            get { return hfdCalculatingButton; }
        }

        public Button EmoMappingButton
        {
            get { return emoMappingButton; }
        }

        public Button SvmTrainingButton
        {
            get { return svmTrainingButton; }
        }

        public Button TestButton
        {
            get { return testButton; }
        }
    }
}
