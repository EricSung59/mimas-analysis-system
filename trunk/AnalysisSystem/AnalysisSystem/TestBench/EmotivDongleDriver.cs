using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Emotiv
{
    public class EmotivDongleDriver
    {
        [DllImport("EmotivDongleDriver.dll", EntryPoint = "ed_open")]
        static extern IntPtr Unmanged_ed_open(Int32 id, Int32 bLogEnabled);       

        [DllImport("EmotivDongleDriver.dll", EntryPoint = "ed_getbufferSizeInByte")]
	    static extern Int32 Unmanged_ed_getbufferSizeInByte(IntPtr handle, UInt32 nSample);
        
        [DllImport("EmotivDongleDriver.dll", EntryPoint = "ed_read")]
	    static extern Int32 Unmanged_ed_read(IntPtr handle, IntPtr buf, UInt32 bufSizeInSample, Int32 timeoutInMs);

        [DllImport("EmotivDongleDriver.dll", EntryPoint = "ed_send_command")]
	    static extern Int32 Unmanged_ed_send_command(IntPtr handle, Char cmd);

        [DllImport("EmotivDongleDriver.dll", EntryPoint = "ed_close")]
	    static extern void Unmanged_ed_close(IntPtr handle);

        [DllImport("EmotivDongleDriver.dll", EntryPoint = "ed_getSamplesPerSec")]
	    static extern Int32 Unmanged_ed_getSamplesPerSec(IntPtr handle);

        [DllImport("EmotivDongleDriver.dll", EntryPoint = "ed_getPkgStats")]
	    static extern Int32 Unmanged_ed_getPkgStats(IntPtr handle, out UInt32 pNumRcvdOut, out UInt32 pNumDroppedOut);


        public static IntPtr Open(Int32 id, Int32 bLogEnabled)
        {
            return Unmanged_ed_open(id, bLogEnabled);
        }
        public static Int32 GetbufferSizeInByte(IntPtr handle, UInt32 nSample)
        {
            return Unmanged_ed_getbufferSizeInByte(handle, nSample);
        }
        public static Int32 Read(IntPtr handle, IntPtr buf, UInt32 bufSizeInSample, Int32 timeoutInMs)
        {
            return Unmanged_ed_read(handle, buf, bufSizeInSample, timeoutInMs);
        }
        public static Int32 SendCommand(IntPtr handle, Char cmd)
        {
            return Unmanged_ed_send_command(handle, cmd);
        }
        public static void Close(IntPtr handle)
        {
            Unmanged_ed_close(handle);
        }
        public static Int32 GetSamplesPerSec(IntPtr handle)
        {
            return Unmanged_ed_getSamplesPerSec(handle);
        }
        public static Int32 GetPkgStats(IntPtr handle, out UInt32 pNumRcvdOut, out UInt32 pNumDroppedOut)
        {
            return Unmanged_ed_getPkgStats(handle, out pNumRcvdOut, out pNumDroppedOut);
        }


    }
}
