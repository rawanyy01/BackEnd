using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplos
{
    public abstract class ContaBancaria
    {
        public abstract void Depositar(double Valor);
        public abstract void Sacar(double Valor);
    }
}