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