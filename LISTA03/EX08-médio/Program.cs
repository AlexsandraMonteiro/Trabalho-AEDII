/* 4) Crie um programa no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. O programa deverá exibir na tela para o usuário quantos cachorros, gatos e peixes foram informados.

Regras que deverão ser seguidas para a implementação do algoritmo:

* Os únicos tipos de animais válidos são cachorro, gato e peixe.

* Caso seja informado um tipo diferente o programa deverá definir o tipo do animal como Peixe.

* É obrigatório criar uma classe para representar o Animal.

* A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.

* A classe deverá possuir métodos de acesso para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).
*/

using System;
using System.Security.Principal;

public class Animal
{
    // Dados privados
    private string nome;
    private string tipo;

    // Construtor vazio
    public Animal()
    {
    }

    // Propriedade Nome
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    // Propriedade Tipo
    public string Tipo
    {
        get { return tipo; }
        set
        {
            string valor = value.ToLower();

            if (valor == "cachorro" || valor == "gato" || valor == "peixe")
            {
                tipo = valor;
            }
            else
            {
                tipo = "peixe";
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int qtdCachorro = 0;
        int qtdGato = 0;
        int qtdPeixe = 0;

        for (int i = 1; i <= 5; i++)
        {
            Animal animal = new Animal();

            Console.WriteLine($"\nAnimal {i}");

            Console.Write("Nome: ");
            animal.Nome = Console.ReadLine();

            Console.Write("Tipo: ");
            animal.Tipo = Console.ReadLine();

            // Contagem
            if (animal.Tipo == "cachorro")
                qtdCachorro++;
            else if (animal.Tipo == "gato")
                qtdGato++;
            else
                qtdPeixe++;
        }

        Console.WriteLine("\n--- Resultado ---");
        Console.WriteLine("Cachorros: " + qtdCachorro);
        Console.WriteLine("Gatos: " + qtdGato);
        Console.WriteLine("Peixes: " + qtdPeixe);
    }
}
