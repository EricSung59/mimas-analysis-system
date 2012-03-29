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

            var dataQuery =
                from samples in _db.Samples
                from volpics in _db.VolPics
                from pictures in _db.Pictures
                where samples.SID == volpics.SID &&
                      volpics.PID == pictures.PID
                orderby samples.SID ascending
                select new
                {
                    samples.SID,
                    samples.SamArousal,
                    samples.SamValence,
                    pictures.PID,
                    pictures.Arousal,
                    pictures.Valence,
                    pictures.ArousalSD,
                    pictures.ValenceSD
                };

            ChoosingForm form = new ChoosingForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _analysisSystemForm.SampleEliminatingControlPanel.UpdateButton.Enabled = false;

                ArrayList sidList = new ArrayList();
                foreach (ListViewItem item in form.ListView.SelectedItems)
                {
                    sidList.Add(item.Text);
                }
                sidList.Sort();

                leftListView.BeginUpdate();
                leftListView.Items.Clear();
                rightListView.Items.Clear();

                foreach (var data in dataQuery)
                {
                    if (AnalysisSystemUtils.Find(sidList, data.SID))
                    {
                        ListViewItem item = new ListViewItem();

                        item.Text = data.SID;
                        item.Name = data.SID;

                        item.SubItems.AddRange(new String[] 
                            {
                                data.SamArousal.ToString(), data.SamValence.ToString(), data.PID, 
                                data.Arousal.ToString(), data.Valence.ToString(),
                                data.ArousalSD.ToString(), data.ValenceSD.ToString()
                            }
                        );

                        leftListView.Items.Add(item);
                    }
                }

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
