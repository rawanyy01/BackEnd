using Heranca;

// Carro Fusca = new Carro();
// Veiculo Generico = new Veiculo();

Console.Clear();

// Aviao AirBus = new Aviao();
// Moto HarleyDividson = new Moto();

// AirBus.Marca = "LATAM";
// AirBus.Modelo = "AirBus";
// AirBus.Ano = 2025;
// AirBus.capacidade = 10;
// AirBus.ExibirInfo();
// AirBus.Decolar();

// HarleyDividson.Marca = "Harley Dividson";
// HarleyDividson.Modelo = "Fat Boy";
// HarleyDividson.Ano = 2025;
// HarleyDividson.QtdRodas = 10;
// HarleyDividson.ExibirInfo();
// HarleyDividson.SomMoto();

// Cachorro salcicha = new Cachorro();
// Gato Persa = new Gato();

// salcicha.Nome = "mel";
// salcicha.Raça = "salcicha";
// salcicha.Idade = 5;
// salcicha.ExibirInfo();
// salcicha.FazerSom();

// Persa.nome = "Megui";
// Persa.raça = "Persa";
// Persa.idade = 8;
// Persa.ExibirInfo();
// Persa.FazerSom();

//Console.Clear();  
// Gerente gerente = new Gerente();
// Funcionario GerenteGeneric = new Funcionario();
// Console.Clear();
// gerente.nome = "Gustavo";
// gerente.salarioBase = 2000;
// gerente.ExibirSalario();

// Console.Clear();
// Aluno aluno = new Aluno();
// Pessoa AlunoGeneric = new Pessoa();
// aluno.nome = "Gustavo";
// aluno.idade = 17;
// aluno.curso = "Desenvolvimento de Sistemas";
// aluno.ExibirInfo();

// Console.Clear();
// Professor professor = new Professor();
// Pessoa ProfessorGeneric = new Pessoa();
// professor.nome = "Eduardo";
// professor.idade = 43;
// professor.disciplina = "Area de TI";
// professor.ExibirInfo();

Console.Clear();
ContaPoupanca conta = new ContaPoupanca();
Conta contaGeneric = new Conta();
conta.numero = 11915021323f;
conta.saldoaBase = 0;
conta.ExibirInfo();
conta.Exibir();
conta.QntdDeposito = 100;
conta.Depositar();
conta.ExibirInfo2();
conta.Exibir2();
conta.QntdSacar = 50;
conta.Sacar();
conta.ExibirInfo2();
