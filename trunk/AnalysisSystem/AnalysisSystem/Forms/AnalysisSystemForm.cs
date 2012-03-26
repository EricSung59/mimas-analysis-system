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

            _currentVisibleControlPanel = sampleEliminatingControlPanel;
            edfConvertingControlPanel.Visible = false;
            sampleEliminatingControlPanel.Visible = true;

            functionChoosingControlPanel.CurrentPressedButton = functionChoosingControlPanel.SampleEliminatingButton;
            functionChoosingControlPanel.SampleEliminatingButton.Enabled = false;
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
            set { functionChoosingControlPanel = value; }
        }

        public EdfConvertingControlPanel EdfConvertingControlPanel
        {
            get { return edfConvertingControlPanel; }
            set { edfConvertingControlPanel = value; }
        }

        public SampleEliminatingControlPanel SampleEliminatingControlPanel
        {
            get { return sampleEliminatingControlPanel; }
            set { sampleEliminatingControlPanel = value; }
        }
        
        public UserControl CurrentVisibleControlPanel
        {
            get { return _currentVisibleControlPanel; }
            set { _currentVisibleControlPanel = value; }
        }
    }
}