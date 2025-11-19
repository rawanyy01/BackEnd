using Exercicio2;

Console.Clear();



List<IImprimivel> documentos = new List<IImprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.Write($@"Menu de opções: 
    1) Cadastrar Fatura
    2) Cadastrar Relatório
    3) Cadastrar Contrato
    4) LIstar Fatura
    5) LIstar Relatório
    6) LIstar Contrato
    0) Sair
    Escolha a opção:
    ");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Cadastrar fatura em desenvolvimento");

            break;
        case 2:
            Console.WriteLine($"Cadastrar relatórios em desenvolvimento");

            break;
        case 3:
            Console.WriteLine($"Cadastrar contratos em desenvolvimento");

            break;
        case 4:
            Console.WriteLine($"Listar fatura em desenvolvimento");

            break;

        case 5:
            Console.WriteLine($"Listar relatório em desenvolvimento");

            break;

        case 6:
            Console.WriteLine($"Listar contratos em desenvolvimento");

            break;

        case 0:
            Console.WriteLine($"Sair");

            break;

        default:
            Console.WriteLine($"Opção invalida");

            break;
    }


    Console.WriteLine($"Presione <Enter> para continuar");
    Console.ReadLine();


} while (opcao != 0);


void CadastrarFaturas()
{
    Console.WriteLine("Digite o nome do cliente devedor");
    string dev = Console.ReadLine();

    Console.WriteLine("Digite o nome da empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine("Digite o valor da fatura");
    float valor = float.Parse(Console.ReadLine());

    Console.WriteLine("Dias de atraso da fatura:");
    int qntAtraso = int.Parse(Console.ReadLine());

    Fatura fat = new Fatura(dev, empresa, valor, qntAtraso);
    documentos.Add(fat);

    Console.WriteLine($"Fatura cadastrada com sucesso!!!");
    

}

void CadastrarRelatorios()
{

}

void CadastrarContratos()
{

}

void ListarFaturas()
{
    Console.WriteLine($"Listaqndo faturas: ");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.imprimir();
        }
    }

}

void ListarRelatorios()
{

}

void ListarContratos()
{

}



























// Fatura fatRaw = new Fatura();
// documentos.Add(fatRaw);

// Fatura fatGu = new Fatura();
// documentos.Add(fatGu);

// Relatorio realRaw = new Relatorio();
// documentos.Add(realRaw);

// Contrato contRaw = new Contrato();
// documentos.Add(contRaw);

// foreach (var fatura in documentos)
// {
//     if (fatura is Fatura)
//     {
//         fatura.imprimir();
//     }
// }


// foreach (var relatorio in documentos)
// {
//     if (relatorio is Relatorio)
//     {
//         relatorio.imprimir();
//     }
// }

// foreach (var contrato in documentos)
// {
//      if (contrato is Contrato)
//     {
//         contrato.imprimir();
//     }
// }

