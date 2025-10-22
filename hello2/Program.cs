// pedir para o usuário digitar o nome, sobrenome, idade, saldo bancario e investimentos

string nome;
string sobrenomeDoFulano;
int idade;
float saldoBancario;
float investimentos;

Console.WriteLine("olá, qul seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual seu sobrenome?");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual sua idade?");
idade = int.Parse(Console.ReadLine());//converte o texto int antes de jogsr na variavel

Console.WriteLine("Qual seu saldo bancário?");
saldoBancario = float.Parse(Console.ReadLine());

Console.WriteLine("Qual seu investimento?");
investimentos = float.Parse(Console.ReadLine());


Console.Clear(); //limpa o console
Console.WriteLine($"nome: {nome} {sobrenomeDoFulano}");
Console.WriteLine($"idade da {nome} é {idade}");
Console.WriteLine("saldo bancário: " + saldoBancario);
Console.WriteLine("investimento: " + investimentos);