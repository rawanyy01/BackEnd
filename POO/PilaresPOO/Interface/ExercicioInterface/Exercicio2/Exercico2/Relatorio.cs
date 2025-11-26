
namespace Exercicio2
{
    public class Relatorio : IImprimivel
    {
        public string NomeResponsavel;
        public string TextoRelatorio;


        public Relatorio(string nr, string tr)
        {
            NomeResponsavel = nr;
            TextoRelatorio = tr;
        }

        public void imprimir()
        {
            Console.WriteLine($@"
        Nome do responsavel: {NomeResponsavel}
        Texto Relatório: {TextoRelatorio}
        ");
        }
    }
}