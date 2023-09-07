using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            factorial objFactorial = new factorial();
            Console.Write("Ingrese un numero del cual sacar el factorial : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El factorial de {n} es {objFactorial.calculoFactorial(n)}");
        }

        public class factorial
        {
            //Metodos
            public int calculoFactorial(int n)
            {   
                if(n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * calculoFactorial(n - 1);
                }                            
            }

        }
    }
}
