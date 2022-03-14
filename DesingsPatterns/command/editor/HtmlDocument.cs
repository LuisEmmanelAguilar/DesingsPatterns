using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.command.editor
{
    public class HtmlDocument
    {
        private string content;

        public void makeBold()
        {
            content = "<b>" + content + "</b>";
        }

        public void setContent(string content)
        {
            this.content = content;
        }

        public string getContent()
        {
            return content;
        }


    }
}
