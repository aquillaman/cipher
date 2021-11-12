using CommandLine;

namespace Cipher.Core.CmdOptions
{
    [Verb("atb", HelpText = "Использовать шифр Атбаш для кодирования/раскодирования текстового файла.")]
    internal class AtbashCmdOptions : CmdOptionsBase
    {
    }
}