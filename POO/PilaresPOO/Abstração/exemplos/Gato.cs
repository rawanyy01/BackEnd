

namespace exemplos
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Miauu");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"ploc ploc ploc");
            
        }
    }
}