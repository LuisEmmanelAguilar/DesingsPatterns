
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
            // Template Method Pattern
            ChatWindow window = new ChatWindow();
            window.close();

            Console.ReadLine();

        }
    }
}
