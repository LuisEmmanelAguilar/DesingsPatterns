using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.mementoExcercise
{
    public class DocumentMemento
    {
        private String content;
        private String fontName;
        private int fontSize;

        public DocumentState createDocument()
        {
            return new DocumentState(content, fontName, fontSize);
        }

        public void restore(DocumentState document)
        {
            this.content = document.getContent();
            this.fontName = document.getFontName();
            this.fontSize = document.getFontSize();
        }

        public String getContent()
        {
            return content;
        }

        public void setContent(String content)
        {
            this.content = content;
        }

        public String getFontName()
        {
            return fontName;
        }

        public void setFontName(String fontName)
        {
            this.fontName = fontName;
        }

        public int getFontSize()
        {
            return fontSize;
        }

        public void setFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }

        public String toString()
        {
            return "Document {" +
                    "content='" + content + '\'' +
                    ", fontName='" + fontName + '\'' +
                    ", fontSize=" + fontSize +
                    '}';

        }


    }
}
