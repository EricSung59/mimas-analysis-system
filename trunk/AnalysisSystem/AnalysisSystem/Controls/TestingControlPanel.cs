using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestBench;
using AnalysisSystem.Matlab;
using MathWorks.MATLAB.NET.Arrays;
using System.IO;

namespace AnalysisSystem.Controls
{
    public partial class TestingControlPanel : UserControl
    {
        //----------------------- CLASS MEMBERS ---------------------//

        private RawDataModel _rawDataModel = RawDataModel.Instance;
        private RTFilter _filter;
        private HfdCalculator _hfdCalculator;
        private SvmModel _model;

        private List<Double> _af3Buffer;
        private List<Double> _fc6Buffer;
        private List<Double> _f4Buffer;

        private List<Double> _af3FilteredBuffer;
        private List<Double> _fc6FilteredBuffer;
        private List<Double> _f4FilteredBuffer;

        private double _arousal; // FC6
        private double _valence; // AF3 - F4

        private double _arousalMinValue;
        private double _arousalMaxValue;
        private double _valenceMinValue;
        private double _valenceMaxValue;
        private double _lowerValue;
        private double _upperValue;

        private const int BUFFER_SIZE = 640;

        //----------------------- CONSTRUCTOR -----------------------//

        public TestingControlPanel()
        {
            InitializeComponent();

            _rawDataModel.NewData += new RawDataModel.NewDataEventHandler(_rawDataModel_NewData);
            _hfdCalculator = new HfdCalculator();

            double[] b = { 0.0878, 0.1756, 0.0878 };
            double[] a = { 1.0000, -1.0048, 0.3561 };
            _filter = new RTFilter(2, b, a);

            _af3Buffer = new List<Double>(BUFFER_SIZE);
            _fc6Buffer = new List<Double>(BUFFER_SIZE);
            _f4Buffer = new List<Double>(BUFFER_SIZE);

            _af3FilteredBuffer = new List<Double>(BUFFER_SIZE);
            _fc6FilteredBuffer = new List<Double>(BUFFER_SIZE);
            _f4FilteredBuffer = new List<Double>(BUFFER_SIZE);

            // model file text box
            modelFilePathTextBox.Text =
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Mimas", "AnalysisSystem", "ModelFiles", "105.model");
        }

        //----------------------- EVENT HANDLERS --------------------//

        private void _rawDataModel_NewData(object sender, NewDataEventArgs e)
        {
            updateBuffer(_af3Buffer, _af3FilteredBuffer, Emotiv.EmotivDongle.Channels.AF3);
            updateBuffer(_fc6Buffer, _fc6FilteredBuffer, Emotiv.EmotivDongle.Channels.FC6);
            updateBuffer(_f4Buffer, _f4FilteredBuffer, Emotiv.EmotivDongle.Channels.F4);

            calculateHfd();
            scaleHfdValues();
            updateLabel();
        }

        private void rawDataModelTimer_Tick(object sender, EventArgs e)
        {
            _rawDataModel.Process();
        }

        private void modelFilePathBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                modelFilePathTextBox.Text = openFileDialog.FileName;   
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!validateInputValues())
                return;

            // Disable controls
            startButton.Enabled = false;
            modelFilePathTextBox.Enabled = false;
            arousalMaxTextBox.Enabled = false;
            arousalMinTextBox.Enabled = false;
            valenceMaxTextBox.Enabled = false;
            valenceMinTextBox.Enabled = false;
            upperTextBox.Enabled = false;
            lowerTextBox.Enabled = false;

            _model = SvmLibWrapper.LoadModel(modelFilePathTextBox.Text);

            _rawDataModel.Start();
            rawDataModelTimer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            modelFilePathTextBox.Enabled = true;
            arousalMaxTextBox.Enabled = true;
            arousalMinTextBox.Enabled = true;
            valenceMaxTextBox.Enabled = true;
            valenceMinTextBox.Enabled = true;
            upperTextBox.Enabled = true;
            lowerTextBox.Enabled = true;

            _rawDataModel.Stop();
            rawDataModelTimer.Stop();
        }

        //----------------------- PRIVATE HELPERS -------------------//

        /// <summary>
        /// Cập nhật giá trị của buffer, từ đó đưa qua bộ lọc và cho vào filteredBuffer.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="filteredBuffer"></param>
        /// <param name="channel"></param>
        private void updateBuffer(List<Double> buffer, List<Double> filteredBuffer, Emotiv.EmotivDongle.Channels channel)
        {
            List<Double> eegDataList = new List<Double>(_rawDataModel.GetEegData(channel));

            if (eegDataList.Count >= BUFFER_SIZE)
            {
                buffer.Clear();
                buffer.AddRange(eegDataList.GetRange(eegDataList.Count - BUFFER_SIZE, BUFFER_SIZE));
            }
            else
            {
                int numberOfSampleNeedToRemove = buffer.Count + eegDataList.Count - BUFFER_SIZE;
                if (numberOfSampleNeedToRemove <= 0)
                {
                    buffer.AddRange(eegDataList);
                }
                else
                {
                    buffer.RemoveRange(0, numberOfSampleNeedToRemove);
                    buffer.AddRange(eegDataList);
                }
            }

            filteredBuffer.Clear();
            filteredBuffer.AddRange(_filter.Filter(buffer.ToArray()));
        }

        /// <summary>
        /// Tính toán giá trị Hfd theo các giá trị trong 3 filtedBuffer.
        /// Giá trị sau khi tính toán được lưu trong biến toàn cục _arousal và _valence
        /// </summary>
        private void calculateHfd()
        {
            MWNumericArray fc6TimeSeries = new MWNumericArray(_fc6FilteredBuffer.ToArray());
            MWNumericArray af3TimeSeries = new MWNumericArray(_af3FilteredBuffer.ToArray());
            MWNumericArray f4TimeSeries = new MWNumericArray(_f4FilteredBuffer.ToArray());
            
            _arousal = ((double[,])_hfdCalculator.CalculateHfd(fc6TimeSeries, 12).ToArray())[0, 0];
            _valence = ((double[,])_hfdCalculator.CalculateHfd(af3TimeSeries, 12).ToArray())[0, 0] -
                       ((double[,])_hfdCalculator.CalculateHfd(f4TimeSeries, 12).ToArray())[0, 0];

            if (Double.IsNaN(_arousal) || Double.IsNaN(_valence))
            {
                _arousal = 0;
                _valence = 0;
            }
        }

        /// <summary>
        /// Scale các giá trị _arousal và _valence
        /// </summary>
        private void scaleHfdValues()
        {
            // Arousal
            if (_arousal <= _arousalMinValue)
            {
                _arousal = _lowerValue;
            }
            else if (_arousal >= _arousalMaxValue)
            {
                _arousal = _upperValue;
            }
            else
            {
                _arousal = _lowerValue + ((_arousal - _arousalMinValue) / (_arousalMaxValue - _arousalMinValue)) * (_upperValue - _lowerValue);
            }

            // Valence
            if (_valence <= _valenceMinValue) 
            {
                _valence = _lowerValue;
            }
            else if (_valence >= _valenceMaxValue)
            {
                _valence = _upperValue;
            }
            else
            {
                _valence = _lowerValue + ((_valence - _valenceMinValue) / (_valenceMaxValue - _valenceMinValue)) * (_upperValue - _lowerValue);
            }
        }

        /// <summary>
        /// Cập nhật nhãn cảm xúc dựa theo các giá trị _valence và _arousal đã tính được
        /// </summary>
        private void updateLabel()
        {
            SvmNode[] nodes = new SvmNode[3];
            nodes[0] = new SvmNode(1, _arousal);
            nodes[1] = new SvmNode(2, _valence);
            nodes[2] = new SvmNode(-1, 0);
            labelLabel.Text = SvmLibWrapper.Predict(_model, nodes).ToString();
        }

        /// <summary>
        /// Kiểm tra các giá trị nhập vào
        /// </summary>
        /// <returns></returns>
        private bool validateInputValues()
        {
            if (!File.Exists(modelFilePathTextBox.Text))
            {
                MessageBox.Show("Không tìm thấy file " + modelFilePathTextBox.Text + "\nKiểm tra lại đường dẫn");
                return false;
            }

            try
            {
                _lowerValue = Convert.ToDouble(lowerTextBox.Text);
                _upperValue = Convert.ToDouble(upperTextBox.Text);

                _arousalMinValue = Convert.ToDouble(arousalMinTextBox.Text);
                _arousalMaxValue = Convert.ToDouble(arousalMaxTextBox.Text);
                _valenceMinValue = Convert.ToDouble(valenceMinTextBox.Text);
                _valenceMaxValue = Convert.ToDouble(valenceMaxTextBox.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
                return false;
            }

            return true;
        }
    }
}
