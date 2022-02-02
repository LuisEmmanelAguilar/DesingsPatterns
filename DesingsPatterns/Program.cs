
using DesingsPatterns.strategy;
using DesingsPatterns.strategyExcercise;
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
            //var imageStorage1 = new ImageStorage();
            //imageStorage1.store("a", new JpegCompressor(), new BlackAndWhiteFilter());
            //imageStorage1.store("a", new PngCompressor(), new BlackAndWhiteFilter());

            // Strategy Pattern Excercise
            ChatClient client = new ChatClient(new DES());
            client.send("Hello world");



            Console.ReadLine();

        }
    }
}
