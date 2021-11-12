using Cipher.Core.Interfaces;

namespace Cipher.Core.Atbash
{
    internal class AtbashDecryptor : AtbashProcessor, IDecryptor
    {
        public string Decrypt(string msg)
        {
            return Process(msg);
        }
    }
}