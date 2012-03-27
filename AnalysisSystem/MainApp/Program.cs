using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

namespace MainApp
{
    class Program
    {
        MLTestClass obj;
        MWNumericArray input = null;
        MWNumericArray output = null;
        MWArray[] result = null;

        static void Main(string[] args)
        {
            new Program().Run();
        }

        public void Run()
        {
            try
            {
                obj = new MLTestClass();
                input = new MWNumericArray(5);

                result = obj.makeSqr(1, input);
                output = (MWNumericArray)result[0];

                Console.WriteLine(output);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
