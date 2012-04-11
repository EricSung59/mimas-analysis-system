using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnalysisSystem.Forms;
using System.IO;
using System.Collections;

namespace AnalysisSystem.Controls
{
    public partial class ChoosingControlPanel : UserControl
    {
        AnalysisSystemDataContext _db = new AnalysisSystemDataContext();
        AnalysisSystemForm _analysisSystemForm;

        //------------------------ CONSTRUCTOR -----------------------//

        public ChoosingControlPanel()
        {
            InitializeComponent();

            initListView();
        }

        //------------------------ EVENT HANDLERS --------------------//
        
        private void selectSampleButton_Click(object sender, EventArgs e)
        {
            _analysisSystemForm.SetStatus("Choosing sample");

            ChoosingForm form = new ChoosingForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                listView.BeginUpdate();

                listView.Items.Clear();

                var dataQuery =
                    from samples in _db.Samples
                    from volpics in _db.VolPics
                    where samples.SID == volpics.SID
                    orderby samples.SID ascending
                    select new { samples, volpics };

                List<AnalysisSystemUtils.AnalysisSystemTaskArgs> itemToSearchList = new List<AnalysisSystemUtils.AnalysisSystemTaskArgs>();
                foreach (var data in dataQuery)
                {
                    AnalysisSystemUtils.AnalysisSystemTaskArgs args = new AnalysisSystemUtils.AnalysisSystemTaskArgs(data.samples.SID);
                    args.Sample = data.samples;
                    args.VolPic = data.volpics;

                    itemToSearchList.Add(args);
                }

                AnalysisSystemUtils.PerformTask(
                        form.ListView.SelectedItems, 
                        itemToSearchList, 
                        new AnalysisSystemUtils.AnalysisSystemTask(addListViewItem),
                        true);

                foreach (ColumnHeader columnHeader in listView.Columns)
                {
                    columnHeader.Width = -2;
                }

                listView.EndUpdate();
                
            }

            _analysisSystemForm.SetStatus(String.Empty);
        }

        //------------------------ PRIVATE HELPERS -------------------//

        private void initListView()
        {
            ColumnHeader sidColumnHeader = new ColumnHeader();
            sidColumnHeader.Text = "SID";
            sidColumnHeader.Width = -2;

            ColumnHeader vidColumnHeader = new ColumnHeader();
            vidColumnHeader.Text = "VID";
            vidColumnHeader.Width = -2;

            ColumnHeader pidColumnHeader = new ColumnHeader();
            pidColumnHeader.Text = "PID";
            pidColumnHeader.Width = -2;

            ColumnHeader samArousalColumnHeader = new ColumnHeader();
            samArousalColumnHeader.Text = "Sam Arousal";
            samArousalColumnHeader.Width = -2;

            ColumnHeader samValenceColumnHeader = new ColumnHeader();
            samValenceColumnHeader.Text = "Sam Valence";
            samValenceColumnHeader.Width = -2;

            ColumnHeader isGoodColumnHeader = new ColumnHeader();
            isGoodColumnHeader.Text = "Is Good";
            isGoodColumnHeader.Width = -2;

            ColumnHeader affectionLabelColumnHeader = new ColumnHeader();
            affectionLabelColumnHeader.Text = "Affection Label";
            affectionLabelColumnHeader.Width = -2;

            ColumnHeader edfPathColumnHeader = new ColumnHeader();
            edfPathColumnHeader.Text = "Edf Path";
            edfPathColumnHeader.Width = -2;

            ColumnHeader dataCsvPathColumnHeader = new ColumnHeader();
            dataCsvPathColumnHeader.Text = "Data Csv Path";
            dataCsvPathColumnHeader.Width = -2;

            ColumnHeader hfdCsvPathColumnHeader = new ColumnHeader();
            hfdCsvPathColumnHeader.Text = "Hfd Csv Path";
            hfdCsvPathColumnHeader.Width = -2;

            listView.Columns.AddRange(new ColumnHeader[]
                {
                    sidColumnHeader, vidColumnHeader, pidColumnHeader,
                    samArousalColumnHeader, samValenceColumnHeader,
                    isGoodColumnHeader, //affectionLabelColumnHeader, 
                    edfPathColumnHeader, dataCsvPathColumnHeader, hfdCsvPathColumnHeader
                }  
            );
        }

        private void addListViewItem(AnalysisSystemUtils.AnalysisSystemTaskArgs args)
        {
            if (args.Sample == null || args.VolPic == null)
                throw new Exception("ChoosingControlPanel::addListViewItem");

            ListViewItem item = new ListViewItem();

            item.Text = (args.Sample.SID != null ? args.Sample.SID : "");
            item.SubItems.AddRange(new String[]
                {
                    args.VolPic.VID != null ? args.VolPic.VID : "",
                    args.VolPic.PID != null ? args.VolPic.PID : "",
                    args.Sample.SamArousal != null ? args.Sample.SamArousal.ToString() : "",
                    args.Sample.SamValence != null ? args.Sample.SamValence.ToString() : "",
                    args.Sample.IsGood != null ? args.Sample.IsGood.ToString() : "",
                    args.Sample.EdfPath != null ? args.Sample.EdfPath : "",
                    args.Sample.DataCsvPath != null ? args.Sample.DataCsvPath : "",
                    args.Sample.HfdCsvPath != null ? args.Sample.HfdCsvPath : ""
                }
            );

            listView.Items.Add(item);
        }

        //------------------------ PROPERTIES ------------------------//

        public ListView ListView
        {
            get { return listView; }
        }

        public AnalysisSystemForm AnalysisSystemForm
        {
            get
            {
                return _analysisSystemForm;
            }
            set
            {
                _analysisSystemForm = value;
            }
        }
    }
}
