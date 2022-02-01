using DesingsPatterns.iteratorExcercise;
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
            // Iterator Pattern
            var history = new BrowseHistory();
            history.push("site a");
            history.push("site b");
            history.push("site c");

            // So... the main class was not afected
            // Neither the Iterator class
            Iterator iterator = history.createIterator();
            while(iterator.hasNext())
            {
                var url = iterator.current();
                Console.WriteLine(url);
                iterator.next();
            }

            Console.ReadLine();

        }
    }
}
