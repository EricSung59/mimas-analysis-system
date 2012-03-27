using System;
using System.Threading;
using System.Windows.Forms;
using AnalysisSystem.Controls;

namespace AnalysisSystem.Forms
{
    public partial class AnalysisSystemForm : Form
    {
        UserControl _currentVisibleControlPanel;

        //-------------------- CONSTRUCTOR ---------------------//

        public AnalysisSystemForm()
        {
            InitializeComponent();

            edfConvertingControlPanel.AnalysisSystemForm = this;
            sampleEliminatingControlPanel.AnalysisSystemForm = this;
            functionChoosingControlPanel.AnalysisSystemForm = this;
            icaProcessingControlPanel.AnalysisSystemForm = this;

            _currentVisibleControlPanel = icaProcessingControlPanel;
            _currentVisibleControlPanel.Visible = true;

            functionChoosingControlPanel.CurrentPressedButton = functionChoosingControlPanel.IcaProcessingButton;
            functionChoosingControlPanel.CurrentPressedButton.Enabled = false;
        }

        //-------------------- EVENT HANDLERS ------------------//

        private void statusLabel_TextChanged(object sender, EventArgs e)
        {
            //statusTextChanged = true;
        }

        //-------------------- PUBLIC METHODS ------------------//

        public void SetStatus(String status)
        {
            statusLabel.Text = "Status: " + status;
            //statusTextChanged = false;
            //while (statusTextChanged == false) ;
        }

        //-------------------- PROPERTIES ----------------------//

        public FunctionChoosingControlPanel FunctionChoosingControlPanel
        {
            get { return functionChoosingControlPanel; }
        }

        public EdfConvertingControlPanel EdfConvertingControlPanel
        {
            get { return edfConvertingControlPanel; }
        }

        public SampleEliminatingControlPanel SampleEliminatingControlPanel
        {
            get { return sampleEliminatingControlPanel; }
        }

        public IcaProcessingControlPanel IcaProcessingControlPanel
        {
            get { return icaProcessingControlPanel; }
        }
        
        public UserControl CurrentVisibleControlPanel
        {
            get { return _currentVisibleControlPanel; }
            set { _currentVisibleControlPanel = value; }
        }
    }
}