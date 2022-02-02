using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.strategyExcercise
{
    public class AES : EncryptionAlgorithm
    {
        public string encrypt(string var)
        {
            Console.WriteLine("Encrypting message using AES");
            return "EncryptedText";
        }
    }
}
