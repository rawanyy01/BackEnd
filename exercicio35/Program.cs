


Console.WriteLine("Quantas números vc quer digitar?");
int x = int.Parse(Console.ReadLine());
int contador = 1;
int n1, n2;

while (contador <= x)
{
    Console.WriteLine("digite o primeiro numero");
    n1 = int.Parse(Console.ReadLine());

     Console.WriteLine($"digite o segundo numero");
    n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($"o numero {n1} é maior que o {n2}");
    }

    else if (n1 < n2)
    {
        Console.WriteLine($"o numero {n2} é maior que o {n1}");
    }

    else
    {
        Console.WriteLine($"o numero {n2} e {n1} são iguais");
    }

    contador++;
}

