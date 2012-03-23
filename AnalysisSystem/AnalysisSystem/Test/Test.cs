using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnalysisSystem.Test
{
    public partial class Test : Form
    {
        AnalysisSystemDataContext _db;

        public Test()
        {
            InitializeComponent();
            _db = new AnalysisSystemDataContext();

            //CreateMyListView();
            //PopulateListView();
            test();
        }

        private void test()
        {
            listView.View = View.Details;
            listView.CheckBoxes = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Descending;
            listView.FullRowSelect = true;
            listView.HideSelection = false;

            listView.ColumnClick += new ColumnClickEventHandler(listView_ColumnClick);

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

            listView.BeginUpdate();
            var instances = 
                from vp in _db.VolPics
                from s in _db.Samples
                where vp.SID == s.SID
                select new {vp.SID, vp.VID, vp.PID, s.EdfPath};
            
            foreach (var instance in instances)
            {
                ListViewItem item = new ListViewItem(instance.SID);
                item.SubItems.Add(instance.VID);
                item.SubItems.Add(instance.PID);
                item.SubItems.Add(instance.EdfPath);
                listView.Items.Add(item);
            }
            listView.EndUpdate();
        }

        void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView.BeginUpdate();
            if (listView.Sorting == SortOrder.Descending)
                listView.Sorting = SortOrder.Ascending;
            else
                listView.Sorting = SortOrder.Descending;
            listView.EndUpdate();
        }

        private void CreateMyListView()
        {
            // Create a new ListView control.
            ListView listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));

            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0);
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center);

            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            // Initialize the ImageList objects with bitmaps.
            imageListSmall.Images.Add(Bitmap.FromFile(@"D:\ToanBK\Desktop\Images\MySmallImage1.jpg"));
            imageListSmall.Images.Add(Bitmap.FromFile(@"D:\ToanBK\Desktop\Images\MySmallImage2.jpg"));
            imageListLarge.Images.Add(Bitmap.FromFile(@"D:\ToanBK\Desktop\Images\MyLargeImage1.jpg"));
            imageListLarge.Images.Add(Bitmap.FromFile(@"D:\ToanBK\Desktop\Images\MyLargeImage2.jpg"));

            //Assign the ImageList objects to the ListView.
            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;

            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
        }

        private void PopulateListView()
        {
            ListView listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));

            listView1.Width = 270;
            listView1.Location = new System.Drawing.Point(10, 10);

            // Declare and construct the ColumnHeader objects.
            ColumnHeader header1, header2;
            header1 = new ColumnHeader();
            header2 = new ColumnHeader();

            // Set the text, alignment and width for each column header.
            header1.Text = "File name";
            header1.TextAlign = HorizontalAlignment.Left;
            header1.Width = 70;

            header2.TextAlign = HorizontalAlignment.Left;
            header2.Text = "Location";
            header2.Width = 200;

            // Add the headers to the ListView control.
            listView1.Columns.Add(header1);
            listView1.Columns.Add(header2);

            // Specify that each item appears on a separate line 
            listView1.View = View.Details;

            // Populate the ListView.Items property.
            // Set the directory to the sample picture directory.
            System.IO.DirectoryInfo dirInfo =
                new System.IO.DirectoryInfo(
                "C:\\Documents and Settings\\All Users" +
                "\\Documents\\My Pictures\\Sample Pictures");


            // Get the .jpg files from the directory
            System.IO.FileInfo[] files = dirInfo.GetFiles("*.jpg");

            // Add each file name and full name including path
            // to the ListView.
            if (files != null)
            {
                foreach (System.IO.FileInfo file in files)
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.FullName);
                    listView1.Items.Add(item);
                }
            }

            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView.BeginUpdate();
            foreach (ListViewItem item in listView.Items)
            {
                item.Selected = !item.Selected;
            }
            listView.EndUpdate();
            listView.Focus();
        }
    }
}
