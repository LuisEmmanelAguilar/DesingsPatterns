using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.observerExcercise
{
    internal class StatusBar : IObserver
    {
        private List<Stock> stocks = new List<Stock>();

        public void addStock(Stock stock)
        {
            stocks.Add(stock);
            stock.addObserver(this);
        }

        public void show()
        {
            Console.WriteLine("Status Bar");
            foreach(var stock in stocks)
                Console.WriteLine(stock);
        }

        public void priceChange()
        {
            Console.WriteLine("Price Changed -  Refreshing Status Bar");
            show();
        }
    }
}
