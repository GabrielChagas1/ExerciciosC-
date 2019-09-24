using System;

namespace _0005_tabuada_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabuada = 0;
            do
            {
                System.Console.Write("Tabuada: ");
                tabuada = int.Parse(Console.ReadLine());//recebendo o número da tabuada
                new Tabuada().MontarTabuada(tabuada);//chamando a função para montar e exibir a tabuada

            } while (tabuada >=0);
            System.Console.WriteLine("Obrigado e volte sempre!");
        }
    }
}
