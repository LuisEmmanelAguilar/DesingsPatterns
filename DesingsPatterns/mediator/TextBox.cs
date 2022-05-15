using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.mediator
{
    public class TextBox : UIControl
    {
        private string content;

        public string getContent()
        {
            return content;
        }

        public void setContent(string content)
        {
            this.content = content;
            notifyObservers();      
        }

    }
}
