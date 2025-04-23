using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Log
    {
        private static Dictionary<DateTime, string> _log = new Dictionary<DateTime, string>();

        public virtual void Write(string message)
        {
            _log.Add(DateTime.Now, message);
        }

        public void DisplayLog()
        {
            Console.WriteLine("--- DisplayLog ---");
            foreach (var log in _log)
            {
                Console.WriteLine($"{log.Key} - {log.Value}");
            }
        }
    }
}
