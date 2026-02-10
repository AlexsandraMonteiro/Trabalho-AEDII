/* 1. Determine	 as	 raízes	 de	 uma	 equação	 de	 2º	 grau:	 ax2 +	 bx	 +	 c	 =	 0	 (recordar	 que	 o	
discriminante	Δ =	b2 – 4ac,	e	que	a	raiz	r	=	(–b	± √Δ)/2a).
 */

using System;
public class EX01()
{
    public static void Main()
    {
        Console.Write("Digite o valor de A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor de B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor de C: ");
        double c = double.Parse(Console.ReadLine());

        CalcularRaizQuadrada(a, b, c);
    }
    public static void CalcularRaizQuadrada(double a, double b, double c)
    {
        if (a == 0)
        {
            Console.WriteLine("O valor de A não pode ser zero em uma equação quadrática.");
            return;
        }

        double delta = b * b - 4 * a * c;
        Console.WriteLine($"A = {a}, B = {b}, C = {c}");

        if (delta < 0)
        {
            Console.WriteLine("A equação não possui raízes reais.");

            double parteReal = -b / (2 * a);
            double parteImaginaria = Math.Sqrt(-delta) / (2 * a);

            Console.WriteLine($"As raízes complexas são: {parteReal} + {parteImaginaria}i");
        }
        else if (delta == 0)
        {
            Console.WriteLine("A equação possui uma raiz real dupla.");
            double raiz = -b / (2 * a);

            Console.WriteLine($"Raiz dupla: {raiz}");
        }
        else
        {
            Console.WriteLine("Delta possui duas raízes reais distintas.");
            double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"A equação possui duas raízes reais: {raiz1} e {raiz2}");
        }
    }
}