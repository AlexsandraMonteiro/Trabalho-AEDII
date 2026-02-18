/*9. Determine a saída do seguinte programa:
public class Loop {
public static void main(String[] args) {
for (int i = 2; i <= 8; i = i + 2) {
for (int j = i; j <= 4; j++) {
for (int k = 1; k <= j; k = k + i) {
System.out.println(i + ", " + j + ", " + k);
}
}
}
}
}*/

 for (int i = 2; i <= 8; i = i + 2)
 Começa em 2 e vai até 8, acrescentando de 2 em 2.
  
 for (int j = i; j <= 4; j++) {
  j recebe i como valor de iniciação, Então j = 2, 3, 4.
  Agora para cada um desses valores executa o terceiro laço.
    
for (int k = 1; k <= 2; k = k + 2)
k = 1 → imprime
k = 3 → 3 <= 2 então ele para.
Primeiro identifiquei os valores do laço externo (i = 2, 4, 6, 8).
Depois observei que o segundo laço só executa quando i é menor ou igual a 4.
Para cada combinação válida de i e j, calculei os valores de k, lembrando que o incremento de k é feito somando o valor de i.
Quando o valor inicial de j já era maior que 4, o laço não executava, por isso não houve saída para i = 6 e i = 8.

Valores de i:
2, 2, 1
2, 3, 1
2, 3, 3
2, 4, 1
2, 4, 3
4, 4, 1
