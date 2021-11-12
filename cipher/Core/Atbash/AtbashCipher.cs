using Cipher.Core.Interfaces;

namespace Cipher.Core.Atbash
{
    internal class AtbashCipher: ICipher
    {
        public string Name => "Шифр Атбаш";
        private readonly AtbashEncryptor _encryptor;
        private readonly AtbashDecryptor _decryptor;

        public AtbashCipher()
        {
            _encryptor = new AtbashEncryptor();
            _decryptor = new AtbashDecryptor();
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