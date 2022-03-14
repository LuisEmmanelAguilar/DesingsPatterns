using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.command
{
    internal class CompositeCommand : ICommand
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void add(ICommand command)
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
