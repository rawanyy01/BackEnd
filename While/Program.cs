
int contador = 1;

Console.WriteLine($"Quantas vezes quer rodar o while?");

int qntVezes = int.Parse(Console.ReadLine());

while (contador <= qntVezes)
{
    Console.WriteLine($"contador é: {contador}");
    contador++;
}