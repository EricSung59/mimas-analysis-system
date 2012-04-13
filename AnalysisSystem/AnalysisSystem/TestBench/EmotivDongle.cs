using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;
using System.Diagnostics;

namespace Emotiv
{   
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    struct Package {
		public Int32 interpolated;
        public Int32 packageNum;
        public Int32 batteryLevel;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst=16)]
        public Int32[] eegData;
        public Int32 gyroX;
        public Int32 gyroY;
        public Int32 reserved;	
	};

    struct SquareWaveChannelParam {
        public int offset;
        public int range;
        public SquareWaveChannelParam(int offset, int range)
        {
            this.offset = offset;
            this.range = range;
        }
    };

    public class EmotivDongle
    {
        public class Data
        {          
            public double[] _gyroX = null;
            public double[] _gyroY = null;
            public int[] _packageNumber = null;
            public int[] _interpolated = null;
            public ContactQualityStates[][] _cq = null;
            public double[][] _eegData = null;
            public int[] _rawCq = null;
            public int[] _marker = null;
            public int[] _batteryLevel = null;

            public Data(int nData)
            {
                if (nData == 0) return;

                _gyroX = new double[nData];
                _gyroY = new double[nData];
                _packageNumber = new int[nData];
                _interpolated = new int[nData];
                _batteryLevel = new int[nData];
                _cq = new ContactQualityStates[EmotivDongle.NUMBER_OF_EEG_CHAN + 2][];
                for (int i = 0; i < _cq.Length; ++i)
                {
                    _cq[i] = new ContactQualityStates[nData];
                }

                _eegData = new double[EmotivDongle.NUMBER_OF_EEG_CHAN][];
                for (int i = 0; i < _eegData.Length; ++i)
                {
                    _eegData[i] = new double[nData];
                }
                _rawCq = new int[nData];
                _marker = new int[nData];
            }

            public int Length
            {
                get
                {
                    if (_packageNumber == null)
                    {
                        return 0;
                    }
                    return _packageNumber.Length;
                }
            }

            public ContactQualityStates[] GetContactQuality(Channels channel)
            {
                if (Length == 0) return null;
                return _cq[(int)channel];
            }

            public double[] GetEegData(Channels channel)
            {
                if (Length == 0) return null;

                if (channel == Channels.CMS || channel == Channels.DRL)
                {
                    return null;
                }

                return _eegData[(int)channel];
            }

            public double[] GyroX
            {
                get
                {
                    if (Length == 0) return null;

                    return _gyroX;
                }
            }           
            public double[] GyroY
            {
                get
                {
                    if (Length == 0) return null;

                    return _gyroY;
                }
            }

            public int[] PackageNumber
            {
                get
                {
                    if (Length == 0) return null;

                    return _packageNumber;
                }
            }
            public int[] Interplolated
            {
                get
                {
                    if (Length == 0) return null;

                    return _interpolated;
                }
            }
            public int[] BatteryLevel
            {
                get
                {
                    if (Length == 0) return null;

                    return _batteryLevel;
                }
            }

            public int[] RawCq
            {
                get
                {
                    if (Length == 0) return null;
                    return _rawCq;
                }
            }

            public int[] Marker
            {
                get
                {
                    if (Length == 0) return null;
                    return _marker;
                }
            }
        };

        const double EEG_MULTIPLIER = 1 / 1.95;

        const float CQ_RED_THRESH = 0.20f;
        const float CQ_ORANGE_THRESH = 0.70f;
        const float CQ_YELLOW_THRESH = 1.30f;
        const float CQ_GREEN_THRESH = 1.70f;	

        const int SAMPLING_RATE = 128;
        const int BUFFER_SIZE_IN_SEC = 5;
        public const int NUMBER_OF_EEG_CHAN = 14;

        static int _dongleID = 0;
        //manh-code-begin
        static int _selectedDongle = 0;

        public static int SelectedDongle
        {
            get { return EmotivDongle._selectedDongle; }
            set { EmotivDongle._selectedDongle = value; }
        }
        //manh-code-end
        IntPtr _handle = IntPtr.Zero;
        IntPtr _internalBuf = IntPtr.Zero;
        IntPtr _packageBuf = IntPtr.Zero;
        byte[] _buf = null;

        public enum ContactQualityStates
        {
            NO_SIGNAL, VERY_BAD, POOR, FAIR, GOOD
        }

        public enum Channels
        {
            AF3 = 0, F7, F3, FC5, T7,
            P7, O1, O2, P8, T8,
            FC6, F4, F8, AF4, CMS, DRL
        };

        RawChannels[] _rawChanMapping = {
            RawChannels.F3, RawChannels.FC5, RawChannels.AF3, RawChannels.F7,
            RawChannels.T7, RawChannels.P7, RawChannels.O1, RawChannels.SQ_WAVE,
            RawChannels.UNDEFINED, RawChannels.O2, RawChannels.P8, RawChannels.T8,
            RawChannels.F8, RawChannels.AF4, RawChannels.FC6, RawChannels.F4 };

        int[] _rawChannelToChannelMapping = null;

        int[] _cqMapping = null;
        ArrayList _targetChannels = new ArrayList();
        uint _sampleSizeInByte = 0;
        uint _bufferSizeInSample = SAMPLING_RATE * BUFFER_SIZE_IN_SEC;

        ContactQualityStates[] _cq = null;
        SquareWaveChannelParam[] _cqParams = null;

        enum RawChannels
        {
            UNDEFINED = 0,
            AF3, F7, F3, FC5, T7, 
            P7, O1, O2, P8, T8, 
            FC6, F4, F8, AF4, SQ_WAVE
        } ;

        bool RawChannelAndChannelEqual(RawChannels rawChannel, Channels channel)
        {          
            if (
                rawChannel == RawChannels.AF3 && channel == Channels.AF3 ||
                rawChannel == RawChannels.F7 && channel == Channels.F7 ||
                rawChannel == RawChannels.F3 && channel == Channels.F3 ||
                rawChannel == RawChannels.FC5 && channel == Channels.FC5 ||
                rawChannel == RawChannels.T7 && channel == Channels.T7 ||
                rawChannel == RawChannels.P7 && channel == Channels.P7 ||
                rawChannel == RawChannels.O1 && channel == Channels.O1 ||
                rawChannel == RawChannels.O2 && channel == Channels.O2 ||
                rawChannel == RawChannels.P8 && channel == Channels.P8 ||
                rawChannel == RawChannels.T8 && channel == Channels.T8 ||
                rawChannel == RawChannels.FC6 && channel == Channels.FC6 ||
                rawChannel == RawChannels.F4 && channel == Channels.F4 ||
                rawChannel == RawChannels.F8 && channel == Channels.F8 ||
                rawChannel == RawChannels.AF4 && channel == Channels.AF4
                )
            {
                return true;
            }
            return false;
        }

        int[] GetRawChannelToChannelMapping(RawChannels[] rawChannels, Channels[] channels)
        {
            int[] result = new int[rawChannels.Length];

            for (int rawChanIdx=0 ; rawChanIdx<rawChannels.Length ; ++rawChanIdx)
            {                
                result[rawChanIdx] = -1;
                for (int chanIdx=0 ; chanIdx<channels.Length ; ++chanIdx){
                    if (RawChannelAndChannelEqual(rawChannels[rawChanIdx], channels[chanIdx]))
                    {
                        result[rawChanIdx] = chanIdx;
                    }
                }
            }
            return result;
        }

        public EmotivDongle()
        {            
            _rawChannelToChannelMapping = GetRawChannelToChannelMapping(
                _rawChanMapping, (Channels[])Enum.GetValues(typeof(Channels))
                );

            // _cqMapping is equal to _rawChanMapping with the invalid entries removed.
            // In order words, there should be only EEG channels left.
            _cqMapping = new int[NUMBER_OF_EEG_CHAN];
            int curCqChan = 0;
            for (int i=0 ; i<_rawChannelToChannelMapping.Length ; ++i)
            {
                if (_rawChannelToChannelMapping[i] != -1)
                {
                    _cqMapping[curCqChan++] = _rawChannelToChannelMapping[i];
                }
            }           
            Debug.Assert(curCqChan == NUMBER_OF_EEG_CHAN);

            // Initialize parameters for CQ calculation.
            // Assume that the order of the parameters
            // is the same as Channels with CMS and DRL removed
            _cqParams = new SquareWaveChannelParam[]{
                new SquareWaveChannelParam(0, 226),
                new SquareWaveChannelParam(0, 235),
                new SquareWaveChannelParam(0, 212),
                new SquareWaveChannelParam(0, 216),
                new SquareWaveChannelParam(0, 231),
                new SquareWaveChannelParam(0, 239),
                new SquareWaveChannelParam(0, 245),
                new SquareWaveChannelParam(0, 179),
                new SquareWaveChannelParam(0, 167),
                new SquareWaveChannelParam(0, 162),
                new SquareWaveChannelParam(0, 194),
                new SquareWaveChannelParam(0, 179),
                new SquareWaveChannelParam(0, 206),
                new SquareWaveChannelParam(0, 204)
            };

            Debug.Assert(_cqParams.Length == NUMBER_OF_EEG_CHAN);
            
            _cq = new ContactQualityStates[NUMBER_OF_EEG_CHAN + 2]; // CMS and DRL
            for (int i=0 ; i<_cq.Length ; ++i){
                _cq[i] = ContactQualityStates.GOOD;
            }

            // Ini buffer
            int packageSize = Marshal.SizeOf(typeof(Package));  
            _packageBuf = Marshal.AllocHGlobal(packageSize);
        }

        ~EmotivDongle()
        {
            Marshal.FreeHGlobal(_packageBuf);
        }

        public static int CountDongles()
        {
            int count = 0;
            IntPtr h;
            do
            {
                h = EmotivDongleDriver.Open(count, 0);
                if (h != IntPtr.Zero)
                {
                    EmotivDongleDriver.Close(h);
                    count++;
                }
            }
            while (h !=IntPtr.Zero);
            
            return count;
        }
        public static void SetDongleID(int id)
        {
            _dongleID = id;
        }
        public static int GetDongleID()
        {
            return _dongleID;
        }
        public bool Open()
        {
            _handle = EmotivDongleDriver.Open(_dongleID, 0);

            if (_handle == IntPtr.Zero)
                return false;

            _sampleSizeInByte = (uint)EmotivDongleDriver.GetbufferSizeInByte(_handle, 1);

            int bufferSizeInByte = (int)(_bufferSizeInSample * _sampleSizeInByte);
            _internalBuf = Marshal.AllocHGlobal(bufferSizeInByte);
            _buf = new byte[bufferSizeInByte];

            return true;
        }

        public Data Read(Int32 timeoutInMs)
        {         
            int nData = 
                EmotivDongleDriver.Read(_handle, _internalBuf, SAMPLING_RATE * BUFFER_SIZE_IN_SEC, timeoutInMs);

            // Dongle is unplugged or there is an error occurred
            if (nData < 0)
            {
                return null;
            }

            Data data = new Data(nData);
            
            if (nData == 0)
            {
                return data;
            }                    

            Marshal.Copy(_internalBuf, _buf, 0, (int)(nData * _sampleSizeInByte));

            int packageSize = Marshal.SizeOf(typeof(Package));            

            for (int dataIdx=0 ; dataIdx<nData ; ++dataIdx)
            {
                Marshal.Copy(_buf, dataIdx*packageSize, _packageBuf, packageSize);

                Package pkg = (Package)Marshal.PtrToStructure(_packageBuf, typeof(Package));

                data._packageNumber[dataIdx] = pkg.packageNum;
                data._interpolated[dataIdx] = pkg.interpolated;
                data._gyroX[dataIdx] = pkg.gyroX;
                data._gyroY[dataIdx] = pkg.gyroY;
                data._batteryLevel[dataIdx] = pkg.batteryLevel;         

                for (int chanIdx = 0; chanIdx < _rawChannelToChannelMapping.Length; ++chanIdx)
                {
                    // Calc CQ
                    if (_rawChanMapping[chanIdx] == RawChannels.SQ_WAVE)
                    {
                        data._rawCq[dataIdx] = pkg.eegData[chanIdx];
                        calcCQ(pkg.eegData[chanIdx], pkg.packageNum);
                        continue;
                    }

                    // Skip non-EEG channels
                    if (_rawChannelToChannelMapping[chanIdx] == -1)
                    {
                        continue;
                    }                    

                    data._eegData[_rawChannelToChannelMapping[chanIdx]][dataIdx] = pkg.eegData[chanIdx] * EEG_MULTIPLIER;
                }

                for (int i=0 ; i<data._cq.Length ; ++i)
                {
                    data._cq[i][dataIdx] = _cq[i];
                }
            }            
            
            return data;
        }

        void calcCQ(int cqValue, int packageNum)
        {
            // Skip the 129th sample
            if (packageNum == 129)
            {
                return;
            }

            int chanNum = packageNum % 64;

            // packages 0-13 and 64-77 contain square wave input
            if (chanNum >= NUMBER_OF_EEG_CHAN){
                return;
            }

            int targetChanIdx = _cqMapping[chanNum];
            int offset = _cqParams[targetChanIdx].offset;
            int range = _cqParams[targetChanIdx].range;
            float cqRawResult = (cqValue - offset)/(float)range;
            
            if (cqRawResult < CQ_RED_THRESH)
            {
                _cq[targetChanIdx] = ContactQualityStates.NO_SIGNAL;
            }
            else if (cqRawResult < CQ_ORANGE_THRESH)
            {
                _cq[targetChanIdx] = ContactQualityStates.VERY_BAD;
            }
            else if (cqRawResult < CQ_YELLOW_THRESH)
            {
                _cq[targetChanIdx] = ContactQualityStates.POOR;
            }
            else if (cqRawResult < CQ_GREEN_THRESH)
            {
                _cq[targetChanIdx] = ContactQualityStates.FAIR;
            }
            else
            {
                _cq[targetChanIdx] = ContactQualityStates.GOOD;
            }

            // Calculation CMS and DRL
            if (targetChanIdx == NUMBER_OF_EEG_CHAN - 1)
            {
                // We determine whether the references are making contact by simply
                // scanning our updated contact quality array to see if any sq wave input
                // exceeded the lowest threshold
                bool refsTouching = false;
                for (int i = 0; i < NUMBER_OF_EEG_CHAN; ++i)
                {
                    if (_cq[i] >= ContactQualityStates.VERY_BAD)
                    {
                        refsTouching = true;
                        break;
                    }
                }

                if (refsTouching)
                {
                    _cq[(int)Channels.CMS] = ContactQualityStates.GOOD;
                    _cq[(int)Channels.DRL] = ContactQualityStates.GOOD;
                }
                else
                {
                    _cq[(int)Channels.CMS] = ContactQualityStates.VERY_BAD;
                    _cq[(int)Channels.DRL] = ContactQualityStates.VERY_BAD;
                }
            }

            
        }

        public Int32 SendCommand(Char cmd)
        {
            if (_handle == IntPtr.Zero)
            {
                return -1;
            }

            return EmotivDongleDriver.SendCommand(_handle, cmd);
        }

        public void Close()
        {
            if (_handle != IntPtr.Zero)
            {
                EmotivDongleDriver.Close(_handle);

                Marshal.FreeHGlobal(_internalBuf);
            }
        }

        public Int32 GetSamplesPerSec()
        {
            if (_handle == IntPtr.Zero)
            {
                return -1;
            }

            return EmotivDongleDriver.GetSamplesPerSec(_handle);
        }
        public Int32 GetPkgStats(out UInt32 pNumRcvdOut, out UInt32 pNumDroppedOut)
        {
            if (_handle == IntPtr.Zero)
            {
                pNumRcvdOut = 0;
                pNumDroppedOut = 0;
                return -1;
            }

            return EmotivDongleDriver.GetPkgStats(_handle, out pNumRcvdOut, out pNumDroppedOut);
        }   
    }
}
