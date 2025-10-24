int opcao = -1;
do
{
    Console.Clear();
    Console.WriteLine($"------------------------------------");
    Console.WriteLine($"              Bem Vindo             ");
    Console.WriteLine($"                 ao                 ");
    Console.WriteLine($"            Jacareca Food           ");
    Console.WriteLine($"------------------------------------");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Escolha uma opção no menu abaixo: ");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("1- Hot Holl");
    Console.WriteLine("2- Temaky");
    Console.WriteLine("3- Sashimi");
    Console.WriteLine("4- Guioza");
    Console.WriteLine("5- Shimeji");
    Console.WriteLine("6- sair");
    Console.WriteLine();
    Console.Write("Opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");

            break;
        case 1:
            HotHoll();
            break;
        case 2:
            Temaky();
            break;
        case 3:
            Sashimi();
            break;
        case 4:
            Yakisoba();
            break;
        case 5:
            Guiaza();
            break;
        case 6:
            Shimeji();
            break;
        default:
            Console.WriteLine($"Opção invalida");
            break;
    }

    Console.WriteLine($"Digite <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void HotHoll()
{
    Console.WriteLine($"Boa escolha, ja vamos preparar seu Hot Holl!!!");
}
void Temaky()
{
    Console.WriteLine($"Boa escolha, ja vamos preparar seu Temaky!!!");
}
void Sashimi()
{
    Console.WriteLine($"Boa escolha, ja vamos preparar seu Sashimi!!!");
}
void Yakisoba()
{
    Console.WriteLine($"Boa escolha, ja vamos preparar seu Yakisoba!!!");
}
void Guiaza()
{
    Console.WriteLine($"Boa escolha, ja vamos preparar seu Guiaza!!!");
}
void Shimeji()
{
    Console.WriteLine($"Boa escolha, ja vamos preparar seu Shimeji!!!");
}
