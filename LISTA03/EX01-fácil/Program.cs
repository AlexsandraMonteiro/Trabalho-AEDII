//1) Crie um programa que exiba o seu nome na tela 100 vezes.

using System;

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine(); // lê o nome que você digitar

            for(int i = 1; i <= 100; i++) // repete o i de 1 até 100
            {
                Console.WriteLine("{0}° - {1}",i, nome); // escreve o nome escrito no programa na tela 100 vezes
            }

        }
    }
