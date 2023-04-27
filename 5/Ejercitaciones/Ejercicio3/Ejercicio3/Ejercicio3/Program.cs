using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] a;
            a = new int[10];
            a[0] = 1;
            Console.WriteLine(a[0]);
            a[1] = 2;
            Console.WriteLine(a[1]);
            */

            //Ejercicio3) 2 horas 1200 al mes , neto y bruto 14%

            Console.WriteLine("Nro de docentes a ingresar");
            int Nro = Convert.ToInt32(Console.ReadLine());
            string[] nombres = new string[Nro];
            int[] horas = new int[Nro];

            //ingresa
            for (int i = 0; i < Nro; i++)
            {
                Console.WriteLine("Ingrese su nombre");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Ahora ingrese el numero de horas catedra que hace mensualmente");
                horas[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Lee
            for (int j = 0; j < Nro; j++)
            {
                Console.WriteLine("El sueldo bruto de " + nombres[j] +" es de " + horas[j] * 1200 +" y el sueldo neto seria de " + ((horas[j] * 1200) - (horas[j] * 1200) * 13 / 100 ));
            }
        }
    }
}
