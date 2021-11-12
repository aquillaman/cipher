using Cipher.Core.Interfaces;

namespace Cipher.Core.Caesar
{
    internal class CaesarDecryptor : CaesarProcessor, IDecryptor
    {
        public CaesarDecryptor(int offset) : base(offset)
        {
        }

        public string Decrypt(string msg)
        {
            return Process(msg, false);
        }
    }
}