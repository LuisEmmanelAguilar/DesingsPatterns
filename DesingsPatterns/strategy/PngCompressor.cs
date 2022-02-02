using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.strategy
{
    public class PngCompressor : Compressor
    {
        public void compress(string fileName)
        {
            Console.WriteLine("Applying Png");
        }
    }
}
