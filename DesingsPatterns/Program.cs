using DesingsPatterns.iterator;
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

            for(var i = 0; i < history.getUrls().Count; i++)
            {
                var url = history.getUrls()[i];
                Console.WriteLine(url);
            }

            Console.ReadLine();

        }
    }
}
