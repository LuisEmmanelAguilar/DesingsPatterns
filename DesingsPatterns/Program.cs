using DesingsPatterns.state;
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
            var canvas = new Canvas();
            //canvas.setCurrentTool(new SelectionTool());
            //canvas.setCurrentTool(new BrushTool());
            canvas.setCurrentTool(new EraseTool());
            canvas.mouseDown();
            canvas.mouseUp();



        }
    }
}
