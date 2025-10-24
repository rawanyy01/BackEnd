string[] nomes = new string[10];
int opcao = -1;
int totalClientes = 0;
float[] saldos = new float[10];

do
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine($"=== SISTEMA BANCÁRIO SIMPLES ===");
    Console.WriteLine();
    Console.WriteLine($"     1. Cadastrar Cliente       ");
    Console.WriteLine($"     2. Depositar               ");
    Console.WriteLine($"     3. Sacar                   ");
    Console.WriteLine($"     4. Transferir              ");
    Console.WriteLine($"     5. Listar Clientes         ");
    Console.WriteLine($"     0. Sair                    ");
    Console.WriteLine();
    Console.Write($"Escolha uma opcao: ");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($"Precione <Enter> para continuar");
    Console.ReadLine();
} while (opcao != 0);

switch (opcao)
{
    case 0:
        Console.WriteLine($"Saindo...");

        break;
    case 1:
       CadastrarCliente ();
        break;
    case 2:
        Dpositar();
        break;
    case 3:
        Sacar();
        break;
    case 4:
        Tranferir();
        break;
    case 5:
        ListarCliente();
        break;
    default:
        Console.WriteLine($"Opção invalida");
        break;
}
    
    void CadastrarCliente()
{
    Console.WriteLine($"Função Cadastrar cliente em desenvolvimento");
}
    void Dpositar()
{
    Console.WriteLine($"Função Depositar cliente em desenvolvimento");
}
    void Sacar()
{
    Console.WriteLine($"Função SacSacar cliente em desenvolvimento");
}
    void Tranferir()
{
    Console.WriteLine($"Função Transferir cliente em desenvolvimento");
}
    void ListarCliente()
{
    Console.WriteLine($"Função Listar Cliente cliente em desenvolvimento");
    for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Nomes: {nomes[i]}");
    
    
}
}
