int qntUsuario = 0;
int contador = 1;

Console.WriteLine($"Qual a quantidade de vezes que voce quer digitar?");
qntUsuario = int.Parse(Console.ReadLine());

while (contador <= qntUsuario)
{
    Console.WriteLine($"digite um número");
    int batata = int.Parse(Console.ReadLine());
    if (batata % 2 == 0)
    {
        Console.WriteLine($"número digitado é par: {batata}");
    }
    contador++;
}
