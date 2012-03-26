using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using AnalysisSystem.Forms;
using System.Threading;

namespace AnalysisSystem.Controls
{
    public partial class EliminatingControlPanel : UserControl
    {
        AnalysisSystemDataContext _db = new AnalysisSystemDataContext();
        ArrayList _goodSamples = new ArrayList();
        ArrayList _badSamples = new ArrayList();
        ArrayList _faultSamples = new ArrayList();
        AnalysisSystemForm _analysisSystemForm;

        //------------------ CONSTRUCTOR -------------------//

        public EliminatingControlPanel()
        {
            InitializeComponent();

            doubleViewChoosingControlPanel.SelectComplete += new EventHandler(doubleViewChoosingControlPanel_SelectComplete);
        }

        //------------------ EVENT HANDLERS ----------------//

        private void processButton_Click(object sender, EventArgs e)
        {
            double multiplier = 0.0;
            try
            {
                _analysisSystemForm.SetStatus("Processing...");
                multiplier = Convert.ToDouble(inputTextBox.Text);
            }
            catch (FormatException fe)
            {
                _analysisSystemForm.SetStatus("Multiplier is not right format");
                return;
            }

            doubleViewChoosingControlPanel.RightListView.Items.Clear();
            _goodSamples.Clear();
            _badSamples.Clear();
            _faultSamples.Clear();

            badSampleRadioButton.Enabled = false;
            goodSampleRadioButton.Enabled = false;

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
                        _analysisSystemForm.SetStatus("Error occur! Command terminated.");
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
                            _analysisSystemForm.SetStatus("Error occur! Command terminated.");
                            return;
                        }

                        if (((samArousalValue >= arousalValue - multiplier * arousalSdValue) && (samArousalValue <= arousalValue + multiplier * arousalSdValue)) &&
                            ((samValenceValue >= valenceValue - multiplier * valenceSdValue) && (samValenceValue <= valenceValue + multiplier * valenceSdValue)))
                        {
                            _goodSamples.Add(item.Text);

                            if (goodSampleRadioButton.Checked)
                            {
                                doubleViewChoosingControlPanel.RightListView.Items.Add(item.Clone() as ListViewItem);
                            }
                        }
                        else
                        {
                            _badSamples.Add(item.Text);

                            if (badSampleRadioButton.Checked)
                            {
                                doubleViewChoosingControlPanel.RightListView.Items.Add(item.Clone() as ListViewItem);
                            }
                        }
                    }
                    else
                    {
                        _faultSamples.Add(item.Text);
                    }
                }
                else
                {
                    _faultSamples.Add(item.Text);
                }
            }

            badSampleRadioButton.Enabled = true;
            goodSampleRadioButton.Enabled = true;

            updateLeftListViewGroupBox();
            updateRightListViewGroupBox();

            updateButton.Enabled = true;
            _analysisSystemForm.SetStatus("Processing... Done");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            _analysisSystemForm.SetStatus("Updating...");

            var dataQuery =
                from samples
                in _db.Samples
                orderby samples.SID ascending
                select samples;

            ArrayList leftListViewItemsCloneList = new ArrayList();
            foreach (ListViewItem item in doubleViewChoosingControlPanel.LeftListView.Items)
            {
                leftListViewItemsCloneList.Add(item.Text);
            }
            leftListViewItemsCloneList.Sort();
            
            foreach (var data in dataQuery)
            {
                if (FindUtils.Find(leftListViewItemsCloneList, data.SID))
                {
                    if (FindUtils.Find(_goodSamples, data.SID))
                    {
                        data.IsGood = true;
                    }
                    else
                    {
                        data.IsGood = false;
                    }
                }
            }
            _db.SubmitChanges();
            _analysisSystemForm.SetStatus("Updating... Done");
        }

        private void doubleViewChoosingControlPanel_SelectComplete(object sender, EventArgs e)
        {
            _goodSamples.Clear();
            _badSamples.Clear();
            _faultSamples.Clear();

            updateLeftListViewGroupBox();
            updateRightListViewGroupBox();
        }

        //------------------ PRIVATE HELPERS ---------------//

        private void updateLeftListViewGroupBox()
        {
            leftListViewGroupBoxTotalLabel.Text = "Total: " + doubleViewChoosingControlPanel.LeftListView.Items.Count;
        }

        private void updateRightListViewGroupBox()
        {
            rightListViewGroupBoxGoodLabel.Text = "Good: " + _goodSamples.Count.ToString();
            rightListViewGroupBoxBadLabel.Text = "Bad: " + _badSamples.Count.ToString();
            rightListViewGroupBoxFaultLabel.Text = "Fault: " + _faultSamples.Count.ToString();
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

        public ArrayList GoodSamples
        {
            get { return _goodSamples; }
        }

        public ArrayList BadSamples
        {
            get { return _badSamples; }
        }
    }
}
