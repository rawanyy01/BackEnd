using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Estoque;


        public Produto(string n, double p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: R${Preco}");
            Console.WriteLine($"Estoque: {Estoque}");
            
        }
    }
}