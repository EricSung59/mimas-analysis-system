using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using AnalysisSystem.Forms;

namespace AnalysisSystem.Controls
{
    public partial class EliminatingControlPanel : UserControl
    {
        AnalysisSystemDataContext _db = new AnalysisSystemDataContext();
        ArrayList goodSamples = new ArrayList();
        AnalysisSystemForm _analysisSystemForm;

        //------------------ CONSTRUCTOR -------------------//

        public EliminatingControlPanel()
        {
            InitializeComponent();
        }

        //------------------ EVENT HANDLERS ----------------//

        private void processButton_Click(object sender, EventArgs e)
        {
            double multiplier = 0.0;
            try
            {
                _analysisSystemForm.StatusLabel.Text = "Processing...";
                multiplier = Convert.ToDouble(inputTextBox.Text);
            }
            catch (FormatException fe)
            {
                _analysisSystemForm.StatusLabel.Text = "Multiplier is not right format";
                return;
            }

            doubleViewChoosingControlPanel.RightListView.Items.Clear();
            goodSamples.Clear();

            foreach (ListViewItem item in doubleViewChoosingControlPanel.LeftListView.Items)
            {
                String samArousalString = item.SubItems[1].Text;
                String samValenceString = item.SubItems[2].Text;
                String arousalString = item.SubItems[4].Text;
                String valenceString = item.SubItems[5].Text;
                String arousalSdString = item.SubItems[6].Text;
                String valenceSdString = item.SubItems[7].Text;

                double samArousalValue;
                double samValenceValue;
                double arousalValue;
                double valenceValue;
                double arousalSdValue;
                double valenceSdValue;

                if (!String.IsNullOrEmpty(samArousalString) && !String.IsNullOrEmpty(samValenceString))
                {
                    try
                    {
                        samArousalValue = Convert.ToDouble(samArousalString);
                        samValenceValue = Convert.ToDouble(samValenceString);
                    }
                    catch (FormatException fe)
                    {
                        _analysisSystemForm.StatusLabel.Text = "Error occur! Command terminated.";
                        return;
                    }

                    if (!String.IsNullOrEmpty(arousalString) &&
                        !String.IsNullOrEmpty(valenceString) &&
                        !String.IsNullOrEmpty(arousalSdString) &&
                        !String.IsNullOrEmpty(valenceSdString))
                    {
                        try
                        {
                            arousalValue = Convert.ToDouble(arousalString);
                            valenceValue = Convert.ToDouble(valenceString);
                            arousalSdValue = Convert.ToDouble(arousalSdString);
                            valenceSdValue = Convert.ToDouble(valenceSdString);
                        }
                        catch (FormatException fe)
                        {
                            _analysisSystemForm.StatusLabel.Text = "Error occur! Command terminated.";
                            return;
                        }

                        if (((samArousalValue >= arousalValue - multiplier * arousalSdValue) && (samArousalValue <= arousalValue + multiplier * arousalSdValue)) &&
                            ((samValenceValue >= valenceValue - multiplier * valenceSdValue) && (samValenceValue <= valenceValue + multiplier * valenceSdValue)))
                        {
                            goodSamples.Add(item.Text);

                            if (goodSampleRadioButton.Checked)
                            {
                                doubleViewChoosingControlPanel.RightListView.Items.Add(item.Clone() as ListViewItem);
                            }
                        }
                        else
                        {
                            if (badSampleRadioButton.Checked)
                            {
                                doubleViewChoosingControlPanel.RightListView.Items.Add(item.Clone() as ListViewItem);
                            }
                        }
                    }
                }
            }

            updateButton.Enabled = true;
            _analysisSystemForm.StatusLabel.Text = "Processing... Done";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            _analysisSystemForm.StatusLabel.Text = "Updating...";

            var dataQuery = 
                from samples
                in _db.Samples
                orderby samples.SID ascending
                select samples;

            foreach (var data in dataQuery)
            {
                bool found = false;

                while (true)
                {
                    if (goodSamples.Count <= 0)
                        break;

                    if (String.Compare(data.SID, goodSamples[0] as String) > 0)
                    {
                        goodSamples.RemoveAt(0);
                        continue;
                    }
                    else if (String.Compare(data.SID, goodSamples[0] as String) == 0)
                    {
                        found = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

                if (found)
                {
                    data.IsGood = true;
                }
                else
                {
                    data.IsGood = false;
                }
            }

            _db.SubmitChanges();
            _analysisSystemForm.StatusLabel.Text = "Updating... Done";
        }

        //------------------ PROPERTIES --------------------//

        public AnalysisSystemForm AnalysisSystemForm
        {
            get
            {
                return _analysisSystemForm;
            }
            set
            {
                _analysisSystemForm = value;
                doubleViewChoosingControlPanel.AnalysisSystemForm = value;
            }
        }

        public Button UpdateButton
        {
            get { return updateButton; }
        }
    }
}
