using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.command.videoeditor
{
    /*
    internal class SetContrastCommand : AbstractUndoableCommand
    {
        private float prevContrast;
        private float contrast;

        public SetContrastCommand (float contrats) : base (VideoEditor videoEditor, History history)
        {
            prevContrast = videoEditor.getContrast();
            this.contrast = contrast;
        }

        override
        protected void doExecute()
        {
            videoEditor.setContrast(contrast);
        }

        override
        public void undo()
        {
            videoEditor.setContrast(prevContrast);
        }
    }*/
}
