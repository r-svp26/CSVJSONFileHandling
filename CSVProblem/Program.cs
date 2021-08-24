using System;

namespace CSVProblem
{
    class Program
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CSVHelper.ImplementCSVDataHandling();
            CSVHelper.ImplementCSVToJSONHandling();
        }
    }
}
