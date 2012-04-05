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
    public partial class ResultChoosingControlPanel : UserControl
    {
        AnalysisSystemDataContext _db = new AnalysisSystemDataContext();
        AnalysisSystemForm _analysisSystemForm;

        public event EventHandler SelectComplete;

        //------------------- CONSTRUCTOR -------------------//

        public ResultChoosingControlPanel()
        {
            InitializeComponent();

            loadLeftListView();
            loadRightListView();
        }

        //-------------------- EVENT HANDLERS ---------------//

        private void selectSampleButton_Click(object sender, EventArgs e)
        {
            _analysisSystemForm.SetStatus("Choosing sample");

            ChoosingForm form = new ChoosingForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _analysisSystemForm.SampleEliminatingControlPanel.UpdateButton.Enabled = false;

                var dataQuery =
                from samples in _db.Samples
                from volpics in _db.VolPics
                from pictures in _db.Pictures
                where samples.SID == volpics.SID &&
                      volpics.PID == pictures.PID
                orderby samples.SID ascending
                select new { samples, pictures };

                List<AnalysisSystemUtils.AnalysisSystemTaskArgs> itemToSearchList = new List<AnalysisSystemUtils.AnalysisSystemTaskArgs>();
                foreach (var data in dataQuery)
                {
                    AnalysisSystemUtils.AnalysisSystemTaskArgs args = new AnalysisSystemUtils.AnalysisSystemTaskArgs(data.samples.SID);
                    args.Sample = data.samples;
                    args.Picture = data.pictures;

                    itemToSearchList.Add(args);
                }

                leftListView.BeginUpdate();
                leftListView.Items.Clear();
                rightListView.Items.Clear();

                AnalysisSystemUtils.PerformTask(
                        form.ListView.SelectedItems, 
                        itemToSearchList, 
                        new AnalysisSystemUtils.AnalysisSystemTask(addLeftListViewItem));

                leftListView.EndUpdate();

                OnSelectComplete();
            }

            _analysisSystemForm.SetStatus(String.Empty);
        }

        //------------------- PRIVATE HELPERS ---------------//

        private void loadLeftListView()
        {
            leftListView.BeginUpdate();

            ColumnHeader samplesIdColumnHeader = new ColumnHeader();
            samplesIdColumnHeader.Text = "Sample ID";
            samplesIdColumnHeader.Width = -2;

            ColumnHeader samArousalColumnHeader = new ColumnHeader();
            samArousalColumnHeader.Text = "Sam Arousal";
            samArousalColumnHeader.Width = -2;

            ColumnHeader samValenceColumnHeader = new ColumnHeader();
            samValenceColumnHeader.Text = "Sam Valence";
            samValenceColumnHeader.Width = -2;

            ColumnHeader pictureIdColumnHeader = new ColumnHeader();
            pictureIdColumnHeader.Text = "Picture ID";
            pictureIdColumnHeader.Width = -2;

            ColumnHeader pictureArousalColumnHeader = new ColumnHeader();
            pictureArousalColumnHeader.Text = "Arousal";
            pictureArousalColumnHeader.Width = -2;

            ColumnHeader pictureValenceColumnHeader = new ColumnHeader();
            pictureValenceColumnHeader.Text = "Valence";
            pictureValenceColumnHeader.Width = -2;

            ColumnHeader pictureArousalSdColumnHeader = new ColumnHeader();
            pictureArousalSdColumnHeader.Text = "Arousal SD";
            pictureArousalSdColumnHeader.Width = -2;

            ColumnHeader pictureValenceSdColumnHeader = new ColumnHeader();
            pictureValenceSdColumnHeader.Text = "Valence SD";
            pictureValenceSdColumnHeader.Width = -2;

            leftListView.Columns.AddRange(new ColumnHeader[]
                {
                    samplesIdColumnHeader, samArousalColumnHeader, samValenceColumnHeader,
                    pictureIdColumnHeader, pictureArousalColumnHeader, pictureValenceColumnHeader,
                    pictureArousalSdColumnHeader, pictureValenceSdColumnHeader
                }
            );

            leftListView.EndUpdate();
        }

        private void loadRightListView()
        {
            rightListView.BeginUpdate();

            ColumnHeader samplesIdColumnHeader = new ColumnHeader();
            samplesIdColumnHeader.Text = "Sample ID";
            samplesIdColumnHeader.Width = -2;

            ColumnHeader samArousalColumnHeader = new ColumnHeader();
            samArousalColumnHeader.Text = "Sam Arousal";
            samArousalColumnHeader.Width = -2;

            ColumnHeader samValenceColumnHeader = new ColumnHeader();
            samValenceColumnHeader.Text = "Sam Valence";
            samValenceColumnHeader.Width = -2;

            ColumnHeader pictureIdColumnHeader = new ColumnHeader();
            pictureIdColumnHeader.Text = "Picture ID";
            pictureIdColumnHeader.Width = -2;

            ColumnHeader pictureArousalColumnHeader = new ColumnHeader();
            pictureArousalColumnHeader.Text = "Arousal";
            pictureArousalColumnHeader.Width = -2;

            ColumnHeader pictureValenceColumnHeader = new ColumnHeader();
            pictureValenceColumnHeader.Text = "Valence";
            pictureValenceColumnHeader.Width = -2;

            ColumnHeader pictureArousalSdColumnHeader = new ColumnHeader();
            pictureArousalSdColumnHeader.Text = "Arousal SD";
            pictureArousalSdColumnHeader.Width = -2;

            ColumnHeader pictureValenceSdColumnHeader = new ColumnHeader();
            pictureValenceSdColumnHeader.Text = "Valence SD";
            pictureValenceSdColumnHeader.Width = -2;

            rightListView.Columns.AddRange(new ColumnHeader[]
                {
                    samplesIdColumnHeader, samArousalColumnHeader, samValenceColumnHeader,
                    pictureIdColumnHeader, pictureArousalColumnHeader, pictureValenceColumnHeader,
                    pictureArousalSdColumnHeader, pictureValenceSdColumnHeader
                }
            );

            rightListView.EndUpdate();
        }

        private void addLeftListViewItem(AnalysisSystemUtils.AnalysisSystemTaskArgs args)
        {
            ListViewItem item = new ListViewItem();

            item.Text = (args.Sample.SID != null ? args.Sample.SID : "");
            item.Name = (args.Sample.SID != null ? args.Sample.SID : "");

            item.SubItems.AddRange(new String[] 
                {
                    args.Sample.SamArousal != null ? args.Sample.SamArousal.ToString() : "", 
                    args.Sample.SamValence != null ? args.Sample.SamValence.ToString() : "",
                    args.Picture != null ? args.Picture.PID : "", 
                    args.Picture.Arousal != null ? args.Picture.Arousal.ToString() : "", 
                    args.Picture.Valence != null ? args.Picture.Valence.ToString() : "",
                    args.Picture.ArousalSD != null ? args.Picture.ArousalSD.ToString() : "", 
                    args.Picture.ValenceSD != null ? args.Picture.ValenceSD.ToString() : ""
                }
            );

            leftListView.Items.Add(item);
        }

        private void OnSelectComplete()
        {
            if (SelectComplete != null)
            {
                SelectComplete(this, EventArgs.Empty);
            }
        }

        //------------------- PROPERTIES --------------------//

        public AnalysisSystemForm AnalysisSystemForm
        {
            get { return _analysisSystemForm; }
            set { _analysisSystemForm = value; }
        }

        public ListView LeftListView
        {
            get { return leftListView; }
        }

        public ListView RightListView
        {
            get { return rightListView; }
        }
    }
}
