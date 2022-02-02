using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.iteratorProductExcercise
{
    internal class ProductCollection
    {
        private List<Product> products = new List<Product>();

        public ProductCollection()
        {

        }

        public void add(Product product)
        {
            this.products.Add(product);
        }

        public Iterator createIterator()
        {
            return new ProductCollection.ListIterator(collection: this);
        }


        // nested class

        private class ListIterator : Iterator
        {
            private ProductCollection collection;
            private int index;

            public ListIterator(ProductCollection collection)
            {
                this.collection = collection;
            }

            public Product current()
            {
                return (Product)this.collection.products.ElementAt(index);
            }

            public bool hasNext()
            {
                return this.index < this.collection.products.Count();
            }

            public void next()
            {
                index++;
            }
        }

    }
}
