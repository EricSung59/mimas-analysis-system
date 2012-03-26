using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace AnalysisSystem.Forms
{
    public partial class ChoosingForm : Form
    {
        AnalysisSystemDataContext _db = new AnalysisSystemDataContext();

        public ChoosingForm()
        {
            InitializeComponent();

            CancelButton = cancelButton;

            loadListView();
            loadVolunteerIdInListBox();
            loadPictureIdInListBox();
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
            while (volunteerIdInListBox.SelectedItems.Count > 0)
            {
                Object volunteerId = volunteerIdInListBox.SelectedItems[0];
                volunteerIdInListBox.Items.Remove(volunteerId);
                volunteerIdOutListBox.Items.Add(volunteerId);
            }

            updateListView();
        }

        private void volunteerIdPullOutAllButton_Click(object sender, EventArgs e)
        {
            while (volunteerIdInListBox.Items.Count > 0)
            {
                Object item = volunteerIdInListBox.Items[0];
                volunteerIdInListBox.Items.Remove(item);
                volunteerIdOutListBox.Items.Add(item);
            }

            updateListView();
        }

        private void volunteerIdPushInOneButton_Click(object sender, EventArgs e)
        {
            while (volunteerIdOutListBox.SelectedItems.Count > 0)
            {
                Object item = volunteerIdOutListBox.SelectedItems[0];
                volunteerIdOutListBox.Items.Remove(item);
                volunteerIdInListBox.Items.Add(item);
            }

            updateListView();
        }

        private void volunteerIdPushInAllButton_Click(object sender, EventArgs e)
        {
            while (volunteerIdOutListBox.Items.Count > 0)
            {
                Object item = volunteerIdOutListBox.Items[0];
                volunteerIdOutListBox.Items.Remove(item);
                volunteerIdInListBox.Items.Add(item);
            }

            updateListView();
        }

        //
        // Picture
        //

        private void pictureIdPullOutOneButton_Click(object sender, EventArgs e)
        {
            while (pictureIdInListBox.SelectedItems.Count > 0)
            {
                Object pictureId = pictureIdInListBox.SelectedItems[0];
                pictureIdInListBox.Items.Remove(pictureId);
                pictureIdOutListBox.Items.Add(pictureId);
            }

            updateListView();
        }

        private void pictureIdPullOutAllButton_Click(object sender, EventArgs e)
        {
            while (pictureIdInListBox.Items.Count > 0)
            {
                Object item = pictureIdInListBox.Items[0];
                pictureIdInListBox.Items.Remove(item);
                pictureIdOutListBox.Items.Add(item);
            }

            updateListView();
        }

        private void pictureIdPushInOneButton_Click(object sender, EventArgs e)
        {
            while (pictureIdOutListBox.SelectedItems.Count > 0)
            {
                Object item = pictureIdOutListBox.SelectedItems[0];
                pictureIdOutListBox.Items.Remove(item);
                pictureIdInListBox.Items.Add(item);
            }

            updateListView();
        }

        private void pictureIdPushInAllButton_Click(object sender, EventArgs e)
        {
            while (pictureIdOutListBox.Items.Count > 0)
            {
                Object item = pictureIdOutListBox.Items[0];
                pictureIdOutListBox.Items.Remove(item);
                pictureIdInListBox.Items.Add(item);
            }

            updateListView();
        }

        //
        // ListBox
        //

        private void volunteerIdInListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = volunteerIdInListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                Object item = volunteerIdInListBox.Items[index];
                volunteerIdInListBox.Items.Remove(item);
                volunteerIdOutListBox.Items.Add(item);

                updateListView();
            }
        }

        private void volunteerIdOutListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = volunteerIdOutListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                Object item = volunteerIdOutListBox.Items[index];
                volunteerIdOutListBox.Items.Remove(item);
                volunteerIdInListBox.Items.Add(item);

                updateListView();
            }
        }

        private void pictureIdInListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = pictureIdInListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                Object item = pictureIdInListBox.Items[index];
                pictureIdInListBox.Items.Remove(item);
                pictureIdOutListBox.Items.Add(item);

                updateListView();
            }
        }

        private void pictureIdOutListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = pictureIdOutListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                Object item = pictureIdOutListBox.Items[index];
                pictureIdOutListBox.Items.Remove(item);
                pictureIdInListBox.Items.Add(item);

                updateListView();
            }
        }

        // -------------- PROPERTIES -----------------//

        public ListView ListView
        {
            get { return listView; }
        }

        // -------------- PRIVATE HELPERS --------------//

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
                item.Name = data.SID;
                item.SubItems.Add(data.VID);
                item.SubItems.Add(data.PID);
                item.SubItems.Add(data.EdfPath);

                listView.Items.Add(item);
            }

            listView.EndUpdate();
        }

        private void updateListView()
        {
            listView.BeginUpdate();

            var dataQuery =
                    from samples in _db.Samples
                    from volpics in _db.VolPics
                    where samples.SID == volpics.SID
                    orderby samples.SID ascending
                    select new { samples.SID, samples.EdfPath, volpics.VID, volpics.PID };

            ArrayList sidList = new ArrayList();
            foreach (ListViewItem item in listView.Items)
            {
                sidList.Add(item.Text);
            }
            sidList.Sort();
            
            foreach (var data in dataQuery)
            {
                if (FindUtils.Find(sidList, data.SID))
                {
                    if (!volunteerIdInListBox.Items.Contains(data.VID) || !pictureIdInListBox.Items.Contains(data.PID))
                    {
                        listView.Items.RemoveByKey(data.SID);
                    }
                }
                else
                {
                    if (volunteerIdInListBox.Items.Contains(data.VID) && pictureIdInListBox.Items.Contains(data.PID))
                    {
                        ListViewItem item = new ListViewItem();

                        item.Text = data.SID;
                        item.Name = data.SID;

                        item.SubItems.AddRange(new String[]
                            {
                                data.VID, data.PID, data.EdfPath
                            }
                        );

                        listView.Items.Add(item);
                    }
                }
            }

            listView.EndUpdate();
        }
    }
}
