using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.iteratorExcercise
{
    public interface Iterator
    {
        Boolean hasNext();
        
        // T means for generic
        String current();
        
        void next();

    }
}
