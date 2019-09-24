using System;
public class Tabuada
{
    public void MontarTabuada(int numero){
        for (int i = 0; i <= 10; i++)
        {
            System.Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
    
}