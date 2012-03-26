using System;
using System.Threading;
using System.Windows.Forms;
using AnalysisSystem.Controls;

namespace AnalysisSystem.Forms
{
    public partial class AnalysisSystemForm : Form
    {
        UserControl _currentVisibleControlPanel;
        bool statusTextChanged = false;

        //-------------------- CONSTRUCTOR ---------------------//

        public AnalysisSystemForm()
        {
            InitializeComponent();

            convertingControlPanel.AnalysisSystemForm = this;
            eliminatingControlPanel.AnalysisSystemForm = this;
            functionControlPanel.AnalysisSystemForm = this;

            _currentVisibleControlPanel = convertingControlPanel;
            convertingControlPanel.Visible = false;
            eliminatingControlPanel.Visible = true;
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

        public FunctionControlPanel FunctionControlPanel
        {
            get { return functionControlPanel; }
            set { functionControlPanel = value; }
        }
        public ConvertingControlPanel ConvertingControlPanel
        {
            get { return convertingControlPanel; }
            set { convertingControlPanel = value; }
        }
        public EliminatingControlPanel EliminatingControlPanel
        {
            get { return eliminatingControlPanel; }
            set { eliminatingControlPanel = value; }
        }
        public Label StatusLabel
        {
            get { return statusLabel; }
            set { statusLabel = value; }
        }
        public UserControl CurrentVisibleControlPanel
        {
            get { return _currentVisibleControlPanel; }
            set { _currentVisibleControlPanel = value; }
        }
    }
}