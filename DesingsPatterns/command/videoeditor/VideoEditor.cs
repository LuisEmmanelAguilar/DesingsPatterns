using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.command.videoeditor
{
    public class VideoEditor
    {
        private float contrast = 0.5f;
        private String text;

        public void setText(String text)
        {
            this.text = text;
        }

        public void removeText()
        {
            this.text = "";
        }

        public float getContrast()
        {
            return contrast;
        }

        public void setContrast(float contrast)
        {
            this.contrast = contrast;
        }

        override
        public string ToString()
        {
            return "VideoEditor { " +
                   "contrast= " + contrast +
                   ", text= '" + text + "'}";
        }
    }
}
