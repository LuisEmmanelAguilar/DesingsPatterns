using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.command
{
    public class BlackAndWhiteCommand : ICommand
    {
        public void execute()
        {
            Console.WriteLine("Black and White");
        }
    }
}
