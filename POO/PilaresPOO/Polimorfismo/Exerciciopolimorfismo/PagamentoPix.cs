

namespace Exerciciopolimorfismo
{

    public class PagamentoPix : Pagamento
    {
        private float Desconto = 5;
        public float ValorCompra;
        public override float CalcularTotal()
        {
            float ValorDesconto = ValorCompra / 100 * Desconto;
            return ValorCompra = ValorCompra - ValorDesconto;
        }
    }
}