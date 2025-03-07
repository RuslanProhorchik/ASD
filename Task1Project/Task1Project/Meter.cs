using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Project
{
    public class Meter : IDisposable
    {
        private Stopwatch _sw;

        public static Meter Job() { 
            return new Meter();
        }

        Meter() {
            _sw = Stopwatch.StartNew();
        }

        public void Dispose()
        {
            _sw.Stop();
            Console.Write($" Execution time: {_sw.Elapsed}");
        }
    }
}
