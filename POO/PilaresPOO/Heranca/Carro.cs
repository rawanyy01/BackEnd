

namespace Heranca
{
    public class Carro : Veiculo
    {
        public int QtdPortas;

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Quntidade de portas: {QtdPortas}");
            
        }
    }
}