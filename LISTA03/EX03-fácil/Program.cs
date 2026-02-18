/*3) Crie um programa que imprima na tela um triângulo de “*”:
*
**
***
****
*/

using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 4; i++) // controla a quantidade de linhas
        {
            for (int j = 1; j <= i; j++) // controla a quantidade de *
            {
                Console.Write("*");
            }
            Console.WriteLine(); // pula uma linha
        }
    }
}
