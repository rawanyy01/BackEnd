

namespace Heranca
{
    public class Gato : Animal
    {
        public string nome;
        public string raça;
        public int idade;

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {nome}, Raça: {raça} e Idade: {idade}");

        }

        public void FazerSom()
        {
            Console.WriteLine($"Miau ");

        }
    }
}