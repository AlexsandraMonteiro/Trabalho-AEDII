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
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine(); // lê o nome que você digitar

            for(int i = 1; i <= 100; i++) // repete o i de 1 até 100
            {
                Console.WriteLine("{0}° - {1}",i, nome); // escreve o nome escrito no programa na tela 100 vezes
            }

        }
    }
}
