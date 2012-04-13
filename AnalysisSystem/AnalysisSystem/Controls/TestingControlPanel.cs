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

            double[] b = { 0.0783, 0, -0.1567, 0, 0.0783 };
            double[] a = { 1.0000, -3.0097, 3.4242, -1.7943, 0.3807 };
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

        }

        private void _rawDataModel_NewData(object sender, NewDataEventArgs e)
        {
            updateBuffer(_af3Buffer, _af3FilteredBuffer, Emotiv.EmotivDongle.Channels.AF3);
            updateBuffer(_fc6Buffer, _fc6FilteredBuffer, Emotiv.EmotivDongle.Channels.FC6);
            updateBuffer(_f4Buffer, _f4FilteredBuffer, Emotiv.EmotivDongle.Channels.F4);

            calculateHfd();
        }

        //----------------------- PRIVATE HELPERS -------------------//

        private void updateBuffer(List<Double> buffer, List<Double> filteredBuffer, Emotiv.EmotivDongle.Channels channel)
        {
            double[] eegData = _rawDataModel.GetEegData(channel);
            int numberOfSampleNeedToRemove = _af3Buffer.Count + eegData.Length - BUFFER_SIZE;

            if (numberOfSampleNeedToRemove <= 0)
            {
                buffer.AddRange(eegData);
            }
            else
            {
                buffer.RemoveRange(0, numberOfSampleNeedToRemove);
                buffer.AddRange(eegData);
            }

            filteredBuffer.Clear();
            filteredBuffer.AddRange(_filter.Filter(buffer.ToArray()));
        }

        private void calculateHfd()
        {
            MWNumericArray fc6TimeSeries = new MWNumericArray(_fc6FilteredBuffer.ToArray());
            MWNumericArray af3TimeSeries = new MWNumericArray(_af3FilteredBuffer.ToArray());
            MWNumericArray f4TimeSeries = new MWNumericArray(_f4FilteredBuffer.ToArray());

            _arousal = (double)(_hfdCalculator.CalculateHfd(fc6TimeSeries, 12) as MWNumericArray)[0];
            _valence = (double)(_hfdCalculator.CalculateHfd(af3TimeSeries, 12) as MWNumericArray)[0] -
                       (double)(_hfdCalculator.CalculateHfd(f4TimeSeries, 12) as MWNumericArray)[0];
        }
    }
}
