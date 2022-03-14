using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.observerExcercise
{
    internal class StockListView : IObserver
    {
        private List<Stock> _stocks = new List<Stock>();

        public void addStock(Stock stock)
        {
            _stocks.Add(stock);
            stock.addObserver(this);
        }

        public void show()
        {
            Console.WriteLine("Stocke List View");
            foreach(var stock in _stocks)
                Console.WriteLine(stock);
        }
        public void priceChange()
        {
            Console.WriteLine("Price Changed -  Refreshing StockListView");
            show();
        }
    }
}
