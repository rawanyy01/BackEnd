
namespace PrimeiraClasse
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public int Altura;

        public void falar()
        {
            Console.WriteLine($"olá, eu sou {Nome}");

        }

        public void Dormir()
        {
            Console.WriteLine($"ZZzzzzz...");

        }

        public void Envelhecer(int _id = 0)
        {
            if (_id > 0)
            {// adiciona a idade que foi recebida
                Idade += _id;
            }

            else
            {// adiciona apeanas 1 ano de idade
                Idade++;
            }

        }

    }
}