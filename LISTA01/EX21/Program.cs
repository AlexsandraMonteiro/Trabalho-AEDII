// 21. Faça	um	programa	para	controle	de	empréstimo	de	livros,	com	as	classes	Emprestimo,	Livro	e	Pessoa.
using System;
//classe Livro
 class Livro
{
    //atributos privados
    private string titulo;
    private string autor;
    
    public Livro()
    {
        titulo = "sem título";
        autor = "sem autor";
    }
    //construtor
    public Livro(string titulo, string autor)
    {
        this.titulo = titulo;
        this.autor = autor;
    }
    //metodo para obter
    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }
    
    public string Autor
    {
        get { return autor; }
        set { autor = value; }
    }
}
class Pessoa
{
    private string nome;
    private string cpf;
    
    public Pessoa()
    {
        nome = "Sem nome";
        cpf = "Sem cpf";
    }
    
    public Pessoa (string nome, string cpf)
    {
        this.nome = nome;
        this.cpf = cpf;
    }
    public string Nome 
    {
        get { return nome; }
        set { nome = value; }
    }
    public string Cpf 
    {
        get { return cpf; }
        set { cpf = value; }
    }
}
class Emprestimo
{
    private Livro livro;
    private Pessoa pessoa;
    private string data;
    
    public string Data
    {
        get { return data; }
        set { data = value; }
    }
    
    public Livro Livro
    {
        get {return livro; }
        set { livro = value; }
    }
     public Pessoa Pessoa 
     {
         get { return pessoa; }
         set { pessoa = value; }
     }

     //função para exibir emprestimo
     public void ExibirEmprestimo()
     {
         Console.WriteLine("_______________EMPRÉSTIMO______________");
         Console.WriteLine($"Data: "+ Data);
          Console.WriteLine("\n--- Livro ---");
        Console.WriteLine("Título: " + Livro.Titulo);
        Console.WriteLine("Autor: " + Livro.Autor);

        Console.WriteLine("\n--- Pessoa ---");
        Console.WriteLine("Nome: " + Pessoa.Nome);
        Console.WriteLine("CPF: " + Pessoa.Cpf);

        Console.WriteLine("======================");
     }
}
     class Programa
     {
         static void Main(string[]args)
         {
             //criando objetos vazios
             Livro livro = new Livro();
             Pessoa pessoa = new Pessoa();
             Emprestimo emprestimo = new Emprestimo();
             //pedindo entradas aos usuarios
             Console.WriteLine("Insira o título do livro:");
             livro.Titulo = Console.ReadLine();
             Console.WriteLine("Insira o autor do livro:");
             livro.Autor = Console.ReadLine();
             Console.WriteLine("Digite o nome da pessoa:");
             pessoa.Nome = Console.ReadLine();
             Console.WriteLine("Insira o CPF da pessoa:");
             pessoa.Cpf = Console.ReadLine();
             Console.WriteLine("Digite a data do empréstimo:");
             emprestimo.Data = Console.ReadLine();  
             // Ligando os objetos
             emprestimo.Livro = livro;
             emprestimo.Pessoa = pessoa;

             Console.WriteLine();
             emprestimo.ExibirEmprestimo(); 
        }
     }    

    

    
