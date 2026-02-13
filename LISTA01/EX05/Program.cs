//5.
//Construa a tabela de multiplicação de números de 1 a 10 (ex.: 1 x 1 = 1, 1 x 2 = 2, etc.).
using System;

public class Programa
{
    public static void Main(string[] args)
    {
        //declarando variáveis 
        int num, tabuada;
        //pedindo o número que vai ser multiplicado
        Console.WriteLine("Digite o número que deseja multiplicar");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Tabuada do {num}");
        //cálculo da tabuada
        for (int i=1; i<=10; i++)
        {
          tabuada = num * i;
          Console.WriteLine(num + "x"  + i+" = " +tabuada); 
        }
    }
}
