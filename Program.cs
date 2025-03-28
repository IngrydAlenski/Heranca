// Henranca - Uma classe pode pegar todos os atributos e metodos de outra classe 


using Heranca;

CarroEletrico carroE = new  CarroEletrico();

carroE.Marca = "Tesla";
carroE.Bateria = 200;

CarroCombustao carroC = new CarroCombustao();

carroC.Marca = "Fiat";
carroC.Combustivel = "Gasolina";

Carro meuCarro;

Console.WriteLine("Digite E - para Eletrico ou Digite ");

// Pessoa - Nome 
// PessoaFisica - CPF (classe Filho)
// PessoaJuridica