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

namespace AnalysisSystem.Controls
{
    public partial class HfdCalculatingControlPanel : UserControl
    {
        AnalysisSystemForm _analysisSystemForm;
        HfdCalculator _hfdCalculator;

        String _baseFolderPath;
        String _outCsvFolderName = "HfdCsvFiles";
        String _outCsvFolderPath;
        String _inCsvFolderName = "DataCsvFiles";
        String _inCsvFolderPath;

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
            int startSignal = 0;
            int totalSignal = 0;
            int kMax = 0;
            _analysisSystemForm.SetStatus("");

            try
            {
                startSignal = Convert.ToInt32(startSignalTextBox.Text);
                totalSignal = Convert.ToInt32(totalSignalTextBox.Text);
                kMax = Convert.ToInt32(kMaxTextBox.Text);
            }
            catch (Exception)
            {
                _analysisSystemForm.SetStatus("Input wrong format.");
                return;
            }

            foreach (ListViewItem item in choosingControlPanel.ListView.Items)
            {
                MWCharArray inputFilePath = new MWCharArray(Path.Combine(_inCsvFolderPath, item.SubItems[7].Text));
                MWCharArray outputFilePath = new MWCharArray(Path.Combine(_outCsvFolderPath, item.Text + "-fd.csv"));
                MWNumericArray kMaxNumericArray = new MWNumericArray(kMax);
                MWNumericArray totalSignalNumericArray = new MWNumericArray(totalSignal);
                MWNumericArray startSignalNumericArray = new MWNumericArray(startSignal);

                if (File.Exists(inputFilePath.ToString()))
                    _hfdCalculator.Calculate(inputFilePath, outputFilePath, kMaxNumericArray, totalSignalNumericArray, startSignalNumericArray);
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
