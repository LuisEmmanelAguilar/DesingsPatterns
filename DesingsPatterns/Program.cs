
using DesingsPatterns.command;
using DesingsPatterns.templateExcercise;
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
            // Command Pattern
            var composite = new CompositeCommand();
            composite.add(new ResizaCommand());
            composite.add(new BlackAndWhiteCommand());
            composite.execute();

            Console.ReadLine();

        }
    }
}
