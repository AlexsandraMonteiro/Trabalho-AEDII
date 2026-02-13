//8.
/*Calcule a série de Fibonacci para um número inteiro não negativo informado pelo usuário. A série de Fibonacci inicia com os números F0 = 0 e F1 = 1, e cada número posterior equivale à soma dos dois números anteriores (Fn = Fn-1 + Fn-2). Por exemplo, caso o usuário informe o número 9, o resultado seria: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.*/
using System;

public class ProgramaFibonacci
{
    public static void Main(string[] args)
    {
        //declarando variáveis 
        int n, fn,  f0 = 0, f1 = 1;
        //pedindo entrada
        Console.WriteLine("Digite um número inteiro não negativo");
        n = int.Parse(Console.ReadLine());
        //cálculo 
        for (int i=0; i<=n; i++)
        {
          if(i==0)
          {
             Console.Write(f0);
          }
          else if (i==1)
          {
             Console.Write(", " + f1);
          }
         else
         {
            fn = f0 + f1;
            Console.Write(", " + fn);
                f0 = f1;
                f1 = fn;
          }
        }
    }
}
