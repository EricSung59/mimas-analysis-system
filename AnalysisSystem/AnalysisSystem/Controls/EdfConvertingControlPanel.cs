using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AnalysisSystem.Forms;

namespace AnalysisSystem.Controls
{
    public partial class EdfConvertingControlPanel : UserControl
    {
        AnalysisSystemForm _analysisSystemForm;

        String _baseFolderPath;
        String _csvFolderName = "DataCsvFiles";
        String _csvFolderPath;

        AnalysisSystemDataContext _db = new AnalysisSystemDataContext();

        //-------------- CONSTRUCTOR ----------------------//

        public EdfConvertingControlPanel()
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

            outFolderChooserControlPanel.OutFolderPathTextBox.Text = _csvFolderPath;
        }

        //-------------- EVENT HANDLERS -------------------//

        private void convertButton_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            String acquisitionBasePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                @"Mimas\DataAcquisition");
            String edfFilePath = Path.Combine(acquisitionBasePath, "EdfFiles");

            if (!Directory.Exists(edfFilePath))
            {
                _analysisSystemForm.SetStatus("Cannot find folder " + edfFilePath);
                return;
            }

            String converterPath = Path.Combine(Application.StartupPath, "EDFConverterConsole.exe");
            if (!File.Exists(converterPath))
            {
                _analysisSystemForm.SetStatus("Cannot find EDFConverterConsole.exe");
                return;
            }

            Process process = new Process();
            process.StartInfo.FileName = converterPath;

            _analysisSystemForm.SetStatus("Converting...");
            convertButton.Enabled = false;

            int i = 0;
            foreach (ListViewItem item in choosingControlPanel.ListView.Items)
            {
                _analysisSystemForm.SetStatus("Converting... (" + i++ + "/" + choosingControlPanel.ListView.Items.Count + ")");
                string inputFile = Path.Combine(edfFilePath, item.SubItems[6].Text);
                if (!File.Exists(inputFile))
                    continue;

                string outputFile = Path.Combine(
                    outFolderChooserControlPanel.OutFolderPathTextBox.Text,
                    Path.ChangeExtension(Path.GetFileName(inputFile), ".data.csv"));
                if (File.Exists(outputFile))
                    File.Delete(outputFile);

                process.StartInfo.Arguments = "--inputfile " + inputFile + " --outputfile " + outputFile;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                Sample sample = (
                    from samples
                    in _db.Samples
                    where samples.SID == item.Text
                    select samples).Single();

                sample.DataCsvPath = Path.GetFileName(outputFile);
            }

            _db.SubmitChanges();

            _analysisSystemForm.SetStatus("Converting... done");
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
