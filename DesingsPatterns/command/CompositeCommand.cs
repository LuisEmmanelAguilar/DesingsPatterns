using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.command
{
    internal class CompositeCommand : Command
    {
        private List<Command> _commands = new List<Command>();

        public void add(Command command)
        {
            _commands.Add(command);
        }
        public void execute()
        {
            foreach (var command in _commands)
                command.execute();
        }
    }
}
