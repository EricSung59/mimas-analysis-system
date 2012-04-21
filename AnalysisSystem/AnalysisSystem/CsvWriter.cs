using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AnalysisSystem
{
    class CsvWriter : IDisposable
    {
        private string _filename;
        private StreamWriter _writer;

        //--------------------------- CONSTRUCTOR -------------------------//

        public CsvWriter(string filename, Electrodes[] electrodes)
        {
            _filename = filename;
            _writer = new StreamWriter(_filename);

            for (int i = 0; i < electrodes.Count(); i++)
            {
                if (i != electrodes.Count() - 1)
                {
                    _writer.Write(electrodes[i].ToString() + ",");
                }
                else
                {
                    _writer.WriteLine(electrodes[i].ToString());
                }
            }
        }

        //--------------------------- PUBLIC METHODS ----------------------//

        public void WriteLine(string line) 
        {
            _writer.WriteLine(line);
        }

        public void Dispose()
        {
            _writer.Close();
        }
    }
}
