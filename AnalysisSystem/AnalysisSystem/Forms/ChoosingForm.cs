using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace AnalysisSystem.Forms
{
    public partial class ChoosingForm : Form
    {
        AnalysisSystemDataContext _db = new AnalysisSystemDataContext();

        public ChoosingForm()
        {
            InitializeComponent();

            loadListView();
            loadVolunteerIdInListBox();
            loadPictureIdInListBox();
        }

        private void loadPictureIdInListBox()
        {
            var pictureIdQuery = (
                from samples in _db.Samples
                from volpics in _db.VolPics
                where samples.SID == volpics.SID
                select volpics.PID).Distinct();

            foreach (String pid in pictureIdQuery)
            {
                pictureIdInListBox.Items.Add(pid);
            }
        }

        private void loadVolunteerIdInListBox()
        {
            var volunteerIdQuery = (
                from samples in _db.Samples
                from volpics in _db.VolPics
                where samples.SID == volpics.SID
                select volpics.VID).Distinct();

            foreach (String vid in volunteerIdQuery)
            {
                volunteerIdInListBox.Items.Add(vid);
            }
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

        //
        // Volunteer
        //

        private void volunteerIdPullOutOneButton_Click(object sender, EventArgs e)
        {
            ArrayList removedVolunteerIds = new ArrayList();

            while (volunteerIdInListBox.SelectedItems.Count > 0)
            {
                Object volunteerId = volunteerIdInListBox.SelectedItems[0];
                volunteerIdInListBox.Items.Remove(volunteerId);
                volunteerIdOutListBox.Items.Add(volunteerId);
                removedVolunteerIds.Add(volunteerId);
            }

            updateRemoveVolunteerListView(removedVolunteerIds);
        }

        private void volunteerIdPullOutAllButton_Click(object sender, EventArgs e)
        {
            ArrayList removedVolunteerIds = new ArrayList();

            while (volunteerIdInListBox.Items.Count > 0)
            {
                Object item = volunteerIdInListBox.Items[0];
                volunteerIdInListBox.Items.Remove(item);
                volunteerIdOutListBox.Items.Add(item);
                removedVolunteerIds.Add(item);
            }

            updateRemoveVolunteerListView(removedVolunteerIds);
        }

        private void volunteerIdPushInOneButton_Click(object sender, EventArgs e)
        {
            ArrayList addedVolunteerIds = new ArrayList();

            while (volunteerIdOutListBox.SelectedItems.Count > 0)
            {
                Object item = volunteerIdOutListBox.SelectedItems[0];
                volunteerIdOutListBox.Items.Remove(item);
                volunteerIdInListBox.Items.Add(item);
                addedVolunteerIds.Add(item);
            }

            updateAddVolunteerListView(addedVolunteerIds);
        }

        private void volunteerIdPushInAllButton_Click(object sender, EventArgs e)
        {
            ArrayList addedVolunteerIds = new ArrayList();

            while (volunteerIdOutListBox.Items.Count > 0)
            {
                Object item = volunteerIdOutListBox.Items[0];
                volunteerIdOutListBox.Items.Remove(item);
                volunteerIdInListBox.Items.Add(item);
                addedVolunteerIds.Add(item);
            }

            updateAddVolunteerListView(addedVolunteerIds);
        }

        //
        // Picture
        //

        private void pictureIdPullOutOneButton_Click(object sender, EventArgs e)
        {
            ArrayList removedPictureIds = new ArrayList();

            while (pictureIdInListBox.SelectedItems.Count > 0)
            {
                Object pictureId = pictureIdInListBox.SelectedItems[0];
                pictureIdInListBox.Items.Remove(pictureId);
                pictureIdOutListBox.Items.Add(pictureId);
                removedPictureIds.Add(pictureId);
            }

            updateRemovePictureListView(removedPictureIds);
        }

        private void pictureIdPullOutAllButton_Click(object sender, EventArgs e)
        {
            ArrayList removedPictureIds = new ArrayList();

            while (pictureIdInListBox.Items.Count > 0)
            {
                Object item = pictureIdInListBox.Items[0];
                pictureIdInListBox.Items.Remove(item);
                pictureIdOutListBox.Items.Add(item);
                removedPictureIds.Add(item);
            }

            updateRemovePictureListView(removedPictureIds);
        }

        private void pictureIdPushInOneButton_Click(object sender, EventArgs e)
        {
            ArrayList addedPictureIds = new ArrayList();

            while (pictureIdOutListBox.SelectedItems.Count > 0)
            {
                Object item = pictureIdOutListBox.SelectedItems[0];
                pictureIdOutListBox.Items.Remove(item);
                pictureIdInListBox.Items.Add(item);
                addedPictureIds.Add(item);
            }

            updateAddPictureListView(addedPictureIds);
        }

        private void pictureIdPushInAllButton_Click(object sender, EventArgs e)
        {
            ArrayList addedPictureIds = new ArrayList();

            while (pictureIdOutListBox.Items.Count > 0)
            {
                Object item = pictureIdOutListBox.Items[0];
                pictureIdOutListBox.Items.Remove(item);
                pictureIdInListBox.Items.Add(item);
                addedPictureIds.Add(item);
            }

            updateAddVolunteerListView(addedPictureIds);
        }

        // -------------- PROPERTIES -----------------//

        public ListView ListView
        {
            get { return listView; }
        }

        // -------------- PRIVATE HELPERS --------------//

        private void updateRemoveVolunteerListView(ArrayList removedVolunteerIds)
        {
            listView.BeginUpdate();

            int counter = 0;
            int total = listView.Items.Count;

            for (int i = 0; i < total; i++)
            {
                if (removedVolunteerIds.Contains(listView.Items[counter].SubItems[1].Text))
                    listView.Items.Remove(listView.Items[counter]);
                else
                    counter++;
            }

            listView.EndUpdate();
        }

        private void updateAddVolunteerListView(ArrayList addedVolunteerIds)
        {
            listView.BeginUpdate();

            var dataQuery =
                from samples in _db.Samples
                from volpics in _db.VolPics
                where samples.SID == volpics.SID
                select new { samples.SID, samples.EdfPath, volpics.VID, volpics.PID };

            foreach (var data in dataQuery)
            {
                if (addedVolunteerIds.Contains(data.VID))
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = data.SID;
                    item.SubItems.Add(data.VID);
                    item.SubItems.Add(data.PID);
                    item.SubItems.Add(data.EdfPath);

                    listView.Items.Add(item);
                }
            }

            listView.EndUpdate();
        }

        private void updateRemovePictureListView(ArrayList removedPictureIds)
        {
            listView.BeginUpdate();

            int counter = 0;
            int total = listView.Items.Count;

            for (int i = 0; i < total; i++)
            {
                if (removedPictureIds.Contains(listView.Items[counter].SubItems[2].Text))
                    listView.Items.Remove(listView.Items[counter]);
                else
                    counter++;
            }

            listView.EndUpdate();
        }

        private void updateAddPictureListView(ArrayList addedPictureIds)
        {
            listView.BeginUpdate();

            var dataQuery =
                from samples in _db.Samples
                from volpics in _db.VolPics
                where samples.SID == volpics.SID
                select new { samples.SID, samples.EdfPath, volpics.VID, volpics.PID };

            foreach (var data in dataQuery)
            {
                if (addedPictureIds.Contains(data.PID))
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = data.SID;
                    item.SubItems.Add(data.VID);
                    item.SubItems.Add(data.PID);
                    item.SubItems.Add(data.EdfPath);

                    listView.Items.Add(item);
                }
            }

            listView.EndUpdate();
        }
    }
}
