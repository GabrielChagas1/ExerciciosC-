using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            int dia = DateTime.Now.Hour;//recuperando a hora atual

            System.Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();//lendo o nome dá pessoa

            if(dia < 12){
                Console.WriteLine($"Bom dia {nome}");//se o dia for menor que 12, imprime bom dia 
            }else if (dia < 18){
                Console.WriteLine($"Boa tarde {nome}");//se o dia for menor que 18, imprime boa tarde
            }else{
                System.Console.WriteLine($"Boa noite {nome}");//se o dia for maior que 18, imprime boa noite
            }
        }
    }
}
