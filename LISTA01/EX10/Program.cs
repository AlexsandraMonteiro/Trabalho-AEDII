/*Calcule o retorno de um investimento financeiro fazendo as contas mês a mês, sem usar a
fórmula de juros compostos. O usuário deve informar quanto será investido por mês e
qual será a taxa de juros mensal. O programa deve informar o saldo do investimento após
um ano (soma das aplicações mês a mês considerando os juros compostos), e perguntar ao
usuário se ele deseja que seja calculado o ano seguinte, sucessivamente. Por exemplo,
caso o usuário deseje investir R$ 100,00 por mês, e tenha uma taxa de juros de 1% ao mês,
o programa forneceria a seguinte saída:
Saldo do investimento após 1 ano: 1280.9328043328942
Deseja processar mais um ano? (S/N)*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //declarando variáveis 
        double investimento, juros, saldo = 0;
        string resposta = "S";
        int mes = 1;
        //pedidndo entradas
        Console.WriteLine("Informe o valor que será investido por mês:");
        investimento = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a taxa de juros mensal:");
        juros = double.Parse(Console.ReadLine()) / 100;
        //while para confirmar se o usuario quer continuar
        while(resposta == "S")
        {
         while (mes <= 12)   
         {
             saldo = (saldo + investimento) * (1 + juros);
             mes++;
         }
         Console.WriteLine($"Saldo depois de 1 ano: {saldo:F2}");
         Console.WriteLine("Deseja calcular mais um ano ? (S/N):");
         resposta = Console.ReadLine();
        }
         Console.WriteLine("Programa encerrado.");
    }
}
