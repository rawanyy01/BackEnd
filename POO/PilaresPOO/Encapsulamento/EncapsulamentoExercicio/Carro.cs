
namespace EncapsulamentoExercicio
{
    public class Carro
    {
        private string Marca;
        private string Modelo;
        private int velocidadeAtual;

        public void DefinirMarca(string valor)
        {
            Marca = valor;
        }

        public string ObterMarca()
        {
            return Marca;
        }

        public void DefinirModelo(string valor)
        {
            Modelo = valor;
        }

        public string ObterModelo()
        {
            return Modelo;
        }

        public int ObterVelocidade()
        {
            return velocidadeAtual;
        }

        public void Acelerar(int valor)
        {
            if (valor > 250)
            {
                Console.WriteLine($"Velocidade Maxima permitida eh de 250KM/H");
            }
            else
            {
                velocidadeAtual += valor;
            }
        }

        public void Frear(int valor)
        {
            if (valor < 0)
            {
                Console.WriteLine($"Velocidade Minima permitida eh de 0KM/H");
            }
            else if (valor == 0)
            {
                velocidadeAtual = 0;
                Console.WriteLine($"Carro Parado!!!");
            }
            else
            {
                velocidadeAtual -= valor;   
                if (velocidadeAtual < 0)
                    velocidadeAtual = 0;
            }
        }
    }
}
