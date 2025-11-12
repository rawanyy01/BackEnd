

namespace Heranca
{
    public class Moto : Veiculo
    {
        public int QtdRodas;

        public void SomMoto()
        {
            Console.WriteLine($"grrrr...");

        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Quantidade de rodas: {QtdRodas}");
        }

        public void Acelerar()
        {
            Console.WriteLine($"UUUU tu tu tu ");

        }
    
    }
}