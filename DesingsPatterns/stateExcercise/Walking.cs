using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.stateExcercise
{
    public class Walking : ITravelMode
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating Direction (Walking)");
            return 2;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating ETA (Walking)");
            return 2;
        }
    }
}
