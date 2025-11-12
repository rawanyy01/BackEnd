

namespace Heranca
{
    public class Aviao : Veiculo
    {
        public int capacidade;

        public void Decolar()
        {
            Console.WriteLine($"Avião Decolando... ziuuuuuu");

        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Capacidade: {capacidade}");
        }
        
       
    }
}