/*Identifique as classes e implemente um programa para a seguinte especificação: “O
supermercado vende diferentes tipos de produtos. Cada produto tem um preço e uma
quantidade em estoque. Um pedido de um cliente é composto de itens, onde cada item
especifica o produto que o cliente deseja e a respectiva quantidade. Esse pedido pode ser
pago em dinheiro, cheque ou cartão.”*/
using System;
// Classe Produto
class Produto
{  
     // Atributos privados 
    private string nome;
    private float preco;
    private int quantestoque; // Quantidade disponível em estoque
    
    // Construtor padrão (quando nenhum valor é passado)
    public Produto()
    {
        nome = "Sem nome";
        preco = 0.0f;
        quantestoque = 0;
    }
     // Construtor com parâmetros (quando o usuário informa os dados)
    public Produto(string nome, float preco, int quantestoque)
    {
        this.nome = nome;
        this.preco = preco;
        this.quantestoque = quantestoque;
    }
    // Propriedade Nome (permite acessar e modificar o nome)
    public string Nome 
    {
        get { return nome;} // Retorna o nome
        set { nome = value; } //modifica o nome
    }
    public float Preco  // Propriedade Preco
    {
      get { return preco;}
      set { preco = value; }
    }
    public int QuantEstoque  // Propriedade QuantEstoque
    {
        get { return quantestoque;}
        set {quantestoque = value;}
    }
}
// Classe ItemPedido
// Representa um item dentro do pedido
class ItemPedido
{
    private Produto produto; // Produto associado ao item
    private int quantpedida; //quantidad pedida pelo cliente
    
    public ItemPedido()
    {
        produto = new Produto(); // Cria um produto vazio
        quantpedida = 0;
    }
     // Construtor com parâmetros
    public ItemPedido (Produto produto, int quantpedida)
    {
        this.produto = produto; // Recebe o produto informado
        this.quantpedida= quantpedida; //recebe a quantidade informada
    }
     public Produto Produto
    {
     get { return produto; }
     set { produto = value; }
    }
    public int Quantpedida 
    {
        get { return quantpedida;}
        set { quantpedida = value;}
    }
    // Método que calcula o subtotal do item
    // Subtotal = preço do produto × quantidade pedida
     public double CalcularSubtotal()
    {
        return produto.Preco * quantpedida;
    }
}
// enum FormaPagamento (define opções possíveis de pagamento)
enum FormaPagamento
{
    Dinheiro = 1,
    Cheque = 2,
    Cartao = 3
}

// Classe Pedido
 class Pedido{
    private ItemPedido[]itens;
    private int cont;
    private FormaPagamento formaPagamento;
    
    public Pedido(FormaPagamento formaPagamento)
    {
        this.formaPagamento = formaPagamento;
        itens = new ItemPedido[10]; // máximo 10 itens
        cont = 0;
    }
   
    public void AdicionarItem(ItemPedido item)
    {
        if (cont < 10)
        {
            itens[cont] = item;
            cont++;
        }
    }
       // Método que calcula o total do pedido
public float CalcularTotal()
    {
        float total = 0;

        for (int i = 0; i < cont; i++)
        {
            total += (float)itens[i].CalcularSubtotal();
        }

        return total;
    }
     // Método que exibe todas as informações do pedido
    public void ExibirPedido()
    {
        Console.WriteLine("------ PEDIDO ------");

        foreach (ItemPedido item in itens)
        {
            Console.WriteLine("Produto: " + item.Produto.Nome);
            Console.WriteLine("Quantidade: " + item.Quantpedida);
            Console.WriteLine("Subtotal: " + item.CalcularSubtotal());
            Console.WriteLine("---------------------");
        }

        Console.WriteLine("Total: " + CalcularTotal());
        Console.WriteLine("Forma de Pagamento: " + formaPagamento);
    }
}

public class Programa
{
    public static void Main(string[] args)
    {
    // Pergunta ao usuário quantos itens deseja adicionar
    Console.WriteLine("Quantos itens deseja adicionar?");
    int qntItens = int.Parse(Console.ReadLine());
    // Pergunta forma de pagamento
    Console.WriteLine("Forma de pagamento:");
        Console.WriteLine("1 - Dinheiro");
        Console.WriteLine("2 - Cheque");
        Console.WriteLine("3 - Cartao");
        int escolha = int.Parse(Console.ReadLine());
          // Cria um pedido com a forma escolhida
        Pedido pedido = new Pedido((FormaPagamento)escolha);
         // For para cadastrar os itens
        for (int i = 0; i < qntItens; i++)
        {
            Console.WriteLine("\nDigite o nome do produto:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o preço:");
            float preco = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a quantidade em estoque:");
            int estoque = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a quantidade pedida:");
            int quantidade = int.Parse(Console.ReadLine());
            // Cria o produto
            Produto produto = new Produto(nome, preco, estoque);
            // Cria o item do pedido
            ItemPedido item = new ItemPedido(produto, quantidade);

            pedido.AdicionarItem(item);
        }

        pedido.ExibirPedido();
    }
}
  
