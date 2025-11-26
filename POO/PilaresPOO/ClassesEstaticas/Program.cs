using ClassesEstaticas;

Console.Clear();



Console.WriteLine($"Digite o primeiro numero: ");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero: ");
float n2 = float.Parse(Console.ReadLine());

float Maior = Math.Max(n1, n2);
float Menor = Math.Min(n1, n2);

Console.WriteLine($"==== Resultado ====");
Console.WriteLine($"O numero maior é {Maior}");
Console.WriteLine($"O numero menor é {Menor}");


// Console.WriteLine($"Multiplicar: {CalculosMatematicos.Multiplicar(n1, n2)}");
// Console.WriteLine($"Dividir: {CalculosMatematicos.Dividir(n1, n2)}");






// Console.WriteLine($"Soma de 5 e 10: {CalculosMatematicos.Somar(5, 10)}");

// Console.WriteLine($"Subtração de 20 e 10: {CalculosMatematicos.Subtrair(20, 10)}");

// Console.WriteLine($"Multiplicaçao de 5 e 10: {CalculosMatematicos.Multiplicar(5, 10)}");

// Console.WriteLine($"Divisão de 10 e 0: {CalculosMatematicos.Dividir(10, 0)}");

