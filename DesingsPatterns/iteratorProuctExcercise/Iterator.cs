using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.iteratorProuctExcercise
{
    public interface Iterator
    {
        Boolean hasNext();

        Product current();

        void next();
    }
}
