//5.
//tabuada 1 ao 10
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //declarando variáveis 
        int num=1, tabuada;
        Console.WriteLine("Tabuada do 1");
        //cálculo da tabuada
        for (int i=1; i<=10; i++)
        {
          tabuada = num * i;
          Console.WriteLine(num + "x"  + i+" = " +tabuada); 
        }
    }
}
