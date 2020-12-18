using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net;
using Lab06Lib;
using System.Collections.Generic;

namespace Lab06App
{
    class Program
    {
        static void Main(string[] args)
        {
            string ask = "";
            List<PolliceDepartmentID> department = new List<PolliceDepartmentID>();
            using (WebClient client = new WebClient())
            {
                client.DownloadFile("https://data.police.uk/api/forces", "PoliceDepartment.json");
            }
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<PolliceDepartmentID>));
            using (FileStream fs = new FileStream(@"PoliceDepartment.json", FileMode.Open))
            {
                department = (List<PolliceDepartmentID>)formatter.ReadObject(fs);
            }
            Func functional = new Func();
            //main
            for (; ; )
            {
                functional.PrintMenu();
                ask = Console.ReadLine();
                functional.HandleInput(ask,department, formatter);

            }
        }
    }
}
