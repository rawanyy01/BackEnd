

namespace exemplos
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Au au");
            
        }

        public override void Mover()
        {
           Console.WriteLine($"ploc ploc ploc ");
           
        }
    }
}