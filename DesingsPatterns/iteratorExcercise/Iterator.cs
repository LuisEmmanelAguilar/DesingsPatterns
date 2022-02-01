using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.iteratorExcercise
{
    // Not afected after change the BrowseHistory class from List<> to String[]
    public interface Iterator
    {
        Boolean hasNext();
        
        // T means for generic
        String current();
        
        void next();

    }
}
