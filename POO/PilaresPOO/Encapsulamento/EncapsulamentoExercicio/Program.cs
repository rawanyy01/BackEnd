using EncapsulamentoExercicio;

Console.Clear();
Carro carroGu = new Carro();
carroGu.DefinirMarca("Mazda");
carroGu.ObterMarca();
carroGu.DefinirModelo("RX7");
carroGu.ObterModelo();
carroGu.ObterVelocidade();
carroGu.Acelerar(100);
carroGu.Frear(0);

Console.WriteLine($"");

Console.WriteLine($"Marca do Carro: {carroGu.ObterMarca()}");
Console.WriteLine($"Modelo do Carro: {carroGu.ObterModelo()}");
Console.WriteLine($"Velocidade Atual: {carroGu.ObterVelocidade()}");