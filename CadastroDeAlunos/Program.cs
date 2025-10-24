string[] nomes = new string[3];
int[] idades = new int[3];
int totalAlunos = 0;
int opcao = -1;

do
{
    Console.WriteLine($"=== Aplicativo Sala De Aula ===");
    Console.WriteLine($"1) LIstar alunos");
    Console.WriteLine($"2) Cadastrar alunos");
    Console.WriteLine($"0) Sair");
    Console.Write($"Escolha uma opcao: ");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando");
            break;

        case 1:
            ListarAluno();
            break;

        case 2:
            CadastrarAluno();
            break;

        default:
            break;
    }

    Console.WriteLine($"Precione <Enter> para continuar");
    Console.ReadLine();

} while (opcao != 0);


void ListarAluno()
{
    Console.WriteLine($"=== LIstagem de Aluno ===");

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Nomes: {nomes[i]}");
    Console.WriteLine($"Idades: {idades[i]}");
    
}
}
void CadastrarAluno()
{
    Console.WriteLine($"=== Cadastro de Aluno ===");

    if (totalAlunos >= 3)
    {
        Console.WriteLine($"limite de vagas atingidos");
        return;

    }
    Console.WriteLine($"Digite o nome do aluno");
    nomes[totalAlunos] = Console.ReadLine();

    Console.WriteLine($"Digite a idade de {nomes[totalAlunos]}");
    idades[totalAlunos] = int.Parse(Console.ReadLine());
    totalAlunos++;
    Console.WriteLine($"Aluno cadastrado com sucesso!");
    
}
