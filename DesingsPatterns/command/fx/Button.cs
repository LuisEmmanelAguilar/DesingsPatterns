using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.command
{
    public class Button
    {
        private string label;
        private Command command;

        public Button(Command command)
        {
            this.command = command;
        }

        public void click()
        {
            command.execute();
        }

        public string getLabel()
        {
            return label;
        }

    }
}
