
using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{
    public class Calculator
    {
        public double Numero1;
        public double Numero2;
        public double resultado;

        public double Somar()
        {
            resultado = Numero1 + Numero2;
            
            return resultado;
        }

        public double Subtrair()
        {
            resultado = Numero1 - Numero2;
            
            return resultado;
        }

        public double Multiplicar()
        {
            resultado = Numero1 * Numero2;
            
             return resultado; 
        }
        
        public double Dividir()
        {
           if (Numero2 == 0)
           {
                Console.WriteLine($"Nao existe divisao por 0");
                return -1;
            
           }
           
           
           
            resultado = Numero1 / Numero2;
          
             return resultado;
        }

        
    }
}