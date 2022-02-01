using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.iterator
{
    public class BrowseHistory
    {
        // fields
        private List<String> urls = new List<string>();

        // methods

        // addd url
        public void push(String url)
        {
            urls.Add(url);
        }

        // remove url
        public String pop()
        {
            var lastIndex = urls.Last();
            urls.Remove(lastIndex);

            return lastIndex;
        }

        // getters or setters
        public List<String> getUrls()
        {
            return urls;
        }
    }
}
