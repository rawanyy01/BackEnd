int numero1;
int numero2;
int resultado;

Console.WriteLine("Escolha o primeiro número");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escolha o segundo número");
numero2 = int.Parse(Console.ReadLine());

Console.Clear();
resultado = numero1 + numero2;
Console.WriteLine(" o resultado é " + resultado);
