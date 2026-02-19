/* 3) Implemente um programa no qual o usuário deverá informar o nome e a idade de três pessoas. O programa deverá informar o nome da pessoa que possuir a maior idade. 

Regras que deverão ser seguidas para a implementação do algoritmo:

* É obrigatório o uso de classe para representar uma pessoa e ela deverá possuir como propriedades (características) um nome e uma idade.

* A classe deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e a idade da pessoa em questão.

* Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), um que não recebe parâmetro algum e outro que irá receber o nome e a idade de uma pessoa.
*/
using System;
using System.ComponentModel;

public class Pessoa
{
    private string nome;
    private int idade;

    public Pessoa()
    {

    }
    public Pessoa (string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public string nomepessoa
    {
        get { return nome; }
        set { nome = value; }
    }
    public int idadepessoa
    {
        get { return idade; }
        set { idade = value; }
    }

    public virtual void ExibirInfos()
    {
        Console.WriteLine("O nome da pessoa mais velha é :{0}", nomepessoa);
        Console.WriteLine("Idade: {0}", idadepessoa);
    }

    public class program
    {
        public static void Main()
        {
            string nome1;
            int idademax = 0;
            string nomemax = "";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite seu nome");
                nome1 = Console.ReadLine();
                Console.WriteLine("Digite sua idade");
                int.TryParse(Console.ReadLine(), out int idade1);
                
                if (idade1 > idademax)
                {
                    idademax = idade1;
                    nomemax = nome1;
                }
            }

            Pessoa pessoaa = new Pessoa();
            pessoaa.nomepessoa = nomemax;
            pessoaa.idadepessoa = idademax;
            pessoaa.ExibirInfos();
        }
    }
}
