using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.templateExcercise
{
    public class Window
    {
        public Window()
        {

        }

        public void close()
        {
            this.onClosing();
            Console.WriteLine("Removing the window from the screen");
            this.onClosed();
            
        }

        protected void onClosing()
        {

        }

        protected void onClosed()
        {

        }


    }
}
