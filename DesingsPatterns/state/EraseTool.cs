using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.state
{
    internal class EraseTool : ITool
    {
        public void mouseDown()
        {
            Console.WriteLine("Erase Icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Erase something");
        }
    }
}
