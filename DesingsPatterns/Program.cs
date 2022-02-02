
using DesingsPatterns.template;
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
            // Template Method Pattern
            var task = new TransferMoneyTask();
            task.execute();

            Console.ReadLine();

        }
    }
}
