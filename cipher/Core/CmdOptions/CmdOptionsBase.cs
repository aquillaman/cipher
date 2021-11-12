using CommandLine;

namespace Cipher.Core.CmdOptions
{
    internal abstract class CmdOptionsBase
    {
        [Option('d', "decode", Required = false,
            HelpText = "Выполнить декодирование файла. Поумолчанию если не передавать эту опцию программа работает в режиме кодирования.")]
        public bool Decode { get; set; }

        [Option('i', "input", Required = true, HelpText = "Исходный файл для обработки.")]
        public string Input { get; set; }

        [Option('o', "output", Required = true, HelpText = "Целевой файл, в который будет помещен результат обработки информации из исходного файла.")]
        public string Output { get; set; }
    }
}