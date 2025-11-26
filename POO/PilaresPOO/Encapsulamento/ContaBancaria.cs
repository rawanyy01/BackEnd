
namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }
        public ContaBancaria(float SaldoInicial)
        {
            if (Saldo > 0)
            {
                Saldo = SaldoInicial;
            }
            else
            {
                Saldo = 0;
            }
            
        }


        public void Depositar(float Valor)
        {
            if (Valor <= 0)
            {
                Console.WriteLine($"Valor invalido");

            }
            else
            {
                Saldo += Valor;
            }

        }


        public float GetSaldo()
        {
            return Saldo;
        }

        public void Sacar(float Valor)
        {
            if (Valor <= 0 && Valor <= Saldo)
            {
                Saldo -= Valor;
                Console.WriteLine($"Saque efetuado com sucesso");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente ou negativo");

            }
        }
    }
}