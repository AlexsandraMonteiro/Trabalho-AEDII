/* 1) Desenvolva uma classe Lâmpada, a qual pode ser ligada e desligada. Também deve ser possível observar o estado da lâmpada (se desligada ou ligada).

* Desenvolva uma nova classe para a lâmpada de forma a incluir as características de potência e voltagem. Garanta que seja possível tanto ler quanto alterar os valores de potência e voltagem de uma lâmpada.

* Crie uma classe Teste com um método main para testar as classes desenvolvidas nos exercícios 1 e 2. Crie uma lâmpada, apresente no console as informações de estado (se ligada ou desligada, potência e voltagem), ligue a lâmpada e apresente novamente as informações de estado.
 
* Modifique a classe da lâmpada criada anteriormente para incluir o caso de uma lâmpada queimar ao ser ligada. Sabe-se que existe uma chance de 15% da lâmpada queimar ao ser ligada. 

Dica: neste exercício é importante pesquisar na biblioteca de classes fornecida pela linguagem de programação uma classe que dê suporte à geração de números aleatórios.
*/

using System;

public class Lampada
{
    private bool ligada;
    private bool queimada;
    private int potencia;
    private int voltagem;

    private Random random = new Random();

    // Construtor
    public Lampada(int potencia, int voltagem)
    {
        this.potencia = potencia;
        this.voltagem = voltagem;
        ligada = false;
        queimada = false;
    }

    public bool Ligada
    {
        get { return ligada; }
    }

    public bool Queimada
    {
        get { return queimada; }
    }

    // Propriedades (get e set)
    public int Potencia
    {
        get { return potencia; }
        set { potencia = value; }
    }

    public int Voltagem 
    {
        get { return voltagem; }
        set { voltagem = value; }
    }

    // Métodos
    public void Ligar()
    {
        if (queimada)
        {
            Console.WriteLine("A lâmpada está queimada!");
            return;
        }

        // 15% de chance de queimar
        int chance = random.Next(1, 101);

        if (chance <= 15)
        {
            queimada = true;
            ligada = false;
            Console.WriteLine("A lâmpada queimou ao ser ligada!");
        }
        else
        {
            ligada = true;
            Console.WriteLine("A lâmpada foi ligada.");
        }
    }

    public void Desligar()
    {
        if (!queimada)
        {
            ligada = false;
            Console.WriteLine("A lâmpada foi desligada.");
        }
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"Lâmpada: {(ligada ? "Ligado" : "Desligado")}");
        Console.WriteLine($"Potência: {potencia}W");
        Console.WriteLine($"Voltagem: {voltagem}V");
        Console.WriteLine($"Queimada: {queimada}");
    }
}

class Teste
{
    static void Main()
    {
        Lampada lampada = new Lampada(60, 220);

        Console.WriteLine("Estado inicial:");
        lampada.MostrarEstado();

        lampada.Ligar();

        Console.WriteLine("Após tentar ligar:");
        lampada.MostrarEstado();
    }
<<<<<<< Updated upstream
}
=======
}
>>>>>>> Stashed changes
