using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.stateExcercise
{
    public class Driving : ITravelMode
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating Direction (driving)");
            return 1;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating ETA (driving)");
            return 1;
        }
    }
}
