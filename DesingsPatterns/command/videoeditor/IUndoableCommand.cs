using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.command.videoeditor
{
    public interface IUndoableCommand : ICommand
    {
        void undo();
    }
}
