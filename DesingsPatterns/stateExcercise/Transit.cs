using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.stateExcercise
{
    public class Transit : ITravelMode
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating Direction (Transit)");
            return 4;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating ETA (Transit");
            return 4;
        }
    }
}
