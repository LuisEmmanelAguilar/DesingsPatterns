using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.stateExcercise
{
    public class Bicyling : ITravelMode
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating Direction (Bicyling)");
            return 3;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating ETA (Bicyling)");
            return 3;
        }
    }
}
