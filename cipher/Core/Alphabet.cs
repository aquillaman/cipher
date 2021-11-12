namespace Cipher.Core
{
    internal static class Alphabet
    {
        public static readonly Ru RU = new Ru();

        internal class Ru
        {
            public string Full { get; } = UPPER + lower + symbols + numbers;
            private const string UPPER = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            private const string lower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            private const string symbols = " !@#$%^&()_*-+=[]{}<>?,.";
            private const string numbers = "1234567890";
        }
    }
}