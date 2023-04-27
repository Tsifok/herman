using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* EJERCICIO 1
            
            Console.WriteLine("Ingrese el numero de veces que quiere repetir el ciclo : ");
            int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("El numero inigresado es "+n);
            int acumulador = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Ingrese el numero : ");
                int numeros = Convert.ToInt32(Console.ReadLine());
                acumulador += numeros;
            }

            Console.WriteLine("La cantidad de numeros ingresados fueron "+n+" y el promedio es "+acumulador/n);
            */
            // EJERCICIO 2

            Console.WriteLine("Ingrese primera cifra (dividendo)");
            int nums = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese primera cifra (divisor distinto de cero)");
            int nums1 = Convert.ToInt32(Console.ReadLine());

            while (nums1 == 0) {
            Console.WriteLine("Error, el valor debe ser distinto de cero, por favor ingrese divisor : ");
            nums1 = Convert.ToInt32(Console.ReadLine());
            }


            double divicion = (nums/nums1);

            Console.WriteLine("la divicion a dado como resultado = "+divicion);

        }
    }
}
