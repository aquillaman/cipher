using System.Text;

namespace Cipher.Core.Caesar
{
    internal class CaesarProcessor
    {
        private readonly int _offset;

        protected CaesarProcessor(int offset)
        {
            _offset = offset;
        }

        protected string Process(string msg, bool encode)
        {
            var msgLength = msg.Length;
            var alphabet = Alphabet.RU.Full;
            int alphabetLength = alphabet.Length;
            var builder = new StringBuilder(msgLength);

            for (int i = 0; i < msgLength; i++)
            {
                var character = msg[i];
                var index = alphabet.IndexOf(character);

                if (index < 0)
                {
                    builder.Append(character);
                    continue;
                }

                var offset = _offset * (encode ? 1 : -1);
                index = (index + offset) % alphabetLength;
                if (index < 0)
                {
                    index = (index + alphabetLength) % alphabetLength;
                }

                builder.Append(alphabet[index]);
            }

            return builder.ToString();
        }
    }
}