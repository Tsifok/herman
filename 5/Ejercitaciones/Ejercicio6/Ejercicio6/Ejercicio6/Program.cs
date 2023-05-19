using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
Ejercicio 1
Desarrolle un código que permita ingresar datos de n personas y dichos datos son:
Nombre, Apellido, Edad.
Al finalizar la carga de información, (datos), debe mostrar:
el listado de las personas ingresadas
el promedio de edades
la edad maxima/min

Los datos de las personas deben almacenarse en arreglos unidimensionales con un único tipo de dato
*/

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //null-coalescing            
            //Environment.NewLine
            bool intentar = false;
            int cant_per;
            float avg_age;
            int max_age;
            int min_age;

            Console.WriteLine("Ingrese a cuantas personas quieres ingresar");
            do
            {
                string nums = Console.ReadLine();
                intentar = int.TryParse(nums, out cant_per);
                Console.WriteLine(!intentar ? "Ingrese un numero entero valido de cuantas personas quiere ingresar" : "");               
                
            } while(!intentar);
            
            string[] nombres = new string[cant_per];
            string[] apellidos = new string[cant_per];
            int[] edades = new int[cant_per];

            for(int i = 0; i < cant_per; i++){

                Console.WriteLine(Environment.NewLine + "Ingrese el nombre del usuario {0}", i);
                nombres[i] = Console.ReadLine();                
                Console.WriteLine(Environment.NewLine + "Ingrese el apellido del usuario {0}", i);
                apellidos[i] = Console.ReadLine();
                Console.WriteLine(Environment.NewLine + "Ingrese la edad del usuario {0}", i);
                edades[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int i in edades) {
                avg_age += i;
            }
        }
    }
}
