

Console.WriteLine($"Quantos numeros voce quer digitar?");
int qntNumeros = int.Parse(Console.ReadLine());
int numeroDigitado = 0;
string Pares = "pares: ";
string impares = "impares: ";

for (int i = 1; i <= qntNumeros; i++)
{
    Console.WriteLine($"Digite o {i}ª número?");
    numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    {
        Pares += numeroDigitado.ToString() + ", ";
    }

    else
    {
        impares += numeroDigitado.ToString() + ", ";
    }
}



Console.Clear();
Console.WriteLine($"Resultado:");
Console.WriteLine();
Console.WriteLine(Pares);
Console.WriteLine(impares);