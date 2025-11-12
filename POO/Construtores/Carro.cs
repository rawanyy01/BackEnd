namespace Construtores
{
    public class Carro
    {
        public string marca;
        public string Modelo;
        public int Ano;

        public Carro(string m, string n, int i)
        {
            marca = m;
            Modelo = n;
            Ano = i;

        }
        
         public void ExibirDados()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {Modelo}, Ano: {Ano}");

        }
    }
}