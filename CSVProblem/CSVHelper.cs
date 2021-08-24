using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace CSVProblem
{
    /// <summary>
    /// Handler class
    /// </summary>
    class CSVHelper
    {
        /// <summary>
        /// read & write operation using csv file
        /// </summary>
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = "/BridgeLabz/CSVProblem/demo.csv";
            string exportFilePath = "/BridgeLabz/CSVProblem/example.csv";
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<PersonDetail>();
                Console.WriteLine("Read data successfully from demo.csv, here are city");
                foreach (PersonDetail data in records)
                {
                    Console.Write("\t"+data.Name);
                }
                Console.WriteLine("\n************ reading from csv file and write to csv file");
                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
        /// <summary>
        /// read & write operation using json file
        /// </summary>
        public static void ImplementCSVToJSONHandling()
        {
            string importFilePath = "/BridgeLabz/CSVProblem/demo.csv";
            string exportFilePath = "/BridgeLabz/CSVProblem/data.json";
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<PersonDetail>();
                Console.WriteLine("Read data successfully from demo.csv, here are city");
                foreach (PersonDetail data in records)
                {
                    Console.Write("\t" + data.Name);
                }
                Console.WriteLine("\n************ reading from csv file and write to json file");
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }
}
