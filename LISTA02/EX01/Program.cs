/* Questão 1) Implemente a classe Veiculo, que deve representar as seguintes características:

* Quantidade de ocupantes;

* Quantidade de rodas;

* Capacidade Máxima do Tanque de Combustível (em litros);

* O nível atual do tanque de combustível em percentual;

* O consumo médio (em km/litro) de combustível do veículo;

* A quilometragem atual do veículo;

* Autonomia do veículo, que identifica a quantidade de Km que ele ainda pode percorrer sem abastecer.

-> Crie os métodos de acesso (get/set) para:
    * Acessar e alterar a quilometragem do veículo;
    * Acessar e alterar o consumo médio do veículo;

-> Implemente a classe Carro, que deve ser derivada da classe Veiculo e deve representar as seguintes características:
    * Modelo do carro;
    * Quantidade de portas.

* Crie dois construtores para a classe Carro, um default (construtor padrão) e outro completo, compreendendo todos os atributos da classe;
	
* Crie o método float Percorrer(float qtdQuilometros), que atualiza a quilometragem atual do carro, com a quantidade de quilômetros informada como parâmetro do método. O método deve retornar ao final do processo a quilometragem atual do carro.

Obs.: O limite de quilometragem do carro é de 999.999 Km. Faça os devidos tratamentos.
*/

using System;

public class Veiculo
{
    private int qtdocupante; // quantidade de ocupantes
    private int qtdrodas; // quantidade de rodas
    private double combustivelmax; //capacidade maxima de combustivel
    private double combustivelatual; // percentual do nível atual do combustível
    private double consumedio; // consumo médio de combustível do veículo
    private double kmatual; // quilometragem atual do veículo

    public Veiculo() { }

    public Veiculo(int qtdocupante, int qtdrodas, double combustivelmax,
                   double consumedio, double kmatual)
    {
        this.qtdocupante = qtdocupante;
        this.qtdrodas = qtdrodas;
        this.combustivelmax = combustivelmax;
        this.consumedio = consumedio;
        this.kmatual = kmatual;
        this.combustivelatual = combustivelmax; // inicia cheio
    }

    public int Ocupantes
    {
        get { return qtdocupante; }
        set { qtdocupante = value; }
    }

    public int Rodas
    {
        get { return qtdrodas; }
        set { qtdrodas = value; }
    }

    public double CombustivelMaximo
    {
        get { return combustivelmax; }
        set { combustivelmax = value; }
    }

    public double CombustivelAtual
    {
        get { return combustivelatual; }
        set
        {
            if (value < 0)
                combustivelatual = 0;
            else if (value > combustivelmax)
                combustivelatual = combustivelmax;
            else
                combustivelatual = value;
        }
    }

    public double Percentual()
    {
        if (combustivelmax <= 0)
            return 0;

        return (combustivelatual / combustivelmax) * 100;
    }

    public double Autonomia
    {
        get { return combustivelatual * consumedio; }
    }

    public double QuilometragemAtual
    {
        get { return kmatual; }
        set
        {
            if (value >= 0 && value <= 999999)
                kmatual = value;
        }
    }

    public double ConsumoMedio
    {
        get { return consumedio; }
        set
        {
            if (value > 0)
                consumedio = value;
        }
    }
}

public class Carro : Veiculo
{
    private string modelo;
    private int qtdportas;

    // Construtor padrão
    public Carro() : base()
    {
    }

    // Construtor completo
    public Carro(string modelo, int qtdportas,
                 int ocupantes, int rodas,
                 double capacidade, double consumo,
                 double kmAtual)
        : base(ocupantes, rodas, capacidade, consumo, kmAtual)
    {
        this.modelo = modelo;
        this.qtdportas = qtdportas;
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public int QuantidadePortas
    {
        get { return qtdportas; }
        set { qtdportas = value; }
    }

    public float Percorrer(float qtdQuilometros)
    {
        if (qtdQuilometros <= 0)
            return (float)QuilometragemAtual;

        double novaKm = QuilometragemAtual + qtdQuilometros;

        if (novaKm > 999999)
            novaKm = 999999;

        QuilometragemAtual = novaKm;

        return (float)QuilometragemAtual;
    }
}
