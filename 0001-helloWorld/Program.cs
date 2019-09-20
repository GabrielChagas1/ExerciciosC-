using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var dia = new Dia();
            int hora = DateTime.Now.Hour;//recuperando a hora atual
            System.Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();//lendo o nome dá pessoa
            if(hora < 12){
                Console.WriteLine($"Bom dia {nome}, no momento são {dia.retornaDia().ToShortTimeString()} do dia {dia.retornaDia().ToShortDateString()}");//se o dia for menor que 12, imprime bom dia 
            }else if (hora < 18){
                Console.WriteLine($"Boa tarde {nome}, no momento são {dia.retornaDia().ToShortTimeString()} do dia {dia.retornaDia().ToShortDateString()}");//se o dia for menor que 18, imprime boa tarde
            }else{
                System.Console.WriteLine($"Boa noite {nome}, no momento são {dia.retornaDia().ToShortTimeString()} do dia {dia.retornaDia().ToShortDateString()}");//se o dia for maior que 18, imprime boa noite
            }
        }
    }
}
