using exemplos;

// Gato megui = new Gato();
// Cachorro Theodoro = new Cachorro();


Console.Clear();
// Pessoa GuilhermeAlves = new Pessoa();
// GuilhermeAlves.nome = "Guilherme Alves";
// GuilhermeAlves.idade = 16;
// GuilhermeAlves.Exibir();
// GuilhermeAlves.Dormir();
// GuilhermeAlves.FazerSom();
// GuilhermeAlves.Mover();



Console.WriteLine($"CONTA CORRENTE");
ContaCorrente cc = new ContaCorrente(10);
Console.WriteLine($"Saldo inicial da conta; R${cc.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito: R${cc.Saldo}");
cc.Sacar(10.01);
Console.WriteLine($"Saldo apos saque: R${cc.Saldo}");
Console.WriteLine();


Console.WriteLine($"CONTA POUPANÇA");
ContaPoupança cp = new ContaPoupança();
Console.WriteLine($"Saldo inicial da conta: R${cc.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito: R${cc.Saldo}");
cc.Sacar(10.01);
Console.WriteLine($"Saldo apos saque: R${cc.Saldo}");