using System;

class Retangulo
{
    private int h; //altura do retangulo
    private int b; //base do triangulo

    public Retangulo(int h, int b) //construtor
    {
        this.h = h;
        this.b = b;
    }

    public Retangulo() //Permite criar o objeto com valores zerados
    { }
    public int Altura
    {
        get { return h; } // retorna o valor
        set { h = value; } // reescreve o valor
    }
    public int Base
    {
        get { return b; }
        set { b = value; }
    }
    public int area
    {
        get { return h * b; } //reescreve
    }
    public virtual void infos()
    {
        Console.WriteLine("O calculo da área do retângulo de altura {0} e base {1} é: {2}", h, b, area);
    }

    static void Main()
    {
        Retangulo CalculoArea = new Retangulo(); // Cria um objeto Retangulo usando o construtor padrão
        Console.WriteLine("Digite o valor da altura do seu retângulo/quadrado:");
        int.TryParse(Console.ReadLine(), out int Altura);
        Console.WriteLine("Digite o valor da base do seu retângulo/quadrado:");
        int.TryParse(Console.ReadLine(), out int Base);

        CalculoArea.Altura = Altura;  // Atribui os valores diretamente aos atributos privados
        CalculoArea.Base = Base;

        CalculoArea.infos(); // Chama o método que exibe as informações
    } 
}
