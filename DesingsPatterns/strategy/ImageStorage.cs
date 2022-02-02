using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.strategy
{
    public class ImageStorage
    {
        private Compressor compressor;
        private Filter filter;

        public ImageStorage(Compressor compressor, Filter filter)
        {
            this.compressor = compressor;
            this.filter = filter;
        }

        public void store(string fileName)
        {
            compressor.compress(fileName);
            filter.aplly(fileName);
        }
    }
}
