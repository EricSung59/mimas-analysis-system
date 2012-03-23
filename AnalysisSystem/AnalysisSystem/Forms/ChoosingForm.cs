using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnalysisSystem.Forms
{
    public partial class ChoosingForm : Form
    {
        AnalysisSystemDataContext _db;

        public ChoosingForm()
        {
            InitializeComponent();
            _db = new AnalysisSystemDataContext();

            loadListView();
        }

        private void loadListView()
        {
            listView.BeginUpdate();
            //
            // Header
            //
            ColumnHeader sampleIdColumnHeader = new ColumnHeader();
            sampleIdColumnHeader.Text = "Sample ID";
            sampleIdColumnHeader.Width = -2;

            ColumnHeader volunteerIdColumnHeader = new ColumnHeader();
            volunteerIdColumnHeader.Text = "Volunteer ID";
            volunteerIdColumnHeader.Width = -2;

            ColumnHeader pictureIdColumnHeader = new ColumnHeader();
            pictureIdColumnHeader.Text = "Picture ID";
            pictureIdColumnHeader.Width = -2;

            ColumnHeader edfPathColumnHeader = new ColumnHeader();
            edfPathColumnHeader.Text = "Edf Path";
            edfPathColumnHeader.Width = -2;

            listView.Columns.AddRange(new ColumnHeader[] { sampleIdColumnHeader, volunteerIdColumnHeader, pictureIdColumnHeader, edfPathColumnHeader });
            //
            // Query for data 
            //
            var dataQuery =
                from samples in _db.Samples
                from volpics in _db.VolPics
                where samples.SID == volpics.SID
                select new { volpics.VID, volpics.PID, samples.SID, samples.EdfPath };
            //
            // Fill data to ListView
            //
            foreach (var data in dataQuery)
            {
                ListViewItem item = new ListViewItem();
                item.Text = data.SID;
                item.SubItems.Add(data.VID);
                item.SubItems.Add(data.PID);
                item.SubItems.Add(data.EdfPath);

                listView.Items.Add(item);
            }
            
            listView.EndUpdate();
        }

        //--------------- EVENT HANDLE ----------------//

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            listView.BeginUpdate();
            foreach (ListViewItem item in listView.Items)
            {
                item.Selected = true;
            }
            listView.EndUpdate();

            listView.Focus();
        }

        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            listView.BeginUpdate();
            foreach (ListViewItem item in listView.Items)
            {
                item.Selected = false;
            }
            listView.EndUpdate();

            listView.Focus();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // -------------- PROPERTIES -----------------//

        public ListView ListView
        {
            get { return listView; }
        }
    }
}
