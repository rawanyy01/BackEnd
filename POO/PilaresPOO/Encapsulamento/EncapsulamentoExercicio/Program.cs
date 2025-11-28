using EncapsulamentoExercicio;

Console.Clear();
Carro carroRaw = new Carro();
carroRaw.DefinirMarca("Mazda");
carroRaw.ObterMarca();
carroRaw.DefinirModelo("RX7");
carroRaw.ObterModelo();
carroRaw.ObterVelocidade();
carroRaw.Acelerar(100);
carroRaw.Frear(0);

Console.WriteLine($"");

Console.WriteLine($"Marca do Carro: {carroRaw.ObterMarca()}");
Console.WriteLine($"Modelo do Carro: {carroRaw.ObterModelo()}");
Console.WriteLine($"Velocidade Atual: {carroRaw.ObterVelocidade()}");