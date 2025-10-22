float n1, n2, n3, n4;
float media;

Console.WriteLine("digite a primeira nota");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("digite a segunda nota");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("digite a terceira nota");
n3 = float.Parse(Console.ReadLine());

Console.WriteLine("digite a quarta nota");
n4 = float.Parse(Console.ReadLine());

Console.Clear();
media = (n1 + n2 + n3 + n4) / 4;
Console.WriteLine($"média: {media}");

if (media >= 7)
{
    Console.WriteLine("APROVADO");
}

else if (media <= 5)
{
    Console.WriteLine("RECUPERAÇÃO");
}
else
{
    Console.WriteLine("REPROVADO");
}


