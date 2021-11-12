using System;
using System.Text;

namespace Cipher.Core.Vigenere
{
    internal class VigenereProcessor
    {
        protected readonly int[] Offsets;

        protected VigenereProcessor(string key)
        {
            var keyLength = key.Length;
            Offsets = new int[keyLength];
            for (int i = 0; i < keyLength; i++)
            {
                Offsets[i] = Alphabet.RU.Full.IndexOf(key[i]);
            }
        }

        protected string Process(string msg)
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

                var offset = Offsets[i % Offsets.Length];

                index = CalculateLetterIndex(index, alphabetLength, offset);
                if (index < 0)
                {
                    index = (alphabetLength + index) % alphabetLength;
                }

                builder.Append(alphabet[index]);
            }

            return builder.ToString();
        }

        protected virtual int CalculateLetterIndex(int index, int alphabetLength, int offset)
        {
            throw new NotImplementedException();
        }
    }
}