using System;

namespace _0004_tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Tabuada: ");
            int tabuada = int.Parse(Console.ReadLine());//recebendo o número da tabuada

            new Tabuada().MontarTabuada(tabuada);//chamando a função para montar e exibir a tabuada
        }
    }
}
