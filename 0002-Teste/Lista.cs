using System;
using System.Collections.Generic;

public class Lista
{
    public List<int> CriarLista(int quantidade)
    {
        int[] validos = new int[quantidade];

        for (int i = 0; i < validos.Length; i++)
        {
            validos[i] = i;
        }

        List<int> ListValidos = new List<int>();
        ListValidos.AddRange(validos);

        return ListValidos;
    }

    public void VerificarResultado(int userEscolha){
        int cpu = 0, numCPU = 0, total = 0, numUSER = 0, user = userEscolha;
        bool ok = false;

        
        if(user.Equals(0)){
            cpu = 1;//se o user escolher par, então a cpu recebe impar
        }

        //funções para criar a lista de elementos disponiveis
        Lista lista = new Lista();
        List<int> ListValidos = lista.CriarLista(6);

        do
        {
            System.Console.Write("Digite um número entre 0 e 5: ");
            numUSER = int.Parse(Console.ReadLine());//recebe o valor que ele escolher

            if(ListValidos.Contains(numUSER)){
                ok = true;
            }             
        } while (!ok);

        Random rdn = new Random();
        numCPU = rdn.Next(0, 6);//feito um random para atribuir um valor a CPU

        total = numCPU + numUSER;//soma para descobrir o valor a ser dividido

        if((total % 2 == 0 && user == 0) || (total % 2 != 0 && user == 1)){
            //se o resto do total der 0 e o user esocolheu par, significa que ele ganhou o jogo
            //ou se der total quebrado e ele escolheu impar, significa que ele também ganhou o jogo
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"O número escolhido pela cpu foi {numCPU}. \nO número total foi {total}. \nParabéns, você ganhou o jogo!");
        }else{
            //senão significa que ele perdeu o jogo para a cpu
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine($"O número escolhido pela cpu foi {numCPU}. \nO número total foi {total}. \nInfelizmente você perdeu a partida");
        }

    }

}