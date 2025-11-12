

namespace Construtores
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa()
        {
            Console.WriteLine($"Objeto criado");
            
        }

        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;

        }
        
        public Pessoa(string n, int i, string xpto)
        {
            Nome = n;
            Idade = i;
            Console.WriteLine($"seu texto é: {xpto}");
            
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade{Idade}");

        }
    }
}