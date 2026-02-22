// 2. Calcule	a	distância	entre	dois	pontos	num espaço	de	3	dimensões.

using System;

class EX02
{
    public static void Main()
    {
        // Solicitar as coordenadas do ponto 1
        Console.Write("Digite X1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Digite Y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Digite Z1: ");
        double z1 = double.Parse(Console.ReadLine());

        // Solicitar as coordenadas do ponto 2
        Console.Write("Digite X2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Digite Y2: ");
        double y2 = double.Parse(Console.ReadLine());

        Console.Write("Digite Z2: ");
        double z2 = double.Parse(Console.ReadLine());

        // Calcular a distância usando a fórmula da distância em 3D

        double distancia = Math.Sqrt(
            Math.Pow(x2 - x1, 2) +
            Math.Pow(y2 - y1, 2) +
            Math.Pow(z2 - z1, 2)
            );

        Console.WriteLine($"POnto 1: ({x1}, {y1}, {z1})");
        Console.WriteLine($"Ponto 2: ({x2}, {y2}, {z2})");
        Console.WriteLine($"A distância entre os pontos é: {distancia}");
    }
}
