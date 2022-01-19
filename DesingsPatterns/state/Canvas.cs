using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.state
{
    public class Canvas
    {
        // Get of rid of this lline and the ToolType is no longer needed
        //private ToolType currentTool;
        private ITool currentTool;


        public void mouseDown()
        {
            currentTool.mouseDown();
            //if (currentTool == ToolType.SELECTION)
            //    Console.WriteLine("Selection Icon");
            //else if (currentTool == ToolType.BRUSH)
            //    Console.WriteLine("Brush Icon");
            //else if (currentTool == ToolType.ERASE)
            //    Console.WriteLine("Erase Icon");
        }

        public void mouseUp()
        {
            currentTool.mouseUp();
            //if (currentTool == ToolType.SELECTION)
            //    Console.WriteLine("Draw dashed rectangle");
            //else if (currentTool == ToolType.BRUSH)
            //    Console.WriteLine("Draw a line");
            //else if (currentTool == ToolType.ERASE)
            //    Console.WriteLine("Erase Something");
        }


        public ITool getCurrentTool()
        {
            return currentTool;
        }


        public void setCurrentTool(ITool currentTool)
        {
            this.currentTool = currentTool;
        }


    }
}
