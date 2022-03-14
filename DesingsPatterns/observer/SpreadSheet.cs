using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.observer
{
    internal class SpreadSheet : IObserver
    {
        public void update()
        {
            Console.WriteLine("SpreadSheet got notified.");
        }
    }
}
