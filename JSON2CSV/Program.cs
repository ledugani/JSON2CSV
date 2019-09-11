using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace JSON2CSV
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // convert json to Dictionary<>

            string json = File.ReadAllText(@"/Users/thomasdugan/Projects/JSON2CSV/dummydata.json");

            var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            StringBuilder csvcontent = new StringBuilder();

            foreach (var kv in values)
            {
                csvcontent.AppendLine(kv.Key + "," + kv.Value);
            }

            Console.ReadLine();

            string csvPath = "xyz.csv";
            File.AppendAllText(csvPath, csvcontent.ToString());
        }
    }
}
