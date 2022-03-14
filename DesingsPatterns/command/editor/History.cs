using Nito.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.command.editor
{
    internal class History
    {
        private Deque<IUndoableCommand> commands = new Deque<IUndoableCommand>();

        public void push(IUndoableCommand command)
        {
            commands.AddToFront(command);
        }

        public IUndoableCommand pop()
        {
            return commands.RemoveFromFront();
        }
    }
}
