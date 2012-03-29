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

                ArrayList itemList = new ArrayList();
                
                foreach (ListViewItem item in form.ListView.SelectedItems)
                {
                    itemList.Add(item.Text);
                }
                itemList.Sort();

                var dataQuery =
                    from samples in _db.Samples
                    from volpics in _db.VolPics
                    where samples.SID == volpics.SID
                    select new { samples, volpics };

                foreach (var data in dataQuery)
                {
                    if (AnalysisSystemUtils.Find(itemList, data.samples.SID))
                    {
                        ListViewItem newItem = new ListViewItem();
                        newItem.Text = data.samples.SID;
                        newItem.SubItems.AddRange(new String[] 
                                {
                                    data.volpics.VID != null ? data.volpics.VID : "", 
                                    data.volpics.PID != null ? data.volpics.PID : "",
                                    data.samples.SamArousal != null ? data.samples.SamArousal.ToString() : "",
                                    data.samples.SamValence != null ? data.samples.SamValence.ToString() : "",
                                    data.samples.IsGood != null ? data.samples.IsGood.ToString() : "", //data.samples.AffectionLabel,
                                    data.samples.EdfPath != null ? data.samples.EdfPath : "",
                                    data.samples.DataCsvPath != null ? data.samples.DataCsvPath : "", 
                                    data.samples.HfdCsvPath != null ? data.samples.HfdCsvPath : ""
                                }
                        );

                        listView.Items.Add(newItem);
                    }
                }

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

        private void addSampleToList(Sample sample)
        {

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
