using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.observerExcercise
{
    public class Stock
    {
        private String _symbol;
        private float _price;
        private List<IObserver> _observers = new List<IObserver>();
        public Stock(string symbol, float price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        public void addObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach (var observer in _observers)
                observer.priceChange();
        }

        public float getPrice()
        {
            return _price;
        }

        public void setPrice(float price)
        {
            this._price = price;
            notifyObservers();
        }

        override
        public String ToString()
        {
            return "Stock{" +
                   "symbol='" + _symbol + '\'' +
                   ", price=" + _price +
                   '}';
        }

    }
}
