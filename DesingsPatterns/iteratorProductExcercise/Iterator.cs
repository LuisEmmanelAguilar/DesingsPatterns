using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.iteratorProductExcercise
{
    public interface Iterator
    {
        Boolean hasNext();
        Product current();
        void nex();

    }
}
