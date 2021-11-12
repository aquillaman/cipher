using Cipher.Core.Interfaces;

namespace Cipher.Core.Vigenere
{
    internal class VigenereCipher : ICipher
    {
        public string Name => "Шифр Виженера";
        private readonly VigenereEncryptor _encryptor;
        private readonly VigenereDecryptor _decryptor;

        public VigenereCipher(string key)
        {
            _encryptor = new VigenereEncryptor(key);
            _decryptor = new VigenereDecryptor(key);
        }

        public string Encrypt(string msg)
        {
            return _encryptor.Encrypt(msg);
        }

        public string Decrypt(string msg)
        {
            return _decryptor.Decrypt(msg);
        }
    }
}