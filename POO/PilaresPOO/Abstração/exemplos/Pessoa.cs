
namespace exemplos
{
    public class Pessoa : Animal
    {
        public string nome;

        public int idade;


        public void Dormir()
        {
            Console.WriteLine($"ZZZZZZZZZZZZZZ!!!");
        }

        public override void FazerSom()
        {
            Console.WriteLine($"Amo minha namorada raw");
        }

        public override void Mover()
        {
            Console.WriteLine($"Toc, Toc, Toc");
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
        }
    }
}