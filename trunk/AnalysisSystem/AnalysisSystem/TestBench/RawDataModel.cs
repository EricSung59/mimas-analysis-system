using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Emotiv;
using System.Runtime.InteropServices;

namespace TestBench
{

    public class NewDataEventArgs : EventArgs
    {
        readonly int _nNewData = 0;

        public NewDataEventArgs(int nNewData)
        {
            _nNewData = nNewData;
        }

        public int NumberOfNewData
        {
            get
            {
                return _nNewData;
            }
        }
    }

    public class MarkerOffset
    {
        private long _dateOfset;
        public long DateOfset
        {
            get { return _dateOfset; }
            set { _dateOfset = value; }
        }
        private int _length;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }
        public MarkerOffset(long dateOfset, int length){
            _dateOfset = dateOfset;
            _length = length;
        }
    }

    public class RawDataModel
    {
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

        const int READ_TIMEOUT_MS = 100;
        const int EXPECTED_SAMPLING_RATE = 128;
        
        EmotivDongle _dongle = new EmotivDongle();

        EmotivDongle.Data _data = null;

        static RawDataModel _instance = null;       

        public delegate void NewDataEventHandler(object sender, NewDataEventArgs e);
        public delegate void DataSourceConnectedHandler(object sender, EventArgs e);
        public delegate void DataSourceDisconnectedHandler(object send, EventArgs e);
        public delegate void DataSourceStoppedHandler(object send, EventArgs e);
        public delegate void NewMarkerHanlder(object sender, NewDataEventArgs e);

        public event NewDataEventHandler NewData;
        public event DataSourceConnectedHandler DataSourceConnected;    
        public event DataSourceDisconnectedHandler DataSourceDisconnected;
        public event DataSourceStoppedHandler DataSourceStopped;
        public event NewMarkerHanlder NewMarker;

        bool _isConnected = false;
        ArrayList _markerList = new ArrayList();

        List<MarkerOffset> _markerListNew = new List<MarkerOffset>();
        MarkerOffset _oldOfset;
        MarkerOffset _newOfset;
        MarkerOffset _beforeOfset;

        bool _isStarted = false;

        void OnDataSourceConnected()
        {
            if (DataSourceConnected != null)
            {
                DataSourceConnected(this, new EventArgs());
            }
        }

        void OnDataSourceDisconnected()
        {
            if (DataSourceDisconnected != null)
            {
                DataSourceDisconnected(this, new EventArgs());
            }
        }

        void OnNewData(NewDataEventArgs e)
        {
            if (NewData != null)
            {
                NewData(this, e);
            }
        }

        void OnDataSourceStopped()
        {
            if (DataSourceStopped != null)
            {
                DataSourceStopped(this, new EventArgs());
            }
        }

        static public RawDataModel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RawDataModel();
                }

                return _instance;
            }
        }
        
        private RawDataModel()
        {            
        }

        ~RawDataModel()
        {
            if (_isConnected)
            {
                _dongle.Close();
            }
        }

        public void Start()
        {
            _isStarted = true;
        }

        public void Stop()
        {
            if (!IsStarted)
            {
                return;
            }

            _isStarted = false;

            if (_isConnected)
            {
                _isConnected = false;
                _dongle.Close();
                OnDataSourceDisconnected();
            }
        }

        public bool IsStarted
        {
            get
            {
                return _isStarted;
            }
        }

        public void Process()
        {
            // Do nothing if it's not started
            if (!IsStarted)
            {
                return;
            }

            if (!_isConnected)
            {
                if (_dongle.Open())
                {
                    _isConnected = true;
                    //test
                    
                    OnDataSourceConnected();
                }
            }
            else
            {

                EmotivDongle.Data data = _dongle.Read(READ_TIMEOUT_MS);
                if (data == null)
                {
                    _data = null;
                    _isConnected = false;
                    _dongle.Close();
                    OnDataSourceDisconnected();
                    return;
                }

                if (data.Length == 0)
                {
                    return;
                }
                
                if (_oldOfset==null)
                {
                    long _oldCounter;
                    QueryPerformanceCounter(out _oldCounter);
                    _oldOfset = new MarkerOffset(_oldCounter, data.Length);
                    _newOfset = new MarkerOffset(_oldCounter, data.Length);
                    _beforeOfset = new MarkerOffset(_oldCounter, data.Length);
                }
                else{
                    _beforeOfset = _oldOfset;
                    _oldOfset = _newOfset;
                    long _newCounter;
                    QueryPerformanceCounter(out _newCounter);
                    _newOfset = new MarkerOffset(_newCounter, data.Length);
                }

                int[] marker = data.Marker;                
                //int fixIndex = 0;
                int i = 0;
                while ( i < _markerListNew.Count )
                {
                    //NewMarker(this, new NewDataEventArgs(1));
                    long t1 = _oldOfset.DateOfset;
                    long t2 = _newOfset.DateOfset;
                    long t0 = _beforeOfset.DateOfset;
                    MarkerOffset _temp = (MarkerOffset)_markerListNew[i];
                    long t = _temp.DateOfset;
                    if ((t>= t1) && (t<=t2))
                    {
                        int index = (int)(((t - t1) * (data.Length-1)) / (t2 - t1));
                        marker[index] = _temp.Length;
                        //new marker
                        //
                        
                        NewMarker(this, new NewDataEventArgs(1));
                        _markerListNew.RemoveAt(i);
                        /*if ((t > t1) && (t < t2))
                        {
                            _markerListNew.RemoveAt(i);

                        }
                        else
                        {
                            i++;
                        }*/
                        /*if ((t == t1) || (t == t2))
                        {
                            int ok = 10;
                        }*/
                        //_markerListNew.Remove(_temp);
                        //fixIndex = 0;

                    }
                    else if (t0 > t)
                    {
                        //marker[fixIndex] = _temp.Length;
                        //fixIndex = fixIndex + 1;
                        _markerListNew.RemoveAt(i);
                    }
                    else
                    {
                        i++;
                    }
                }
                
                //for (int i = 0; i < marker.Length; ++i)
                //{
                //    if (_markerList.Count - 1 < i)
                //    {
                //        break;
                //    }

                //    //marker[i] = (int)_markerList.ToArray<int>()[i];
                //}

                ////_markerList.Clear();


                _data = data;

                OnNewData(new NewDataEventArgs(data.Length));
            }
        }

        public double[] GetGyroX()
        {
            if (_data == null)
                return null;

            return _data.GyroX;
        }

        public double[] GetGyroY()
        {
            if (_data == null)
                return null;

            return _data.GyroY;
        }
        public int[] GetBatteryLevel()
        {
            if (_data == null)
                return null;

            return _data._batteryLevel ;
        }

        public int[] GetPackageNum()
        {
            if (_data == null)
                return null;

            return _data.PackageNumber;
        }

        public int[] GetInterpolated()
        {
            if (_data == null)
                return null;
            return _data.Interplolated;
        }

        public double[] GetEegData(EmotivDongle.Channels channel)
        {
            if (_data == null)
                return null;

            return _data.GetEegData(channel);
        }

        public EmotivDongle.ContactQualityStates[] GetContactQuality(EmotivDongle.Channels channel)
        {
            if (_data == null)
                return null;

            return _data.GetContactQuality(channel);
        }

        public int[] GetRawCq()
        {
            if (_data == null)
                return null;

            return _data.RawCq;
        }

        public int[] GetMarker()
        {
            if (_data == null)
                return null;
            return _data.Marker;
        }

        public int SamplingRate
        {
            get
            {
                if (!_isConnected)
                {
                    return -1;
                }
                return _dongle.GetSamplesPerSec();
            }
        }

        public int ExpectedSamplingRate
        {
            get
            {
                return EXPECTED_SAMPLING_RATE;
            }
        }

        public bool IsConnected
        {
            get
            {
                return _isConnected;
            }
        }

        public void AddMarker(int marker)
        {
            long _markerCounter;
            QueryPerformanceCounter(out _markerCounter);
            MarkerOffset _temp = new MarkerOffset(_markerCounter, marker);
            _markerListNew.Add(_temp);   
            //            
            //_markerList.Add(marker);
        }
    }
}
