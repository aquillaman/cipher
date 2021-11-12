using Cipher.Core.Interfaces;

namespace Cipher.Core.Vigenere
{
    internal class VigenereEncryptor : VigenereProcessor, IEncryptor
    {
        public VigenereEncryptor(string key) : base(key)
        {
        }

        public string Encrypt(string msg)
        {
            return Process(msg);
        }

        protected override int CalculateLetterIndex(int index, int alphabetLength, int offset)
        {
            return (index + offset) % alphabetLength;
        }
    }
}