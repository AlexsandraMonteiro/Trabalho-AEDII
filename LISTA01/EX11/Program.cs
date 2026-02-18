/*11. Calcule a raiz quadrada aproximada de um número inteiro informado pelo usuário,
respeitando o erro máximo também informado pelo usuário. Não utilize funções
predefinidas.*/

using System;
 public class Exercicio10 
 {
  public static void Main(String[] args) 
  {
  //declarando variáveis
  float num, raiz=0, x=0, erro;
  //pedindo entrada
  Console.WriteLine("Insira um número inteiro:");
  num = float.Parse(Console.ReadLine());
  Console.WriteLine("Insira a taxa máxima de erro:");
  erro= float.Parse(Console.ReadLine());
  // se o número for 0
  if (num < 0)
  {
      Console.WriteLine("Não existe raiz real para número negativo.");
  }
  //calculando a raiz do número
  else 
  {
     while (x * x <= num)
            {
                float diferenca = num - x * x;
               // se a diferença estiver dentro do erro
                if (diferenca <= erro)  
                {
                    break;
                }
              // incrementa de 1 em 1
                x++;  
            }

   
     Console.WriteLine("Raiz aproximada: " + x);
  }
  }
}
