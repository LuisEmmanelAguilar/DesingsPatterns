using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.strategy
{
    public class BlackAndWhiteFilter : Filter
    {
        public void aplly(string fileName)
        {
            Console.WriteLine("Applying B & W Color");
        }
    }
}
