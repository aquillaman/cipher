using CommandLine;

namespace Cipher.Core.CmdOptions
{
    [Verb("cae", HelpText = "Использовать шифр Цезаря для кодирования/раскодирования текстового файла.")]
    internal class CaesarCmdOptions : CmdOptionsBase
    {
        [Option('k', "key", Required = true, HelpText = "Ключ (смещение) для работы шифра Цезаря 'int'.")]
        public int Key { get; set; }
    }
}