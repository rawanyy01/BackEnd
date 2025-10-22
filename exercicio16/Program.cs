// int idade;

// Console.WriteLine("qual sua idade?");
// idade = int.Parse(Console.ReadLine());

// Console.Clear();

// if (idade >= 18)
// {
//     Console.WriteLine($" {idade} Maior de idade");
// }

// else
// {
//     Console.WriteLine($" {idade} Menor de idade");
// }




string cargo;
double salario, novoSalario;

Console.WriteLine("Qual seu cargo? Produção, Administrativo ou Diretoria");
cargo = Console.ReadLine();

Console.WriteLine("Qual seu salário?");
salario = float.Parse(Console.ReadLine());

if (cargo == "produção")
{
    novoSalario = salario + (salario * 0.065);
}

else if (cargo == "admniistrativo")
{
    novoSalario = salario + (salario * 0.065);
}

else if (cargo == "diretoria")
{
    novoSalario = salario + (salario * 0.12);
}

else
{
    Console.WriteLine("Cargo invalido");
}

Console.WriteLine($" o novo salario é {salario}");
