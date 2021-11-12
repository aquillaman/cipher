using System;
using System.Globalization;
using System.IO;
using System.Text;
using Cipher.Core.Atbash;
using Cipher.Core.Caesar;
using Cipher.Core.CmdOptions;
using Cipher.Core.Interfaces;
using Cipher.Core.Vigenere;
using CommandLine;

namespace Cipher
{
    /// <summary>
    /// atb -i e:\cipher\source.txt -o e:\cipher\cipher.txt
    /// atb -d -i e:\cipher\cipher.txt -o e:\cipher\plain.txt
            
    /// cae -k 17 -i e:\cipher\source.txt -o e:\cipher\cipher.txt
    /// cae -d -k 17 -i e:\cipher\cipher.txt -o e:\cipher\plain.txt
            
    /// vig -k процессоров -i e:\cipher\source.txt -o e:\cipher\cipher.txt
    /// vig -d -k процессоров -i e:\cipher\cipher.txt -o e:\cipher\plain.txt
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Parser.Default.ParseArguments<AtbashCmdOptions, CaesarCmdOptions, VigenereCmdOptions>(args)
                .MapResult(
                    (AtbashCmdOptions opts) => Execute(opts),
                    (CaesarCmdOptions opts) => Execute(opts),
                    (VigenereCmdOptions opts) => Execute(opts),
                    errs => 1);
        }

        private static int Execute(AtbashCmdOptions opts)
        {
            if (!ValidateOptions(opts)) return 1;
            Execute(new AtbashCipher(), opts);
            return 0;
        }

        private static int Execute(CaesarCmdOptions opts)
        {
            if (!ValidateOptions(opts)) return 1;
            Execute(new CaesarCipher(opts.Key), opts);
            return 0;
        }

        private static int Execute(VigenereCmdOptions opts)
        {
            if (!ValidateOptions(opts)) return 1;
            Execute(new VigenereCipher(opts.Key), opts);
            return 0;
        }

        private static bool ValidateOptions(CmdOptionsBase opts)
        {
            if (string.IsNullOrEmpty(opts.Input))
            {
                Console.WriteLine($"Input file path not set: '{opts.Input}'.");
                return false;
            }
            
            if (string.IsNullOrEmpty(opts.Output))
            {
                Console.WriteLine($"Output file path not set: '{opts.Output}'.");
                return false;
            }

            if (!File.Exists(opts.Input))
            {
                Console.WriteLine($"Input file not exist: '{opts.Input}'.");
                return false;
            }

            return true;
        }

        private static void Execute(ICipher cipher, CmdOptionsBase opts)
        {
            Console.WriteLine($"Processing input file: {opts.Input}");

            using var readStream = File.OpenRead(opts.Input);
            using var reader = new StreamReader(readStream);

            using var writeStream = File.Open(opts.Output, FileMode.Create);
            using var writer = new StreamWriter(writeStream);

            var input = new StringBuilder();
            var output = new StringBuilder();
            
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                input.Append(line);
                line = opts.Decode ? cipher.Decrypt(line) : cipher.Encrypt(line);
                output.Append(line);
                writer.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine($"[METHOD]: {cipher.Name}");
            Console.WriteLine("[INPUT]:");
            Console.WriteLine(input + "\r\n");
            Console.WriteLine("[OUTPUT]:");
            Console.WriteLine(output + "\r\n");
            
            Console.WriteLine($"Process result written into output file: {opts.Output}");
        }
    }
}