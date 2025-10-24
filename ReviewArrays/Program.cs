
string[] nomes = new string[4];

nomes[0] = "rawany";
nomes[1] = "batita";
nomes[2] = "manoel";

Console.WriteLine($"Tamanho do Array: {nomes.Length}");


for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"   {i + 1}o Nome: {nomes[0]}");

}