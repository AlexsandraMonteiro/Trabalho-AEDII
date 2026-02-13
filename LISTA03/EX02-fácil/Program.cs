using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        for (int i = 1; i<= 100; i++) // repete o i de 1 até 100
            {
                if(i % 2 == 0) // divide o i por 2 e apenas mostra os numeros que o resultado da divisão for igual a 0
                {
                    Console.WriteLine(i); // escreve os números na tela
                }
            }
        }
    }
}
