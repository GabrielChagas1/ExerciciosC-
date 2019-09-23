using System;
using System.Collections.Generic;

namespace _0002_Teste
{
    class Program
    {
        
        static void Main(string[] args)
        {
            System.Console.Write("[0] PAR \n[1] IMPAR \nEscolha uma opção: ");
            int user = int.Parse(Console.ReadLine());//recebe a escolha do user

            new Lista().VerificarResultado(user);//função que recebe a escolha do user e a partir disso faz todas as validações

        }
    }
}
