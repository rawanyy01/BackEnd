using Encapsulamento;

Console.Clear();

ContaBancaria contaRaw = new ContaBancaria();
ContaBancaria contaGu = new ContaBancaria(1500);

contaRaw.Depositar (-100);
contaRaw.Depositar(20);
contaRaw.Sacar(-200);
contaGu.Sacar(300);

contaRaw.Sacar(100);

Console.WriteLine($"Saldo atual: {contaRaw.GetSaldo()}");
Console.WriteLine($"Saldo atual: {contaGu.GetSaldo()}");

