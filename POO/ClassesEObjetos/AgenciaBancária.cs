using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseEObjetos
{
    public class AgenciaBancaria
    {
        public string Titular = "";

        public float Saldo;

        public void Depositar(float _valorSaque)
        {
            if (_valorSaque <= 0)
            {
                Console.WriteLine($"O valor do saldo deve ser maior que R$ 0");
                return;
            }

            Saldo += _valorSaque;
            Console.WriteLine($"Deposito realizado. Novo Saldo: R${Saldo}");

        }

        public void Sacar(float _valorSaque)
        {
            if (_valorSaque > 0 && _valorSaque <= Saldo)
            {
                Console.WriteLine($"Saldo Atual: {Saldo}");
                Console.WriteLine($"Nao e possivel sacar este valor solicitado, por favor insira um valor valido");
                return;
            }

            Saldo -= _valorSaque;
            Console.WriteLine($"Saque realizado Novo Saldo: {Saldo}");

        }

    }
}