

namespace Exercicio2
{
    public class Contrato : IImprimivel
    {
        public string Nome;
        public string TextoClausulas;

        public Contrato(string n, string tc)
        {
            Nome = n;
            TextoClausulas = tc;
        }

        public void imprimir()
        {
               Console.WriteLine($@"
        Nome: {Nome}
        Texto Clausula: {TextoClausulas}
        ");
            
        }
    }
}