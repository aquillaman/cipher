using Cipher.Core.Interfaces;

namespace Cipher.Core.Caesar
{
    internal class CaesarCipher : ICipher
    {
        public string Name => "Шифр Цезаря";
        private readonly CaesarEncryptor _encryptor;
        private readonly CaesarDecryptor _decryptor;

        public CaesarCipher(int offset)
        {
            _encryptor = new CaesarEncryptor(offset);
            _decryptor = new CaesarDecryptor(offset);
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