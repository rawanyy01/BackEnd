int qntLetras;

Console.WriteLine($"Quantas letras tem seu nome?");
qntLetras = int.Parse(Console.ReadLine());
string nome = "";

for (int i = 1; i <= qntLetras; i++)
{
    Console.WriteLine($"Qual é a {i}ª letra?");
    nome = nome + Console.ReadLine();
}

Console.WriteLine($"Seu nome é {nome}");