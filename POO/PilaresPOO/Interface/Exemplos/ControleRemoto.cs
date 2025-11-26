

namespace Exemplos
{
    public class ControleRemoto : IControle
    {

        public int NivelVolume = 0;
        public int VolumeMaximo = 30;



        public void AumentarVolume()
        {

            if (NivelVolume == VolumeMaximo)
            {
                Console.WriteLine($"Volume máximo atingindo {NivelVolume}");
                return;
            }

            NivelVolume++;
            Console.WriteLine($"Volume: {NivelVolume}");
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando a tv");

        }

        public void DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
                Console.WriteLine($"Volume ja está no mínimo: {NivelVolume}");
                return;
            }

            NivelVolume--;
            Console.WriteLine($"Volume: {NivelVolume}");

        }

        public void Ligar()
        {
            Console.WriteLine($"Ligndo tv");

        }
    }
}