using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.strategy
{
    public interface Filter
    {
        void aplly(string fileName);
    }
}
