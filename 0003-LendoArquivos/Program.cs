using System;
using System.IO;

namespace _0003_LendoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa para aprender a ler arquivos

            foreach (string line in File.ReadLines(@"c:\Users\gabriel\Desktop\LendoArquivo.txt"))
            {
                System.Console.WriteLine(line);
            }
        }
    }
}
