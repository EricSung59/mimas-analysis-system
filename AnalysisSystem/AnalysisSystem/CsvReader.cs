using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AnalysisSystem
{
    class CsvReader
    {
        private String _filepath;

        //---------------------- CONSTRUCTOR -----------------------//

        public CsvReader(string filepath)
        {
            _filepath = filepath;
        }

        //---------------------- PUBLIC METHODS --------------------//

        public double[] GetColumn(Electrodes electrode)
        {
            List<Double> resultList = new List<Double>();
            bool isHeader = true;

            using (StreamReader reader = new StreamReader(_filepath))
            {
                if (isHeader)
                {
                    reader.ReadLine();
                    isHeader = false;
                }

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    resultList.Add(Convert.ToDouble(line.Split(',')[(int)electrode]));
                }
            }

            return resultList.ToArray();
        }
    }

    enum Electrodes
    {
        COUNTER = 0, INTERPOLATED, AF3, F7, F3, FC5, T7, P7, O1, O2, P8, T8, FC6, F4, F8, AF4
    }
}
