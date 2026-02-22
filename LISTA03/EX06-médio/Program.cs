/* 2) Crie uma classe Ponto, com a capacidade de armazenar a localização de ponto no plano cartesiano, de modo que ela possua três construtores:

* Um construtor sem parâmetros, que cria um ponto nas coordenadas (0,0);

* Um construtor que recebe dois parâmetros de coordenadas X e Y;

* Um construtor que inicializa o ponto através das coordenadas de um outro ponto recebido como parâmetro.
*/
using System;
class Ponto 
{
 private double x;
 private double y;
 //construtor sem parmetros
 public Ponto()
 {
     x = 0;
     y = 0;
 }
 //Construtor com parâmetros
 public Ponto(Ponto outroPonto)
 {
     this.x = outroPonto.x;
     this.y = outroPonto.y;
 }
 //contrutor que copia outro ponto
 public Ponto (double x, double y)
 {
     this.x = x;
     this.y = y;
 }
 //propriedades
 public double X
 {
     get { return x; }
     set { x = value; }
 }
 public double Y 
 {
     get { return y; }
     set { y = value; }
 }
 public void Exibir ()
 {
   Console.WriteLine($"({x}, {y})");
 }
}
class Programa
{
    static void Main(string[] args)
    {
        // Usando construtor vazio
        Ponto p1 = new Ponto();

        // Usando construtor com parâmetros
        Ponto p2 = new Ponto(5, 8);

        // Usando construtor que copia outro ponto
        Ponto p3 = new Ponto(p2);

        Console.WriteLine("Ponto 1:");
        p1.Exibir();

        Console.WriteLine("Ponto 2:");
        p2.Exibir();

        Console.WriteLine("Ponto 3 (cópia do ponto 2):");
        p3.Exibir();
    }
}
