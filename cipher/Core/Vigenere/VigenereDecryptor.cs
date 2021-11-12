using Cipher.Core.Interfaces;

namespace Cipher.Core.Vigenere
{
    internal class VigenereDecryptor : VigenereProcessor, IDecryptor
    {
        public VigenereDecryptor(string key) : base(key)
        {
        }

        public string Decrypt(string msg)
        {
            return Process(msg);
        }

        protected override int CalculateLetterIndex(int index, int alphabetLength, int offset)
        {
            return (index + alphabetLength - offset) % alphabetLength;
        }
    }
}