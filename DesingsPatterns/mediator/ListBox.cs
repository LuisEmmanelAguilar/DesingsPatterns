using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.mediator
{
    class ListBox : UIControl
    {
        private string _selection;

        public string getSelection()
        {
            return _selection;
        }

        public void setSelection(string selection)
        {
            _selection = selection;
            notifyObservers();
        }
    }
}
