6.
//contador de dígitos 
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //declarando variáveis 
        int num, cont=0;
        //pedidndo entradas
        Console.WriteLine("Informe um número");
        num = int.Parse(Console.ReadLine());
        //contando a quantidade de dígitos do número
        // Verificando se o número é 0
        if (num == 0)
        {
