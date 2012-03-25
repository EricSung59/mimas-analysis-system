﻿using System;
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
    public partial class DoubleViewChoosingControlPanel : UserControl
    {
        AnalysisSystemDataContext _db = new AnalysisSystemDataContext();
        AnalysisSystemForm _analysisSystemForm;

        //------------------- CONSTRUCTOR -------------------//

        public DoubleViewChoosingControlPanel()
        {
            InitializeComponent();

            loadLeftListView();
            loadRightListView();
        }

        //-------------------- EVENT HANDLERS ---------------//

        private void selectSampleButton_Click(object sender, EventArgs e)
        {
            _analysisSystemForm.StatusLabel.Text = "Choosing sample";

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
                ArrayList sidList = new ArrayList();
                foreach (ListViewItem item in form.ListView.SelectedItems)
                {
                    sidList.Add(item.Text);
                }
                sidList.Sort();

                leftListView.BeginUpdate();
                leftListView.Items.Clear();

                foreach (var data in dataQuery)
                {
                    bool found = false;

                    while (true)
                    {
                        if (sidList.Count <= 0)
                            break;

                        if (String.Compare(data.SID, sidList[0] as String) > 0)
                        {
                            sidList.RemoveAt(0);
                            continue;
                        }
                        else if (String.Compare(data.SID, sidList[0] as String) == 0)
                        {
                            found = true;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }

                    //if (form.ListView.SelectedItems.ContainsKey(data.SID))
                    if (found)
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
            }

            _analysisSystemForm.StatusLabel.Text = "";
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

        //------------------- PROPERTIES --------------------//

        public AnalysisSystemForm AnalysisSystemForm
        {
            get { return _analysisSystemForm; }
            set { _analysisSystemForm = value; }
        }
    }
}
