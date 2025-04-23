using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ErrorLog : Log
    {
        public override void Write(string message)
        {
            base.Write($"ERROR {message}");
        }
    }
}
