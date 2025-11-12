using ClasseEObjetos;
using ClassesEObjetos;
// Garrafa stanley = new Garrafa();


// Console.Clear();
// Console.WriteLine($"== Agencia bancária ==");
// Console.WriteLine();

// AgenciaBancaria contaDoJoao = new AgenciaBancaria();

// contaDoJoao.Titular = "Rawany";
// contaDoJoao.Saldo = 1000.50f;

// contaDoJoao.Depositar(-500);

// contaDoJoao.Sacar(1500);

Console.Clear();
ProdutoComDesconto panela = new ProdutoComDesconto();
panela.Nome = "Panela de Pressao Tramontina";
panela.Preco = 100;

Console.WriteLine($"{panela.Nome} custa R${panela.Preco}");

panela.AplicarDesconto(51);
