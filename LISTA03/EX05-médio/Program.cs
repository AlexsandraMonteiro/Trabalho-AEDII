/* 1) Crie um programa que exiba para o usuário qual é a área de um retângulo. Para implementar esse programa você deverá seguir as seguintes regras:

* O usuário deverá informar para o programa o valor da base e altura do retângulo/quadrado.

* É obrigatório criar/utilizar uma classe para representar o retângulo/quadrado.

* A base e a altura informada pelo usuário deveram ser representadas na classe como propriedades.

* O objeto deverá possuir uma propriedade para exibir o valor da área do retângulo/quadrado.

*O objeto deverá possuir um método que exiba os dados de todas as suas propriedades.
*/

using System;

class Retangulo
{
    private int h;
    private int b;

    private Retangulo()
    {
    }

    private int Altura
    {
        get { return h; }
        set { h = value; }
    }

    private int Base
    {
        get { return b; }
        set { b = value; }
    }

    private int Area
    {
        get { return h * b; }
    }

    private void Infos()
    {
        Console.WriteLine($"O cálculo da área do retângulo de altura {h} e base {b} é: {Area}");
    }

    static void Main()
    {
        Retangulo calculoArea = new Retangulo();

        Console.WriteLine("Digite a altura:");
        int.TryParse(Console.ReadLine(), out int altura);

        Console.WriteLine("Digite a base:");
        int.TryParse(Console.ReadLine(), out int baseRetangulo);

        calculoArea.Altura = altura;
        calculoArea.Base = baseRetangulo;

        calculoArea.Infos();
        Console.ReadKey();
    }
}

