using CommandLine;

namespace Cipher.Core.CmdOptions
{
    [Verb("vig", HelpText = "Использовать шифр Виженера для кодирования/раскодирования текстового файла.")]
    internal class VigenereCmdOptions : CmdOptionsBase
    {
        [Option('k', "key", Required = true, HelpText = "Ключ для работы шифра Виженера 'string'.")]
        public string Key { get; set; }
    }
}