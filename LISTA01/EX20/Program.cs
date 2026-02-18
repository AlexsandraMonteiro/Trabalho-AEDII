//20. Faça um programa de agenda telefônica, com as classes Agenda e Contato.

using System;
//classe contato
 class Contato
{
    //atributos privados
    private string nome;
    private string telefone;
    
    //construtor
    public Contato(string nome, string telefone)
    {
        this.nome = nome;
        this.telefone = telefone;
    }
    public string Nome  // Propriedade para acessar ou alterar o nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public string Telefone   // Propriedade para acessar ou alterar o telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }
    public void ExibirContato() // Método para exibir as informações do contato
    {
        
        Console.WriteLine("Nome: "+ nome);
        Console.WriteLine("Telefone: "+ telefone);
        Console.WriteLine("--------------------");
    }
}
    // Classe Agenda
    class Agenda
    {
        private Contato[] contatos;//vetor de contato
        private int count;//conta quantos contatos foram adicionados
        public Agenda()
        {
            contatos = new Contato[10];
            count = 0;
        }
        //função para adicionar contato
        public void AdicionarContato(Contato c)
        {
            if (count < 10)
            {
                contatos[count] = c; // Adiciona o contato no vetor
                count++; //incrementa de 1 em 1 
                Console.WriteLine("Contato Adicionado!");
            }
            // Caso o vetor esteja cheio
            else 
            {
                Console.WriteLine("Agenda cheia!"); 
            }
        }
        //função para listar contatos
        public void ListarContatos()
        {
            if (count == 0)
            {
                Console.WriteLine("Agenda vazia");
                return;
            }
             // Percorre todos os contatos adicionados e exibe
           for (int i = 0; i < count; i++)
          {
            contatos[i].ExibirContato();
          }
         }
             // Método para buscar um contato pelo nome
         public void BuscarContato(string nome)
     {
        bool encontrou = false;

        for (int i = 0; i < count; i++)
        {   
            // Método para buscar um contato pelo nome
            if (contatos[i].Nome.ToLower() == nome.ToLower())
            {
                contatos[i].ExibirContato(); // Exibe o contato encontrado
                encontrou = true;
            }
        }

        if (!encontrou)// Se não encontrou nenhum contato
            Console.WriteLine("Contato não encontrado.");
        }
    }
    class Programa 
    {
        static void Main(string[]args)
        {
            Agenda agenda = new Agenda(); // Cria uma nova agenda
            int opcao; //armazena a opção do usuario
            do // Loop principal do programa (menu)
          {
            Console.WriteLine("Digite 1 - Para Adicionar um número a lista");
            Console.WriteLine("Digite 2 - Para Listar números");
            Console.WriteLine("Digite 3 - Para Buscar");
            Console.WriteLine("Digite 0 - Para Sair");
            opcao = int.Parse(Console.ReadLine());
            
            switch(opcao )
            { 
                case 1:
                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Telefone:");
                string telefone = Console.ReadLine();
                Contato novo = new Contato(nome, telefone);//Cria novo contato
                agenda.AdicionarContato(novo);// Adiciona à agenda
                     break;
            
               case 2:
                agenda.ListarContatos(); 
                break;
              case 3:
              Console.Write("Nome para buscar: ");
                    string busca = Console.ReadLine();
                    agenda.BuscarContato(busca);
                    break;
                    case 0:
                    Console.WriteLine("Programa encerrado!");
                    break;

                default:
                    Console.WriteLine("Opção inválida!\n");
                    break;
            }
          }    
            while (opcao != 0);
            Console.WriteLine("Programa encerrado!");// Continua enquanto a opção não for 0
        }
    }
    
