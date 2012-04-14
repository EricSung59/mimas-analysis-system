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

namespace AnalysisSystem.Controls
{
    public partial class TestingControlPanel : UserControl
    {
        private RawDataModel _rawDataModel = RawDataModel.Instance;
        private RTFilter _filter;
        private HfdCalculator _hfdCalculator;

        private List<Double> _af3Buffer;
        private List<Double> _fc6Buffer;
        private List<Double> _f4Buffer;

        private List<Double> _af3FilteredBuffer;
        private List<Double> _fc6FilteredBuffer;
        private List<Double> _f4FilteredBuffer;

        private double _arousal; // FC6
        private double _valence; // AF3 - F4

        private const int BUFFER_SIZE = 640;

        //----------------------- CONSTRUCTOR -----------------------//

        public TestingControlPanel()
        {
            InitializeComponent();

            _rawDataModel.NewData += new RawDataModel.NewDataEventHandler(_rawDataModel_NewData);
            _hfdCalculator = new HfdCalculator();

            //double[] b = { 0.0783, 0, -0.1567, 0, 0.0783 };
            //double[] a = { 1.0000, -3.0097, 3.4242, -1.7943, 0.3807 };
            double[] b = { 0.0878, 0.1756, 0.0878 };
            double[] a = { 1.0000, -1.0048, 0.3561 };
            _filter = new RTFilter(2, b, a);

            _af3Buffer = new List<Double>(BUFFER_SIZE);
            _fc6Buffer = new List<Double>(BUFFER_SIZE);
            _f4Buffer = new List<Double>(BUFFER_SIZE);

            _af3FilteredBuffer = new List<Double>(BUFFER_SIZE);
            _fc6FilteredBuffer = new List<Double>(BUFFER_SIZE);
            _f4FilteredBuffer = new List<Double>(BUFFER_SIZE);
        }

        //----------------------- EVENT HANDLERS --------------------//

        private void button1_Click(object sender, EventArgs e)
        {
            _rawDataModel.Start();
            rawDataModelTimer.Start();
        }

        private void _rawDataModel_NewData(object sender, NewDataEventArgs e)
        {
            updateBuffer(_af3Buffer, _af3FilteredBuffer, Emotiv.EmotivDongle.Channels.AF3);
            updateBuffer(_fc6Buffer, _fc6FilteredBuffer, Emotiv.EmotivDongle.Channels.FC6);
            updateBuffer(_f4Buffer, _f4FilteredBuffer, Emotiv.EmotivDongle.Channels.F4);

            calculateHfd();
        }

        private void rawDataModelTimer_Tick(object sender, EventArgs e)
        {
            _rawDataModel.Process();
        }

        //----------------------- PRIVATE HELPERS -------------------//

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

        private void calculateHfd()
        {
            MWNumericArray fc6TimeSeries = new MWNumericArray(_fc6FilteredBuffer.ToArray());
            MWNumericArray af3TimeSeries = new MWNumericArray(_af3FilteredBuffer.ToArray());
            MWNumericArray f4TimeSeries = new MWNumericArray(_f4FilteredBuffer.ToArray());

            MWArray result = _hfdCalculator.CalculateHfd(fc6TimeSeries, 12);
            double[] resulta = (double[])result.ToArray();
            _arousal = (double)(_hfdCalculator.CalculateHfd(fc6TimeSeries, 12) as MWNumericArray)[0];
            _valence = (double)(_hfdCalculator.CalculateHfd(af3TimeSeries, 12) as MWNumericArray)[0] -
                       (double)(_hfdCalculator.CalculateHfd(f4TimeSeries, 12) as MWNumericArray)[0];
        }
    }
}
