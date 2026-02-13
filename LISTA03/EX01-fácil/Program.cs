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
            string nome = Console.ReadLine();

            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0}° - {1}",i, nome);
            }

        }
    }
}
