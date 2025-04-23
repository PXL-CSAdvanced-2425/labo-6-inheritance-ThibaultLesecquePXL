using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Log
    {
        private string _fileName;

        public Log(string fileName)
        {
            _fileName = fileName;
        }

        public virtual void Write(string message)
        {
            using (StreamWriter sr = new StreamWriter(_fileName, true))
            {
                sr.WriteLine($"{DateTime.Now} - {message}");
            }
        }

        public void DisplayLog()
        {
            Console.WriteLine($"--- File {_fileName} logs ---");
            using (StreamReader sr = new StreamReader(_fileName))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
    }
}
