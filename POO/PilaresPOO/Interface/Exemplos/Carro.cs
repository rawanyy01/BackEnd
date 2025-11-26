
namespace Exemplos
{
    public class Carro : IMotor
    {

        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;


        public Carro(string c, string m, string mod, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = mod;
            Ano = a;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($@"
Informações do veículo:
Marca: {Marca}
Modelo: {Modelo}
Cor: {Cor}
Ano: {Ano}
");
            

        }
        

        public void Acelerar()
        {
            Console.WriteLine($"Carro acelerando... Vrumm");
            
        }

        public void Freiar()
        {
            Console.WriteLine($"Carro freiando... irrrrrrrh");
            
        }
    }
}