using System;
using System.Collections;
using System.Windows.Forms;
using AnalysisSystem.Forms;

namespace AnalysisSystem.Controls
{
    public partial class FunctionChoosingControlPanel : UserControl
    {
        AnalysisSystemForm _analysisSystemForm;
        Button _currentPressedButton;
        ArrayList _buttons;

        //----------------------- CONSTRUCTOR --------------------------//

        public FunctionChoosingControlPanel()
        {
            InitializeComponent();

            _buttons = new ArrayList();
            _buttons.Add(edfConvertingButton);
            _buttons.Add(sampleEliminatingButton);
            _buttons.Add(icaProcessingButton);
            _buttons.Add(hfdCalculatingButton);
            _buttons.Add(emoMappingButton);
            _buttons.Add(svmTrainingButton);
            _buttons.Add(testButton);
        }

        //----------------------- EVENT HANDLERS -----------------------//

        private void functionButton_Click(object sender, EventArgs e)
        {
            _analysisSystemForm.SetStatus("");

            int index = _buttons.IndexOf(sender as Button);
            if (index == -1)
            {
                _analysisSystemForm.SetStatus("This button is not found in Buttons List");
            }
            else
            {
                _analysisSystemForm.ShowScreen(index);
            }
        }

        //----------------------- PROPERTIES ---------------------------//

        public AnalysisSystemForm AnalysisSystemForm
        {
            get { return _analysisSystemForm; }
            set { _analysisSystemForm = value; }
        }

        public ArrayList ButtonList
        {
            get { return _buttons; }
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
