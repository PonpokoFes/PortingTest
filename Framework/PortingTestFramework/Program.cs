using System;
using System.IO;
using System.Configuration;

namespace PortingTestFramework
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = ConfigurationManager.AppSettings["FilePath"];

            // make file 
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            // stream reader
            var sr = new StreamReader(path);

            // read file 
            Console.WriteLine(sr.ReadToEnd());

            // close stream
            sr.Dispose();

            // stream writer
            var sw = new StreamWriter(path);
            // append new line
            sw.WriteLine(DateTime.Now.ToString());
            // close stream
            sw.Dispose();

            // last check
            var lastStream = new StreamReader(path);
            Console.WriteLine(lastStream.ReadToEnd());
            // close stream
            lastStream.Dispose();

            Environment.Exit(0);
        }
    }
}
