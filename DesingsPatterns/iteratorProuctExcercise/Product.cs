using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.iteratorProuctExcercise
{
    public class Product
    {
        private int id;
        private string name;

        public Product(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public String toString()
        {
            return "Product {id=" + this.id + ", name='" + this.name + "'}";
        }
    }
}
