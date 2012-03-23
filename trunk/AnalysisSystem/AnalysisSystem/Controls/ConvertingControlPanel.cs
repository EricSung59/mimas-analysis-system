using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using AnalysisSystem.Forms;

namespace AnalysisSystem.Controls
{
    public partial class ConvertingControlPanel : UserControl
    {
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
                choosingControlPanel.AnalysisSystemForm = value;
            }
        }

        public ConvertingControlPanel()
        {
            InitializeComponent();
        }

        public ConvertingControlPanel(AnalysisSystemForm form)
            : this()
        {
            _analysisSystemForm = form;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            String acquisitionBasePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                @"Mimas JSC\Data Acquisition");
            String edfFilePath = Path.Combine(acquisitionBasePath, "Edf Files");

            if (!Directory.Exists(edfFilePath))
            {
                _analysisSystemForm.StatusLabel.Text = "Cannot find folder " + edfFilePath;
                return;
            }

            String converterPath = Path.Combine(Application.StartupPath, "EDFConverterConsole.exe");
            if (!File.Exists(converterPath))
            {
                _analysisSystemForm.StatusLabel.Text = "Cannot find EDFConverterConsole.exe";
                return;
            }

            Process process = new Process();
            process.StartInfo.FileName = converterPath;

            foreach (ListViewItem item in choosingControlPanel.ListView.Items)
            {
                string inputFile = Path.Combine(edfFilePath, item.SubItems[3].Text);
                if (!File.Exists(inputFile))
                    continue;

                string outputFile = Path.Combine(
                    choosingControlPanel.OutFolderTextBox.Text,
                    Path.ChangeExtension(Path.GetFileName(inputFile), "csv"));
                if (File.Exists(outputFile))
                    File.Delete(outputFile);

                process.StartInfo.Arguments = "--inputfile " + inputFile + " --outputfile " + outputFile;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();
            }
        }
    }
}
