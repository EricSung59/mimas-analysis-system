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
using System.IO;

namespace AnalysisSystem.Controls
{
    public partial class EmoMappingControlPanel : UserControl
    {
        private AnalysisSystemForm _analysisSytemForm;
        private AnalysisSystemDataContext _db = new AnalysisSystemDataContext();

        private int _rowsCount;
        private int _colsCount;

        private EmotionSelectControlPanel[,] _emotionSelectControlPanelArray = null;
        private int[,] emotionIndexMatrix;

        //------------------------ CONSTRUCTOR -----------------------//

        public EmoMappingControlPanel()
        {
            InitializeComponent();

            outFolderChooserControlPanel.OutFolderPathTextBox.Text = @"D:\";
        }

        //------------------------ EVENT HANDLERS --------------------//

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!validateRowsAndCols())
                return;

            _emotionSelectControlPanelArray = new EmotionSelectControlPanel[_rowsCount, _colsCount];
            emotionParentTableLayoutPanel.SuspendLayout();
            resetEmotionParentTableLayoutPanel(_rowsCount, _colsCount);

            EmotionSelectControlPanel.RowsCount = _rowsCount;
            EmotionSelectControlPanel.ColumnsCount = _colsCount;
            for (int i = 0; i < _rowsCount; i++)
            {
                for (int j = 0; j < _colsCount; j++)
                {
                    EmotionSelectControlPanel emotionSelectControlPanel = new EmotionSelectControlPanel(this, i * _colsCount + j + 1, i, j);
                    emotionSelectControlPanel.Anchor = AnchorStyles.None;
                    _emotionSelectControlPanelArray[i, j] = emotionSelectControlPanel;
                    emotionParentTableLayoutPanel.Controls.Add(emotionSelectControlPanel, j, i);
                }
            }

            emotionParentTableLayoutPanel.ResumeLayout();

            processButton.Enabled = true;
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            constructEmotionIndexMatrix();
            processLabel();
            loadRightListView();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            //if (labelChoosingControlPanel.OnlySelectedSample)
            //{
            //    foreach (ListViewItem item in labelChoosingControlPanel.LeftListView.Items)
            //    {
            //        try
            //        {
            //            var dataPoint = (
            //            from datapoints
            //            in _db.DataPoints
            //            where item.Text == datapoints.SID
            //            select datapoints).SingleOrDefault();


            //        }
            //        catch (Exception)
            //        {
            //            MessageBox.Show("Querry database error at EmoMappingControlPanel::exportButton_Click");
            //            return;
            //        }
            //    }
            //}
            //else
            //{
            //    EmotionExceptChoosingForm form = new EmotionExceptChoosingForm(1, Convert.ToInt32(rowCountComboBox.Text) * Convert.ToInt32(columnCountComboBox.Text));

            //    if (form.ShowDialog() == DialogResult.OK)
            //    {
            //        String exportFilePath = Path.Combine(outFolderChooserControlPanel.OutFolderPathTextBox.Text, "ExportData.txt");

            //        if (File.Exists(exportFilePath))
            //            File.Delete(exportFilePath);

            //        using (StreamWriter writer = new StreamWriter(exportFilePath))
            //        {
            //            _analysisSytemForm.SetStatus("Exporting...");

            //            List<Int32> exceptLabelsList = form.EmotionLabelExceptList;
            //            var dataQuery =
            //                from datapoints
            //                in _db.DataPoints
            //                select datapoints;

            //            foreach (var data in dataQuery)
            //            {
            //                if (!String.IsNullOrEmpty(data.Label) &&
            //                    !exceptLabelsList.Contains(Convert.ToInt32(data.Label)) &&
            //                    data.FdArousal != null && data.FdValence != null)
            //                {
            //                    writer.WriteLine("{0}  1:{1} 2:{2}", data.Label, data.FdArousal, data.FdValence);
            //                }
            //            }

            //            _analysisSytemForm.SetStatus("Exporting... Done");
            //        }
            //    }
            //}


        }

        //------------------------ PRIVATE HELPERS -------------------//

        private void resetEmotionParentTableLayoutPanel(int rowsCount, int colsCount)
        {
            emotionParentTableLayoutPanel.Controls.Clear();
            emotionParentTableLayoutPanel.Size = new System.Drawing.Size(0, 0);

            emotionParentTableLayoutPanel.ColumnCount = colsCount;
            emotionParentTableLayoutPanel.RowCount = rowsCount;

            emotionParentTableLayoutPanel.ColumnStyles.Clear();
            for (int i = 0; i < colsCount; i++)
            {
                emotionParentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            emotionParentTableLayoutPanel.RowStyles.Clear();
            for (int i = 0; i < rowsCount; i++)
            {
                emotionParentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }

        private bool validateRowsAndCols()
        {
            _analysisSytemForm.SetStatus("");
            try
            {
                _rowsCount = Convert.ToInt32(rowCountComboBox.Text);
                _colsCount = Convert.ToInt32(columnCountComboBox.Text);
            }
            catch (Exception)
            {
                _analysisSytemForm.SetStatus("Rows and Cols number must be a valid positive integer.");
                return false;
            }

            if (_rowsCount <= 0)
            {
                _analysisSytemForm.SetStatus("Rows must be greater than zero.");
                return false;
            }

            if (_colsCount <= 0)
            {
                _analysisSytemForm.SetStatus("Columns must be greater than zero.");
                return false;
            }

            if (_rowsCount > (EmotionSelectControlPanel.MaxArousal - EmotionSelectControlPanel.MinArousal + 1))
            {
                _analysisSytemForm.SetStatus("Rows must be lower than or equal to " + (EmotionSelectControlPanel.MaxArousal - EmotionSelectControlPanel.MinArousal + 1));
                return false;
            }

            if (_colsCount > (EmotionSelectControlPanel.MaxValence - EmotionSelectControlPanel.MinValence + 1))
            {
                _analysisSytemForm.SetStatus("Cols must be lower than or equal to " + (EmotionSelectControlPanel.MaxValence - EmotionSelectControlPanel.MinValence + 1));
                return false;
            }

            return true;
        }

        private void constructEmotionIndexMatrix()
        {
            emotionIndexMatrix = 
                new int[EmotionSelectControlPanel.MaxValence - EmotionSelectControlPanel.MinValence + 2, EmotionSelectControlPanel.MaxArousal - EmotionSelectControlPanel.MinArousal + 2];

            for (int i = 0; i < _rowsCount; i++)
                for (int j = 0; j < _colsCount; j++)
                {
                    EmotionSelectControlPanel currentPanel = _emotionSelectControlPanelArray[i, j];
                    int valenceStartValue = (int)currentPanel.ValenceStartComboBox.SelectedItem;
                    int valenceEndValue = (int)currentPanel.ValenceEndComboBox.SelectedItem;
                    int arousalStartValue = (int)currentPanel.ArousalStartComboBox.SelectedItem;
                    int arousalEndValue = (int)currentPanel.ArousalEndComboBox.SelectedItem;
                    int emotionValue = (int)currentPanel.Emotion;

                    for (int i1 = valenceStartValue; i1 <= valenceEndValue; i1++)
                        for (int j1 = arousalStartValue; j1 <= arousalEndValue; j1++)
                        {
                            emotionIndexMatrix[i1, j1] = emotionValue;
                        }
                }
        }

        private void processLabel()
        {
            List<ListViewItem> leftListViewItemCloneList = new List<ListViewItem>();
            foreach (ListViewItem item in labelChoosingControlPanel.LeftListView.Items)
            {
                leftListViewItemCloneList.Add(item.Clone() as ListViewItem);
            }

            var dataQuery =
                from samples in _db.Samples
                from datapoints in _db.DataPoints
                where samples.SID == datapoints.SID
                orderby samples.SID ascending
                select datapoints;
            List<DataPoint> dataPointList = new List<DataPoint>();
            foreach (DataPoint dp in dataQuery)
            {
                dataPointList.Add(dp);
            }

            // su dung index de khong phai dung RemoveAt -> tang toc do
            int leftListViewItemCloneListIndex = 0;
            int dataPointListIndex = 0;

            while (leftListViewItemCloneListIndex < leftListViewItemCloneList.Count && 
                   dataPointListIndex < dataPointList.Count)
            {
                ListViewItem leftListViewItem = leftListViewItemCloneList[leftListViewItemCloneListIndex];
                DataPoint dataPoint = dataPointList[dataPointListIndex];

                int samArousal, samValence;

                try
                {
                    samArousal = Convert.ToInt32(leftListViewItem.SubItems[1].Text);
                    samValence = Convert.ToInt32(leftListViewItem.SubItems[2].Text);
                }
                catch (Exception)
                {
                    leftListViewItemCloneListIndex++;
                    continue;
                }

                // already have in database
                if (String.Compare(leftListViewItem.Text, dataPoint.SID) == 0)
                {
                    dataPoint.Label = emotionIndexMatrix[samValence, samArousal].ToString();

                    leftListViewItemCloneListIndex++;
                    dataPointListIndex++;
                }
                // not in database
                else if (String.Compare(leftListViewItem.Text, dataPoint.SID) < 0)
                {
                    DataPoint newDataPoint = new DataPoint();

                    newDataPoint.SID = leftListViewItem.Text;
                    newDataPoint.Label = emotionIndexMatrix[samValence, samArousal].ToString();

                    _db.DataPoints.InsertOnSubmit(newDataPoint);

                    leftListViewItemCloneListIndex++;
                }
                // not yet
                else
                {
                    dataPointListIndex++;
                }
            }

            while (leftListViewItemCloneListIndex < leftListViewItemCloneList.Count)
            {
                ListViewItem leftListViewItem = leftListViewItemCloneList[leftListViewItemCloneListIndex];
                int samArousal = Convert.ToInt32(leftListViewItem.SubItems[1].Text);
                int samValence = Convert.ToInt32(leftListViewItem.SubItems[2].Text);

                DataPoint newDataPoint = new DataPoint();

                newDataPoint.SID = leftListViewItem.Text;
                newDataPoint.Label = emotionIndexMatrix[samValence, samArousal].ToString();

                _db.DataPoints.InsertOnSubmit(newDataPoint);

                leftListViewItemCloneListIndex++;
            }

            _db.SubmitChanges();
        }

        private void loadRightListView()
        {
            var dataQuery = 
                from datapoints in _db.DataPoints
                from samples in _db.Samples
                where samples.SID == datapoints.SID &&
                      (labelChoosingControlPanel.OnlyGoodSample ? samples.IsGood : true)
                orderby samples.SID ascending
                select datapoints;

            List<AnalysisSystemUtils.AnalysisSystemTaskArgs> itemToSearchList = new List<AnalysisSystemUtils.AnalysisSystemTaskArgs>();
            foreach (var data in dataQuery)
            {
                AnalysisSystemUtils.AnalysisSystemTaskArgs args = new AnalysisSystemUtils.AnalysisSystemTaskArgs(data.SID);
                args.DataPoint = data;
                itemToSearchList.Add(args);
            }

            labelChoosingControlPanel.RightListView.BeginUpdate();

            //foreach (DataPoint dataPoint in dataQuery)
            //{
            //    if (labelChoosingControlPanel.LeftListView.Items.ContainsKey(dataPoint.SID))
            //    {
            //        ListViewItem item = new ListViewItem();

            //        item.Text = (dataPoint.SID != null ? dataPoint.SID : "");
            //        item.Name = (dataPoint.SID != null ? dataPoint.SID : "");

            //        item.SubItems.AddRange(new String[]
            //        {
            //            dataPoint.FdArousal != null ? dataPoint.FdArousal.ToString() : "",
            //            dataPoint.FdValence != null ? dataPoint.FdValence.ToString() : "",
            //            dataPoint.Label != null ? dataPoint.Label : ""
            //        }
            //        );

            //        labelChoosingControlPanel.RightListView.Items.Add(item);
            //    }
            //}

            AnalysisSystemUtils.PerformTask(
                    labelChoosingControlPanel.LeftListView.Items,
                    itemToSearchList,
                    new AnalysisSystemUtils.AnalysisSystemTask(addItemToRightListView),
                    true);

            labelChoosingControlPanel.RightListView.EndUpdate();
        }

        private void addItemToRightListView(AnalysisSystemUtils.AnalysisSystemTaskArgs args)
        {
            ListViewItem item = new ListViewItem();

            item.Text = (args.DataPoint.SID != null ? args.DataPoint.SID : "");
            item.Name = (args.DataPoint.SID != null ? args.DataPoint.SID : "");

            item.SubItems.AddRange(new String[]
                    {
                        args.DataPoint.FdArousal != null ? args.DataPoint.FdArousal.ToString() : "",
                        args.DataPoint.FdValence != null ? args.DataPoint.FdValence.ToString() : "",
                        args.DataPoint.Label != null ? args.DataPoint.Label : ""
                    }
            );

            labelChoosingControlPanel.RightListView.Items.Add(item);
        }

        //------------------------ PUBLIC METHODS --------------------//

        public List<EmotionSelectControlPanel> GetEmotionSelectControlPanelsByRow(int row)
        {
            List<EmotionSelectControlPanel> result = new List<EmotionSelectControlPanel>();

            for (int j = 0; j < _colsCount; j++)
            {
                result.Add(_emotionSelectControlPanelArray[row, j]);
            }

            return result;
        }

        public List<EmotionSelectControlPanel> GetEmotionSelectControlPanelsByColumn(int col)
        {
            List<EmotionSelectControlPanel> result = new List<EmotionSelectControlPanel>();

            for (int i = _rowsCount - 1; i >= 0; i--)
            {
                result.Add(_emotionSelectControlPanelArray[i, col]);
            }

            return result;
        }

        //------------------------ PROPERTIES ------------------------//

        public AnalysisSystemForm AnalysisSystemForm
        {
            get
            {
                return _analysisSytemForm;
            }
            set
            {
                _analysisSytemForm = value;
                labelChoosingControlPanel.AnalysisSystemForm = value;
            }
        }

        public EmotionSelectControlPanel[,] EmotionSelectControlPanelArray
        {
            get { return _emotionSelectControlPanelArray; }
        }
    }
}
