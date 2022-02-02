using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.strategyExcercise
{
    public class ChatClient
    {
        private EncryptionAlgorithm encryptionAlgorithm;

        public ChatClient(EncryptionAlgorithm encryptor)
        {
            this.encryptionAlgorithm = encryptor;
        }

        public void send(String message)
        {
            this.encryptionAlgorithm.encrypt(message);
            Console.WriteLine("Sending the encrypted message...");
        }

    }
}
