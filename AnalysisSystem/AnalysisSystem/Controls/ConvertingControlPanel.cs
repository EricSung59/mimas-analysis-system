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

        String _baseFolderPath;
        String _csvFolderName = "CsvFiles";
        String _csvFolderPath;

        //-------------- CONSTRUCTOR ----------------------//

        public ConvertingControlPanel()
        {
            InitializeComponent();

            _baseFolderPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                @"Mimas\AnalysisSystem");
            if (!Directory.Exists(_baseFolderPath))
                Directory.CreateDirectory(_baseFolderPath);

            _csvFolderPath = Path.Combine(_baseFolderPath, _csvFolderName);
            if (!Directory.Exists(_csvFolderPath))
                Directory.CreateDirectory(_csvFolderPath);

            outFolderTextBox.Text = _csvFolderPath;
        }

        //-------------- EVENT HANDLERS -------------------//

        private void convertButton_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void outFolderBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outFolderTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            String acquisitionBasePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                @"Mimas\DataAcquisition");
            String edfFilePath = Path.Combine(acquisitionBasePath, "EdfFiles");

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

            _analysisSystemForm.StatusLabel.Text = "Converting";
            convertButton.Enabled = false;

            int i = 0;
            foreach (ListViewItem item in choosingControlPanel.ListView.Items)
            {
                _analysisSystemForm.StatusLabel.Text = "Converting... (" + i++ + "/" + choosingControlPanel.ListView.Items.Count + ")";
                string inputFile = Path.Combine(edfFilePath, item.SubItems[3].Text);
                if (!File.Exists(inputFile))
                    continue;

                string outputFile = Path.Combine(
                    outFolderTextBox.Text,
                    Path.ChangeExtension(Path.GetFileName(inputFile), "csv"));
                if (File.Exists(outputFile))
                    File.Delete(outputFile);

                process.StartInfo.Arguments = "--inputfile " + inputFile + " --outputfile " + outputFile;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();
            }

            _analysisSystemForm.StatusLabel.Text = "Convert done";
            convertButton.Enabled = true;
        }

        //-------------- PROPERTIES -----------------------//

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
    }
}
