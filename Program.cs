// Henranca - Uma classe pode pegar todos os atributos e metodos de outra classe 


////using Heranca;

//CarroEletrico carroE = new CarroEletrico();

//carroE.Marca = "Tesla";
//carroE.Bateria = 200;

//CarroCombustao carroC = new CarroCombustao();

//carroC.Marca = "Fiat";
//carroC.Combustivel = "Gasolina";

//Carro meuCarro;

//Console.WriteLine("Digite E - para Eletrico ou Digite ");

//Pessoa - Nome
// PessoaFisica - CPF(classe Filho)
// PessoaJuridica

//Funcionario func = new Funcionario();

//func.SetSalario(6000);

//Console.WriteLine(func.salario);

//-----------------------------------------------------------------------------------------------------------

//Polimorfismo so existe depois de heranca 


// Polimorfismo - Um metodo pode ter implementacao variavel 

using Heranca;

Carro carroC = new Carro();
CarroEletrico carroE = new CarroEletrico();

carroC.Modelo = "Fusca";
carroC.Marca = "Volkswagen";
carroE.Quilometragem = "3000";

carroE.Modelo = "Tesla Model S";
carroE.Marca = "Tesla";
carroE.Quilometragem = "100";
carroE.Bateria = 200;
carroE.TempoDeCarga = 50;

carroE.MostrarInformacoes("Ingryd");

//-----------------------------------------------------------------------------------------------------------

//