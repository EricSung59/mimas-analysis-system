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

namespace AnalysisSystem.Controls
{
    public partial class ChoosingControlPanel : UserControl
    {
        AnalysisSystemDataContext _db;

        String _baseFolderPath;
        String _csvFolderName = "Csv Files";
        String _csvFolderPath;

        AnalysisSystemForm _analysisSystemForm;
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

        public ChoosingControlPanel()
        {
            InitializeComponent();
            _db = new AnalysisSystemDataContext();

            _baseFolderPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                @"Mimas JSC\Analysis System");
            if (!Directory.Exists(_baseFolderPath))
                Directory.CreateDirectory(_baseFolderPath);

            _csvFolderPath = Path.Combine(_baseFolderPath, _csvFolderName);
            if (!Directory.Exists(_csvFolderPath))
                Directory.CreateDirectory(_csvFolderPath);

            outFolderTextBox.Text = _csvFolderPath;
        }

        public ChoosingControlPanel(AnalysisSystemForm form)
            : this()
        {
            _analysisSystemForm = form;
        }

        private void outFolderBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outFolderTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void selectSampleButton_Click(object sender, EventArgs e)
        {
            _analysisSystemForm.StatusLabel.Text = "Choosing sample";

            ChoosingForm form = new ChoosingForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                listView.BeginUpdate();

                listView.Items.Clear();
                foreach (ListViewItem item in form.ListView.SelectedItems)
                {
                    listView.Items.Add(item.Clone() as ListViewItem);
                }

                listView.EndUpdate();
            }

            _analysisSystemForm.StatusLabel.Text = "";
        }

        public ListView ListView
        {
            get { return listView; }
        }

        public TextBox OutFolderTextBox
        {
            get { return outFolderTextBox; }
        }
    }
}
