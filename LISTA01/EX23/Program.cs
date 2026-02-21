/* 23. Faça	um	programa	que	calcule	a	área	de	uma	figura	geométrica.	
Aceite	quatro	tipos	de	figura	geométrica:	quadrado,	retângulo,	triângulo	e	círculo. Use	herança	e	polimorfismo.*/
using System;
class Figura
{
    public virtual double CalcularArea()
    {
        return 0;
    }
}

// QUADRADO
class Quadrado : Figura
{
    private double lado;

    public double Lado
    {
        get { return lado; }
        set { lado = value; }
    }

    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }
}

// RETÂNGULO
class Retangulo : Figura
{
    private double baseRet;
    private double altura;

    public double Base
    {
        get { return baseRet; }
        set { baseRet = value; }
    }

    public double Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public Retangulo(double b, double a)
    {
        Base = b;
        Altura = a;
    }

    public override double CalcularArea()
    {
        return Base * Altura;
    }
}

// TRIÂNGULO
class Triangulo : Figura
{
    private double baseTri;
    private double altura;

    public double Base
    {
        get { return baseTri; }
        set { baseTri = value; }
    }

    public double Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public Triangulo(double b, double a)
    {
        Base = b;
        Altura = a;
    }

    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }
}

// CÍRCULO
class Circulo : Figura
{
    private double raio;

    public double Raio
    {
        get { return raio; }
        set { raio = value; }
    }

    public Circulo(double r)
    {
        Raio = r;
    }

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha a figura:");
        Console.WriteLine("1 - Quadrado");
        Console.WriteLine("2 - Retângulo");
        Console.WriteLine("3 - Triângulo");
        Console.WriteLine("4 - Círculo");

        int opcao = int.Parse(Console.ReadLine());
        Figura figura = null;

        switch (opcao)
        {
            case 1:
                Console.Write("Digite o lado: ");
                figura = new Quadrado(double.Parse(Console.ReadLine()));
                break;

            case 2:
                Console.Write("Digite a base: ");
                double bRet = double.Parse(Console.ReadLine());
                Console.Write("Digite a altura: ");
                double aRet = double.Parse(Console.ReadLine());
                figura = new Retangulo(bRet, aRet);
                break;

            case 3:
                Console.Write("Digite a base: ");
                double bTri = double.Parse(Console.ReadLine());
                Console.Write("Digite a altura: ");
                double aTri = double.Parse(Console.ReadLine());
                figura = new Triangulo(bTri, aTri);
                break;

            case 4:
                Console.Write("Digite o raio: ");
                figura = new Circulo(double.Parse(Console.ReadLine()));
                break;
        }

        if (figura != null)
            Console.WriteLine($"Área: {figura.CalcularArea():F2}");
    }
}
