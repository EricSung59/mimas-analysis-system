using System;
using System.Collections;
using System.Windows.Forms;
using AnalysisSystem.Controls;

namespace AnalysisSystem.Forms
{
    public partial class AnalysisSystemForm : Form
    {
        ArrayList _screens;

        //-------------------- CONSTRUCTOR ---------------------//

        public AnalysisSystemForm()
        {
            InitializeComponent();

            functionChoosingControlPanel.AnalysisSystemForm = this;
            edfConvertingControlPanel.AnalysisSystemForm = this;
            sampleEliminatingControlPanel.AnalysisSystemForm = this;
            icaProcessingControlPanel.AnalysisSystemForm = this;
            hfdCalculatingControlPanel.AnalysisSystemForm = this;
            emoMappingControlPanel.AnalysisSystemForm = this;

            _screens = new ArrayList();
            _screens.Add(edfConvertingControlPanel);
            _screens.Add(sampleEliminatingControlPanel);
            _screens.Add(icaProcessingControlPanel);
            _screens.Add(hfdCalculatingControlPanel);
            _screens.Add(emoMappingControlPanel);

            ShowScreen(4);
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

        public void ShowScreen(int index)
        {
            SetStatus("");

            if (index < _screens.Count)
            {
                for (int i = 0; i < _screens.Count; i++)
                {
                    if (i == index)
                    {
                        (_screens[i] as UserControl).Visible = true;
                        (functionChoosingControlPanel.ButtonList[i] as Button).Enabled = false;
                    }
                    else
                    {
                        (_screens[i] as UserControl).Visible = false;
                        (functionChoosingControlPanel.ButtonList[i] as Button).Enabled = true;
                    }
                }
            }
            else
            {
                SetStatus("This function is not implemented yet.");
            }
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

        public HfdCalculatingControlPanel HfdCalculatingControlPanel
        {
            get { return hfdCalculatingControlPanel; }
        }
    }
}