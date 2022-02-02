using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.strategyExcercise
{
    public class DES : EncryptionAlgorithm
    {
        public string encrypt(string var)
        {
            Console.WriteLine("Encrypting message using DES");
            return "EncryptedText";
        }
    }
}
