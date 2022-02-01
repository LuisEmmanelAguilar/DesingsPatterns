using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.iteratorExcercise
{
    internal class BrowseHistory
    {
        private String[] urls = new string[10];
        private int count;

        public void push(String url)
        {
            urls[count++] = url;
        }

        public String pop()
        {
            return urls[--count];
        }

        public Iterator createIterator()
        {
            return new ArrayIterator(history: this);
        }


        // NESTED CLASS
        public class ArrayIterator : Iterator
        {
            private readonly BrowseHistory history;
            private int index;

            public ArrayIterator(BrowseHistory history)
            {
                this.history = history;
            }


            public bool hasNext()
            {
                return (index < history.urls.Count());
            }

            public string current()
            {
                return history.urls.ElementAt(index);
            }

            public void next()
            {
                index++;
            }
        }

    }
}
