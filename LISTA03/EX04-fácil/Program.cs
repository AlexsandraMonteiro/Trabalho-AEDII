/* 4) Os números de Fibonacci são uma sequência de números definidas recursivamente. O primeiro elemento da sequência é 0 e o segundo é 1. Os outros elementos são calculados somando os dois antecessores. Crie um programa que exiba os primeiros 30 números da série de Fibonacci.
*/

using System;

class Program
{
    static void Main()
    {
        int a = 0;
        int b = 1; // define os dois primeiros numeros

        Console.WriteLine("Números da sequencia de Fibonacci:");
        Console.WriteLine(a);
        Console.WriteLine(b); // escreve os dois primeiros numeros

        for (int i = 3; i <= 30; i++) // repete o i até o 30
        {
            int prox = a + b;
            Console.WriteLine(prox); // escreve na tela o resultado do calculo dos numeros antecessores

            a = b;
            b = prox; // substitui os numeros, a pelo b e b pelo proximo para somar outra vez
        }
    }
}
