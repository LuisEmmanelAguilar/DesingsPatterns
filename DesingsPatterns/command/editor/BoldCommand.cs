using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.command.editor
{
    internal class BoldCommand : IUndoableCommand
    {
        private string prevContent;
        private HtmlDocument document;
        private History history;

        public BoldCommand(HtmlDocument document, History history)
        {
            this.document = document;
            this.history = history;
        }

        public void execute()
        {
            prevContent = document.getContent();
            document.makeBold();
            history.push(command: this);
        }

        public void unexecute()
        {
            document.setContent(prevContent);
        }
    }
}
