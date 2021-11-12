using Cipher.Core.Interfaces;

namespace Cipher.Core.Caesar
{
    internal class CaesarEncryptor : CaesarProcessor, IEncryptor
    {
        public CaesarEncryptor(int offset):base(offset)
        {
        }

        public string Encrypt(string msg)
        {
            return Process(msg,true);
        }
    }
}