
namespace Exercicio2
{

    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasAtraso = 0;
        private float Juros = 0.10f;

        // CONSTRUTOR CORRETO
        public Fatura(string nomeDevedor, string nomeEmpresa, float valorFatura, int qntDiasAtraso)
        {
            Devedor = nomeDevedor;
            Credor = nomeEmpresa;
            Valor = valorFatura;
            DiasAtraso = qntDiasAtraso;
        }

        public void CalcularValorDivida()
        {
            if (DiasAtraso > 0)
            {
                Valor = Valor + DiasAtraso * Juros;
            }

            if (DiasAtraso >= 5)
            {
                Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }

        public void imprimir()
        {
            CalcularValorDivida();
            
            Console.WriteLine($@"
        Credor: {Credor}
        Devedor: {Devedor}
        Dias de atraso: {DiasAtraso}
        Juros: R${Juros * DiasAtraso}
        Valor total: {Valor}
        ");
        }
    }

}
 