using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.iteratorExcercise
{
    internal class BrowseHistory
    {
        private List<String> urls = new List<string>();
        public void push(String url)
        {
            urls.Add(url);
        }

        public String pop()
        {
            var lastIndex = urls.Last();
            urls.Remove(lastIndex);

            return lastIndex;
        }

        public Iterator createIterator()
        {
            return new ListIterator(history: this);
        }


        // NESTED CLASS
        public class ListIterator : Iterator
        {
            private readonly BrowseHistory history;
            private int index;

            public ListIterator(BrowseHistory history)
            {
                this.history = history;
            }


            public string current()
            {
                return history.urls.ElementAt(index);
            }

            public bool hasNext()
            {
                return (index < history.urls.Count());
            }

            public void next()
            {
                index++;
            }
        }

    }
}
