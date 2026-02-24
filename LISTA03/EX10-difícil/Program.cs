/* 2) Faça uma classe Conta que contenha o nome do cliente, o número da conta e o saldo. 

* Estes valores deverão ser informados no construtor da classe. Faça um método depositar e um método sacar para realizar o depósito e saque de valores da conta.

* Faça um método obterSaldo que retorne o saldo do cliente. 

* Faça um método obterNumero que retorne o número da conta. 

* Faça um método obterNomeCliente que retorna o nome do cliente titular da conta.

* Desenvolva um programa para testar a classe Conta. O programa deverá criar 3 contas diferentes e realizar diversas operações de saque e depósito. Depois, o programa deverá emitir um relatório (no console) apresentando o número, o titular e o saldo atual de cada conta.

* Faça uma classe Extrato, que contenha a data da movimentação e o valor movimentado (pode ser tanto positivo quanto negativo);

* Incremente a classe Conta, incluindo um vetor de 1000 posições de Extrato.

* Cada vez que ocorrer um depósito ou um saque na conta, deverá criar um objeto Extrato com as informações de data da movimentação e o valor da movimentação;

* Desenvolva um programa para testar a nova classe Conta. O programa deverá criar 3 contas diferentes e realizar diversas operações de saque e depósito. Depois, o programa deverá emitir um relatório (no console) apresentando o número, o titular, saldo atual e o extrato de cada conta.

* Faça uma classe Cartão, que contenha o número do cartão, a validade do cartão.

* Incremente a classe Conta, incluindo a informação de cartão.

* Desenvolva um programa para testar a nova classe Conta. O programa deverá criar 3 contas diferentes e realizar diversas operações de saque e depósito. O programa deverá realizar operações de saque com cartão, onde deverá solicitar o número e a validade do cartão e identificar a conta à qual pertence o cartão. Depois, o programa deverá emitir um relatório (no console) apresentando o número, o titular, saldo atual e o extrato de cada conta.
*/

using System;

// Classe Conta representa uma conta bancária
public class Conta
{
    // Dados básicos da conta
    private string nome;      // Nome do titular
    private int numConta;     // Número da conta
    private double saldo;     // Saldo atual

    // Vetor para armazenar até 1000 movimentações
    private Extrato[] extratos = new Extrato[1000];
    private int posExtrato = 0; // controla a posição do próximo extrato

    // Cada conta possui um cartão associado
    public Cartao Cartao { get; private set; }

    // Construtor recebe os dados da conta e o cartão
    public Conta(string nome, int numConta, double saldo, Cartao cartao)
    {
        this.nome = nome;
        this.numConta = numConta;
        this.saldo = saldo;
        Cartao = cartao;
    }

    // Retorna nome do cliente
    public string ObterNomeCliente()
    {
        return nome;
    }

    // Retorna número da conta
    public int ObterNumero()
    {
        return numConta;
    }

    // Retorna saldo atual
    public double ObterSaldo()
    {
        return saldo;
    }

    // Realiza depósito e registra no extrato
    public void Depositar(double valor)
    {
        saldo += valor;
        RegistrarExtrato(valor); // valor positivo
    }

    // Realiza saque se houver saldo suficiente
    public void Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            RegistrarExtrato(-valor); // valor negativo
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque.");
        }
    }

    // Cria um objeto Extrato e salva no vetor
    private void RegistrarExtrato(double valor)
    {
        if (posExtrato < extratos.Length)
            extratos[posExtrato++] = new Extrato(valor);
    }

    // Mostra todas movimentações da conta
    public void MostrarExtrato()
    {
        for (int i = 0; i < posExtrato; i++)
            Console.WriteLine(extratos[i]);
    }

    // Classe interna que representa uma movimentação
    public class Extrato
    {
        public DateTime Data { get; private set; }
        public double Valor { get; private set; }

        public Extrato(double valor)
        {
            Data = DateTime.Now; // registra data automática
            Valor = valor;
        }

        // Permite imprimir o extrato diretamente
        public override string ToString()
        {
            return $"Data: {Data}, Valor: {Valor}";
        }
    }

    // Classe interna que representa um cartão
    public class Cartao
    {
        public string NumeroCartao { get; private set; }
        public string Validade { get; private set; }

        public Cartao(string numeroCartao, string validade)
        {
            NumeroCartao = numeroCartao;
            Validade = validade;
        }
    }

    // Saque utilizando cartão (valida número e validade)
    public void SacarComCartao(double valor, string numeroCartao, string validade)
    {
        if (Cartao != null &&
            Cartao.NumeroCartao == numeroCartao &&
            Cartao.Validade == validade)
        {
            Sacar(valor); // reutiliza método saque
        }
        else
        {
            Console.WriteLine("Cartão inválido.");
        }
    }
}

// Classe de teste (programa principal)
class Teste
{
    static void Main()
    {
        // Vetor para armazenar 3 contas
        Conta[] contas = new Conta[3];

        // Criação das contas
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Número do cartão: ");
            string numCartao = Console.ReadLine();

            Console.Write("Validade: ");
            string validade = Console.ReadLine();

            // Cria conta com cartão
            contas[i] = new Conta(nome, numConta, saldo,
                                  new Conta.Cartao(numCartao, validade));

            // Menu de operações da conta
            while (true)
            {
                Console.Write("Escolha a operação (1 - Depositar, 2 - Sacar, 3 - Sacar com cartão, 4 - Sair): ");
                int operacao = int.Parse(Console.ReadLine());

                if (operacao == 1)
                {
                    Console.Write("Digite o valor a depositar: ");
                    contas[i].Depositar(double.Parse(Console.ReadLine()));
                }
                else if (operacao == 2)
                {
                    Console.Write("Digite o valor a sacar: ");
                    contas[i].Sacar(double.Parse(Console.ReadLine()));
                }
                else if (operacao == 3)
                {
                    // Solicita dados do cartão
                    Console.Write("Número do cartão: ");
                    string num = Console.ReadLine();

                    Console.Write("Validade: ");
                    string val = Console.ReadLine();

                    Console.Write("Valor: ");
                    double valor = double.Parse(Console.ReadLine());

                    bool encontrou = false;

                    // Procura qual conta possui aquele cartão
                    foreach (var c in contas)
                    {
                        if (c != null && c.Cartao != null &&
                            c.Cartao.NumeroCartao == num &&
                            c.Cartao.Validade == val)
                        {
                            c.SacarComCartao(valor, num, val);
                            encontrou = true;
                            break;
                        }
                    }

                    if (!encontrou)
                        Console.WriteLine("Cartão não encontrado.");
                }
                else if (operacao == 4)
                {
                    break; // sai do menu da conta
                }
                else
                {
                    Console.WriteLine("Operação inválida.");
                }
            }
        }

        // Relatório final
        Console.WriteLine("\nRelatório de Contas:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Número da Conta: {contas[i].ObterNumero()}");
            Console.WriteLine($"Titular: {contas[i].ObterNomeCliente()}");
            Console.WriteLine($"Saldo Atual: {contas[i].ObterSaldo()}");
            Console.WriteLine("Extrato:");
            contas[i].MostrarExtrato();
            Console.WriteLine();
        }
    }
}
