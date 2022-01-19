using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.state
{
    public class SelectionTool : ITool
    {
        public void mouseDown()
        {
            Console.WriteLine("Selection Icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Draw dashed rectangle");
        }
    }
}
