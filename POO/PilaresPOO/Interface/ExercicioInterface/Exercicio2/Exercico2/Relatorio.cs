using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Relatorio : IImprimivel
    {
        public void imprimir()
        {
            Console.WriteLine($"Imprimindo a fatura");
            
        }
    }
}