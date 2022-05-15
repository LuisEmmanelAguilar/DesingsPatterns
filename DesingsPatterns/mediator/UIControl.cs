using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.mediator
{
    public abstract class UIControl
    {
        private List<EventHandler> observers = new List<EventHandler>();

        public void addEventHandler(EventHandler observer)
        {
            observers.Add(observer);
        }

        protected void notifyObservers()
        {
            foreach(var observer in observers)
                observer.handle();
        }
    }
}
