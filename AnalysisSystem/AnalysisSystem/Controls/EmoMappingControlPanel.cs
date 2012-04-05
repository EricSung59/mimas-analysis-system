using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnalysisSystem.Forms;
using System.Collections;

namespace AnalysisSystem.Controls
{
    public partial class EmoMappingControlPanel : UserControl
    {
        private AnalysisSystemForm _analysisSytemForm;
        ArrayList emoSelectControlPanel = new ArrayList();
        ArrayList selectedSample = new ArrayList();
        AnalysisSystemDataContext _db = new AnalysisSystemDataContext();

        public EmoMappingControlPanel()
        {
            InitializeComponent();

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int ArousalColumNumber;
            int ValenceRowNumber;
            EmoPanel.Controls.Clear();
            try
            {
                ArousalColumNumber = Convert.ToInt32(AQuantityCombobox.Text);
                ValenceRowNumber = Convert.ToInt32(VQuantityCombobox.Text);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Multiplier is not right format", "Error");
                return;
            }
            if (ArousalColumNumber <= 9 && ArousalColumNumber >= 0 &&

                ValenceRowNumber <= 9 && ValenceRowNumber >= 0)
            {
                for (int j = 0; j < ArousalColumNumber; j++)
                {
                    for (int i = 0; i < ValenceRowNumber; i++)
                    {

                        //emoSelectControlPanel[i*ArousalColumNumber+j] = new EmoSelectControlPanel(this, i * ArousalColumNumber + j+1);
                        emoSelectControlPanel.Add(new EmoSelectControlPanel(this, j * ValenceRowNumber + i + 1));
                        UserControl currentControl = (UserControl)emoSelectControlPanel[j * ValenceRowNumber + i];
                        currentControl.Location = new Point(currentControl.Width * i + i, currentControl.Height * j + j);
                        EmoPanel.Controls.Add(currentControl);
                    }
                }
            }
            else
            {
                MessageBox.Show("Right number from 1 to 9", "Error");
            }


        }

        public AnalysisSystemForm AnalysisSystemForm
        {
            get { return _analysisSytemForm; }
            set
            {
                _analysisSytemForm = value;
                resultChoosingControlPanel.AnalysisSystemForm = value;
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            int ArousalColumNumber = Convert.ToInt32(AQuantityCombobox.Text);
            int ValenceRowNumber = Convert.ToInt32(VQuantityCombobox.Text);
            int[,] emoMappingArray = new int[9, 9];
            for (int i = 0; i < ArousalColumNumber; i++)
            {
                for (int j = 0; j < ValenceRowNumber; j++)
                {
                    EmoSelectControlPanel currentControl = emoSelectControlPanel[i * ValenceRowNumber + j] as EmoSelectControlPanel;
                    int emoSelect = Convert.ToInt32(currentControl.EmoTextbox.Text);
                    int MinA = Convert.ToInt32(currentControl.MinACombobox.Text);
                    int MaxA = Convert.ToInt32(currentControl.MaxACombobox.Text);
                    int MinV = Convert.ToInt32(currentControl.MinVCombobox.Text);
                    int MaxV = Convert.ToInt32(currentControl.MaxVCombobox.Text);
                    for (int k1 = MinA - 1; k1 < MaxA; k1++)
                    {
                        for (int k2 = MinV - 1; k2 < MaxV; k2++)
                            emoMappingArray[k1, k2] = emoSelect;
                    }
                }
            }

            resultChoosingControlPanel.RightListView.Items.Clear();
            foreach (ListViewItem item in resultChoosingControlPanel.LeftListView.Items)
            {

                String arousalString = item.SubItems[1].Text;
                String valenceString = item.SubItems[2].Text;


                if (!String.IsNullOrEmpty(arousalString) &&
                    !String.IsNullOrEmpty(valenceString))
                {
                    try
                    {
                        Convert.ToInt32(arousalString);
                        Convert.ToInt32(valenceString);
                        selectedSample.Add(item.Text);
                    }
                    catch (FormatException fe)
                    {
                        //_analysisSytemForm.StatusLabel.Text = "Error occur! Command terminated.";
                        return;
                    }
                }

                var dataQuery =
                    from samples
                    in _db.Samples
                    orderby samples.SID ascending
                    select samples;

                foreach (var data in dataQuery)
                {
                    while (true)
                    {
                        if (selectedSample.Count <= 0)
                            break;

                        if (String.Compare(data.SID, selectedSample[0] as String) > 0)
                        {
                            selectedSample.RemoveAt(0);
                            continue;
                        }
                        else if (String.Compare(data.SID, selectedSample[0] as String) == 0)
                        {
                            int arousalValue = Convert.ToInt32(data.SamArousal);
                            int valenceValue = Convert.ToInt32(data.SamValence);
                            data.AffectionLabel = emoMappingArray[arousalValue, valenceValue].ToString();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                _db.SubmitChanges();

            }

        }
    }
}
