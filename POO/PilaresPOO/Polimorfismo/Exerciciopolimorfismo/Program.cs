using Exerciciopolimorfismo;

PagamentoPix CompraPix = new PagamentoPix();
CompraPix.ValorCompra = 15000;
float ValorPagar = CompraPix.CalcularTotal();
Console.WriteLine($"Produto: Smartphone");
Console.WriteLine($"Preço: {CompraPix.ValorCompra}");
Console.WriteLine($"Forma de pagamento: Pix");
Console.WriteLine($"Pagamento com Desconto: {ValorPagar}");
Console.WriteLine();

PagamentoCartao CompraCartao = new PagamentoCartao();
CompraCartao.ValorCompra = 50;

Console.WriteLine($"Produto: Perfume");
Console.WriteLine($"Preço: {CompraCartao.ValorCompra}");
Console.WriteLine($"Forma de pagamento: Cartão");
Console.WriteLine($"Pagamento com Acrescimo: {CompraCartao.CalcularTotal()}");
