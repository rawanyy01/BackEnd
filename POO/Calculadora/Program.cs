using Calculadora;

Console.Clear();

Calculator calc = new Calculator();

// calc.Numero1 = 50;
// calc.Numero2 = 10;

// Console.WriteLine($"Soma");
// Console.WriteLine(calc.Somar());
// Console.WriteLine();


// Console.WriteLine($"Subtrair");
// Console.WriteLine(calc.Subtrair());
// Console.WriteLine();

// Console.WriteLine($"Multiplicar");
// Console.WriteLine(calc.Multiplicar());
// Console.WriteLine();

// Console.WriteLine($"Dividir");
// Console.WriteLine(calc.Dividir());
// Console.WriteLine();

int opcao = -1;

do
{
    Console.Clear();
    Console.WriteLine($"------------------------------------");
    Console.WriteLine($"              Bem Vindo             ");
    Console.WriteLine($"                  a                 ");
    Console.WriteLine($"             Calculadora            ");
    Console.WriteLine($"------------------------------------");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Escolha uma opção abaixo: ");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("1- Somar");
    Console.WriteLine("2- Subtrair");
    Console.WriteLine("3- Multiplicar");
    Console.WriteLine("4- Dividir");
    Console.WriteLine("0- Sair");
    Console.WriteLine();
    Console.Write("Opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            
            Console.WriteLine($"o resultado da soma é: {calc.Somar()}");

            break;
        case 2:
            
            Console.WriteLine($"o resultado da subtração é: {calc.Subtrair()}");

            break;
        case 3:
           
            Console.WriteLine($"o resultado da multipicação é: {calc.Multiplicar()}");

            break;
        case 4:
            
            Console.WriteLine($"o resultado da divisão é: {calc.Dividir()}");

            break;

        case 0:
            Console.WriteLine($"Obg por utilixar o programa: Saindo...");

            break;

        default:
            Console.WriteLine($"opcao invalida");

            break;

    }

    Console.WriteLine($"Digite <ENTER> para sair");
    Console.WriteLine();
    



} while (opcao != 0);

