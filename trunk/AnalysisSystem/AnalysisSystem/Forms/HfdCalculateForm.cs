using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnalysisSystem.Matlab;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;

namespace AnalysisSystem.Forms
{
    public partial class HfdCalculateForm : Form
    {
        private HfdCalculator _hfdCalculator = new HfdCalculator();
        private Electrodes[] _electrodes = { Electrodes.AF3, Electrodes.FC6, Electrodes.F4 };
        private List<Double[]> _electrodeValuesList;

        private int _skipSamples = 128;
        private int _base = 640;
        private int _windowSize = 16;
        private int _count = 30;

        //---------------------------- CONSTRUCTOR -------------------------//

        public HfdCalculateForm()
        {
            InitializeComponent();

            _electrodeValuesList = new List<double[]>(_electrodes.Count());
            for (int i = 0; i < _electrodes.Count(); i++)
            {
                _electrodeValuesList.Add(new double[0]);
            }
        }

        //---------------------------- EVENT HANDLERS ----------------------//

        private void inputFolderBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                inputFolderTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void outputFolderBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputFolderTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(inputFolderTextBox.Text))
            {
                MessageBox.Show("Không tìm thấy thư mục theo đường dẫn " + inputFolderTextBox.Text);
                return;
            }

            if (!Directory.Exists(outputFolderTextBox.Text))
            {
                MessageBox.Show("Không tìm thấy thư mục theo đường dẫn " + outputFolderTextBox.Text);
                return;
            }

            String[] inputFilePaths = Directory.GetFiles(inputFolderTextBox.Text, "*.csv");

            // Xu ly tung file
            foreach (String filepath in inputFilePaths)
            {
                CsvReader reader = new CsvReader(filepath);

                // Lay gia tri cua dien cuc
                for (int i = 0; i < _electrodes.Count(); i++)
                {
                    _electrodeValuesList[i] = reader.GetColumn(_electrodes[i]);
                }

                // Kiem tra file xem co du so luong dong` hay ko
                int numberOfLines = _electrodeValuesList[0].Count();
                if (numberOfLines < _skipSamples + _base + _windowSize * _count)
                {
                    MessageBox.Show("File " + filepath + " không đủ số dòng cần thiết");
                    continue;
                }

                // Bat dau ghi ra file
                string outfilepath = Path.Combine(outputFolderTextBox.Text, Path.GetFileNameWithoutExtension(filepath) + ".fd.csv");
                using (CsvWriter writer = new CsvWriter(outfilepath, _electrodes))
                {
                    // Dich chuyen theo cua so
                    for (int i = 0; i < _count; i++)
                    {
                        int startIndex = _skipSamples + i * _windowSize;
                        int endIndex = _skipSamples + _base + i * _windowSize;

                        // Xac dinh dong`
                        string line = "";
                        for (int j = 0; j < _electrodes.Count(); j++)
                        {
                            if (j != _electrodes.Count() - 1)
                                line = line + calculateHfd(_electrodeValuesList[j], startIndex, endIndex).ToString() + ",";
                            else
                                line = line + calculateHfd(_electrodeValuesList[j], startIndex, endIndex).ToString();
                        }

                        writer.WriteLine(line);
                    }
                }
            }

            MessageBox.Show("Đã xử lý xong.");
        }

        //---------------------------- PRIVATE HELPERS ---------------------//

        private double calculateHfd(double[] input, int startIndex, int endIndex)
        {
            List<Double> timeSeriesList = new List<Double>();
            for (int i = startIndex; i <= endIndex; i++)
            {
                timeSeriesList.Add(input[i]);
            }
            MWNumericArray timeSeriesNumericArray = new MWNumericArray(timeSeriesList.ToArray());

            return ((double[,])_hfdCalculator.CalculateHfd(timeSeriesNumericArray, 12).ToArray())[0, 0];
        }
    }
}
