using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.templateExcercise
{
    public class ChatWindow : Window
    {
        public ChatWindow()
        {

        }

        protected void onClosed()
        {
            Console.WriteLine("Dsiconnecting from the server...");
        }
    }
}
