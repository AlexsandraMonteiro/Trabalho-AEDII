/* 22. Faça	uma	programa	para	representar	a	árvore	genealógica	de	uma	família.	
Para	tal,	crie	uma	classe	Pessoa	que	permita	indicar,	além	de	nome	e	idade,	o	pai	e	a	mãe.	
Tenha	em	mente	que	pai	e	mãe	também	são	do	tipo	Pessoa.	*/
using System;
class Pessoa
{
    private string nome;
    private int idade;
    private Pessoa pai;
    private Pessoa mae;
    
     public Pessoa()
     {
         nome = "Sem nome";
         idade = 0;
         pai = null;
         mae = null;
     }
     //construtor
     public Pessoa(string nome, int idade)
     {
         this.nome = nome;
         this.idade = idade;
         this.pai = null;
         this.mae = null;
     }
     //propriedades
     public string Nome 
     {
         get { return nome; }
         set { nome = value; }
     }
     public int Idade
     {
         get { return idade; }
         set { idade = value; }
     }
     public Pessoa Pai
     {
         get { return pai; }
         set { pai = value; }
     }
     public Pessoa Mae 
     {
         get { return mae; }
         set { mae = value; }
     }
     //metodod para exibir dados 
     public void ExibirDados()
     {
         Console.WriteLine ($"Nome: {nome}");
         Console.WriteLine ($"Idade: {idade}");
         if (pai != null)
         {
              Console.WriteLine ($"Pai: {Pai.Nome}");
         }
         else
         {
            Console.WriteLine ("Pai não informado");
         }
         if(mae != null)
         {
             Console.WriteLine($"Mãe: {Mae.Nome}");
         }
         else
         {
             Console.WriteLine("Mãe não informada");
         }
     }
}
class Progama 
{
    static void Main (string [] args)
    {
        // Criando os pais
        Pessoa pai = new Pessoa("Carlos", 50);
        Pessoa mae = new Pessoa("Maria", 48);

        // Criando o filho
        Pessoa filho = new Pessoa("João", 20);

        // Ligando pai e mãe ao filho
        filho.Pai = pai;
        filho.Mae = mae;

        // Exibindo dados
        Console.WriteLine("Árvore Genealógica:\n");

        filho.ExibirDados();
        pai.ExibirDados();
        mae.ExibirDados();
    }
}
