using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.state
{
    public class BrushTool : ITool
    {
        public void mouseDown()
        {
            Console.WriteLine("Brush Icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Draw a Line");
        }
    }
}
