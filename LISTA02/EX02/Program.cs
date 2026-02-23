/* Questão 2) Um sistema solar pode ser descrito como um conjunto de corpos planetários que circundam uma ou mais estrelas.
Wikipedia, 2022

Crie uma classe chamada CorpoCeleste (massa, densidade, posiçãoX, posiçãoY). Após a criação da classe, crie um programa que preencha os dados de 10 CorposCelestes e ao final do processo, liste na tela o corpo de maior massa, o de maior raio e os dois mais distantes entre si (considerando o eixo X). O código deve fazer uso das boas práticas de Programação Orientada a Objetos, criando os métodos adequados e fazendo uso de encapsulamento.

Obs.: Lembre-se de que o raio do corpo é calculado a partir da massa e da densidade.
*/
using System;

public class CorpoCeleste
{
    private double massa;
    private double densidade;
    private double posx;
    private double posy;

    public CorpoCeleste()
    {
    }
    public CorpoCeleste(double massa, double densidade, double posx, double posy)
    {
        //this para diferenciar o atributo da classe do parâmetro recebido
        this.massa = massa;
        this.densidade = densidade;
        this.posx = posx;
        this.posy = posy;
    }

    public double Massa
    {
        get { return massa; }
        //sem set porque os atributos do corpo celeste são definidos no momento da
        //criação do objeto e não precisam ser alterados depois.
    }

    public double PosicaoX
    {
        get { return posx; }
    }

    public double PosicaoY
    {
        get { return posy; }
    }
    private double CalcularRaio()
    {
        double volume = massa / densidade;
        return Math.Pow((3 * volume) / (4 * Math.PI), 1.0 / 3.0);
    }

    // Propriedade pública que usa o método privado
    public double Raio
    {
        get { return CalcularRaio(); }
    }
    //calcular a distância no eixo X entre dois corpos
    public double DistanciaX(CorpoCeleste outro)
    {
        return Math.Abs(this.posx - outro.posy); //Math.Abs garante que a distância seja positiva
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Massa: {massa}");
        Console.WriteLine($"Densidade: {densidade}");
        Console.WriteLine($"Posição X: {posx}");
        Console.WriteLine($"Posição Y: {posy}");
        Console.WriteLine($"Raio: {Raio:F2}");
    }
}
class Program
{
    static void Main()
    {
        //vetor para armazenar corpos celestes
        CorpoCeleste[] corpos = new CorpoCeleste[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nCorpo {i + 1}");

            Console.Write("Massa: ");
            double.TryParse(Console.ReadLine(), out double massa);

            Console.Write("Densidade: ");
            double.TryParse(Console.ReadLine(), out double densidade);

            Console.Write("Posição X: ");
            double.TryParse(Console.ReadLine(), out double x);

            Console.Write("Posição Y: ");
            double.TryParse(Console.ReadLine(), out double y);

            corpos[i] = new CorpoCeleste(massa, densidade, x, y);
        }
        //considera o primeiro como maior massa
        CorpoCeleste maiorMassa = corpos[0];

        //percorrer o vetor para comparar a as massas
        for (int i = 1; i < corpos.Length; i++)
        {
            if (corpos[i].Massa > maiorMassa.Massa)
                maiorMassa = corpos[i];
        }

        Console.WriteLine("\nMaior Massa:");
        maiorMassa.ExibirDados(); // exibe os dados
    }
}
