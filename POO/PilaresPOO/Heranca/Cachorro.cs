

namespace Heranca
{
    public class Cachorro : Animal
    {

        public string Nome;
        public string Raça;
        public int Idade;

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Raça: {Raça} e Idade: {Idade}");

        }

        public void FazerSom()
        {
            Console.WriteLine($"Au Au ");

        }
    }
}