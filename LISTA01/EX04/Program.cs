/* 4. Para	 cada	 produto	 informado	 (nome,	 preço	 e	 quantidade),	 escreva	 o	 nome	 do	 produto	
comprado	 e	 o	 valor	 total	 a	 ser	 pago,	 considerando	 que	 são	 oferecidos	 descontos	 pelo	
número	de	unidades	compradas,	segundo	a	tabela	abaixo:	
a. Até	10	unidades: valor	total
b. de	11 a	20	unidades: 10%	de	desconto
c. de	21	a	50	unidades: 20%	de	desconto
d. acima	de	50	unidades: 25%	de	desconto
*/

using Microsoft.VisualBasic;
using System;

public class EX04()
{
    public static void Main()
    {

        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade comprada: ");
        int quantidade = int.Parse(Console.ReadLine());

        double valorTotal = preco * quantidade;
        double desconto = 0;

        if (quantidade > 50)
        {
            desconto = valorTotal * 0.25;
        }
        else if (quantidade >= 21)
        {
            desconto = valorTotal * 0.20;
        }
        else if (quantidade >= 11)
        {
            desconto = valorTotal * 0.10;
        }

        double valorFinal = valorTotal - desconto;

        Console.WriteLine($"Produto: {nome}");
        Console.WriteLine($"Valor total a pagar: R$ {valorFinal:F2}");
    }
}