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
        AnalysisSystemDataContext _db = new AnalysisSystemDataContext();

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
    }
}
