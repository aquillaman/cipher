using System.Text;

namespace Cipher.Core.Atbash
{
    internal abstract class AtbashProcessor
    {
        protected string Process(string msg)
        {
            var len = msg.Length;
            var alphabet = Alphabet.RU.Full;
            int alphabetLength = alphabet.Length - 1;

            var builder = new StringBuilder(msg.Length);
            for (int i = 0; i < len; i++)
            {
                var character = msg[i];
                var index = alphabet.IndexOf(character);
                builder.Append(index == -1 ? character : alphabet[alphabetLength - index]);
            }

            return builder.ToString();
        }
    }
}