using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.observer
{
    // Also we can call it Observable
    public class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public void addObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void notifyObservers(int value)
        {
            foreach (var observer in _observers)
                observer.update(value);
        }
    }
}
