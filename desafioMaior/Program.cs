// pedir para o usuário digitar dois números, em seguida ver qual é o maior

int n1;
int n2;
int numeroMaior;

Console.WriteLine("Escolha o primeiro número");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escolha o segundo número");
n2 = int.Parse(Console.ReadLine());

Console.Clear();
if (n1 > n2)
{
    Console.WriteLine($"O primeiro número é o maior: {n1}");
}
else if (n2 > n1)
{
     Console.WriteLine($"O segundo número é o maior: {n2}");
} else
{
    Console.WriteLine($"Os números são iguais: {n1} e {n2} ");
}