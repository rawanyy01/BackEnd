double salario, totalGasto;

Console.WriteLine("Informe seu salário");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Informe seu gasto");
totalGasto = double.Parse(Console.ReadLine());

if (salario < totalGasto)
{
    Console.WriteLine("Orçamento Estourado!");
}
else
{
    Console.WriteLine("Gastos dentro do orçamento!");
}