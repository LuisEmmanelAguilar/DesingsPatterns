
using DesingsPatterns.strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Strategy Pattern
            var imageStorage1 = new ImageStorage();
            imageStorage1.store("a", new JpegCompressor(), new BlackAndWhiteFilter());
            imageStorage1.store("a", new PngCompressor(), new BlackAndWhiteFilter());


            Console.ReadLine();

        }
    }
}
