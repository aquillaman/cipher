using Cipher.Core.Interfaces;

namespace Cipher.Core.Atbash
{
    internal class AtbashEncryptor : AtbashProcessor, IEncryptor
    {
        public string Encrypt(string msg)
        {
            return Process(msg);
        }
    }
}