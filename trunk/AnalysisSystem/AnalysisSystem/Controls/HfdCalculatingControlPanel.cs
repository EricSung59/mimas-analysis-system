using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnalysisSystem.Forms;
using AnalysisSystem.Matlab;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using System.IO;
using System.Collections;

namespace AnalysisSystem.Controls
{
    public partial class HfdCalculatingControlPanel : UserControl
    {
        AnalysisSystemForm _analysisSystemForm;
        HfdCalculator _hfdCalculator;

        AnalysisSystemDataContext _db = new AnalysisSystemDataContext();

        String _baseFolderPath;
        String _outCsvFolderName = "HfdCsvFiles";
        String _outCsvFolderPath;
        String _inCsvFolderName = "DataCsvFiles";
        String _inCsvFolderPath;

        int _startSignal = 0;
        int _totalSignal = 0;
        int _kMax = 0;

        //-------------------------- CONSTRUCTOR ---------------------------//

        public HfdCalculatingControlPanel()
        {
            InitializeComponent();
            
            _hfdCalculator = new HfdCalculator();
            
            _baseFolderPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                @"Mimas\AnalysisSystem");
            if (!Directory.Exists(_baseFolderPath))
                Directory.CreateDirectory(_baseFolderPath);

            _outCsvFolderPath = Path.Combine(_baseFolderPath, _outCsvFolderName);
            if (!Directory.Exists(_outCsvFolderPath))
                Directory.CreateDirectory(_outCsvFolderPath);

            outFolderChooserControlPanel.OutFolderPathTextBox.Text = _outCsvFolderPath;

            _inCsvFolderPath = Path.Combine(_baseFolderPath, _inCsvFolderName);
        }

        //-------------------------- EVENT HANDLERS ------------------------//

        private void processButton_Click(object sender, EventArgs e)
        {
            _analysisSystemForm.SetStatus("");

            try
            {
                _startSignal = Convert.ToInt32(startSignalTextBox.Text);
                _totalSignal = Convert.ToInt32(totalSignalTextBox.Text);
                _kMax = Convert.ToInt32(kMaxTextBox.Text);
            }
            catch (Exception)
            {
                _analysisSystemForm.SetStatus("Input wrong format.");
                return;
            }

            var sampleQuery =
                from samples in _db.Samples
                orderby samples.SID ascending
                select samples;

            List<AnalysisSystemUtils.AnalysisSystemTaskArgs> itemToSearchList = new List<AnalysisSystemUtils.AnalysisSystemTaskArgs>();
            int total = sampleQuery.Count();
            int ordinal = 0;
            foreach (Sample sample in sampleQuery)
            {
                ordinal++;
                AnalysisSystemUtils.AnalysisSystemTaskArgs args 
                    = new AnalysisSystemUtils.AnalysisSystemTaskArgs(sample.SID, ordinal, total);
                args.Sample = sample;

                itemToSearchList.Add(args);
            }

            _analysisSystemForm.SetStatus("Converting...");

            AnalysisSystemUtils.PerformTask(
                choosingControlPanel.ListView.Items,
                itemToSearchList,
                new AnalysisSystemUtils.AnalysisSystemTask(createCsvFileAndUpdateDataBase));

            _db.SubmitChanges();

            _analysisSystemForm.SetStatus("Converting... Done");
        }

        //-------------------------- PRIVATE HELPDERS ----------------------//

        private void createCsvFileAndUpdateDataBase(AnalysisSystemUtils.AnalysisSystemTaskArgs args)
        {
            if (args.Sample.DataCsvPath != null)
            {
                _analysisSystemForm.SetStatus("Converting... " + args.Ordinal + "/" + args.Total);

                string inputFilePath = Path.Combine(_inCsvFolderPath, args.Sample.DataCsvPath);
                string outputFilePath = Path.Combine(_outCsvFolderPath, args.Sample.SID + ".fd.csv");

                if (File.Exists(inputFilePath))
                {
                    _hfdCalculator.Calculate(inputFilePath, outputFilePath, _kMax, _totalSignal, _startSignal);
                    args.Sample.HfdCsvPath = Path.GetFileName(outputFilePath);
                }
            }
        }

        //-------------------------- PROPERTIES ----------------------------//

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
