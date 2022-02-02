using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.strategyExcercise
{
    public interface EncryptionAlgorithm
    {
        string encrypt(string var);
    }
}
