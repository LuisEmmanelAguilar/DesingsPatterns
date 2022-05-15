using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.mediator
{
    public class Button : UIControl
    {
        private bool isEnabled;

        public bool getEnabled()
        {
            return isEnabled;
        }


        public void setEnabled(bool enabled)
        {
            isEnabled = enabled;
            notifyObservers();
        }
    }
}
