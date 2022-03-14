using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.command.videoeditor
{
    /*
    public abstract class AbstractUndoableCommand : IUndoableCommand
    {
        protected VideoEditor videoEditor;
        protected History history;

        public AbstractUndoableCommand(VideoEditor videoEditor, History history)
        {
            this.videoEditor = videoEditor;
            this.history = history;
        }

        override
        public void execute()
        {
            // Another application of the template method pattern.
            // This method is defining a template for executing commands.
            doExecute();

            history.push(this);
        }


        protected abstract void doExecute();


    }*/
}
