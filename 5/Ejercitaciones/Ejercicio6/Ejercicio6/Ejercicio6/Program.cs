using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
            Console.WriteLine("Ingrese a cuantas personas quiere ingresar");
            int iteraciones = Convert.ToInt32(Console.ReadLine());
            string[] datos = new string[iteraciones*3];
            int cont = 0;
            int actual = 0;
            int age_max = 0, age_min = 0, age_avg = 0;

            for (int i = 1 ; i <= iteraciones ; i++)
            {
                for (int j = 0 ; j <= 2 ; j++)
                {
                    switch (j)
                    {
                        case 0 :
                            Console.WriteLine("Ingrese el nombre del usuario " + i);                            
                        break;

                        case 1 :
                            Console.WriteLine("Ingrese el apellido del usuario " + i);
                        break;
                        
                        case 2 :
                            Console.WriteLine("Ingrese la edad del usuario " + i);
                        break;
                    }

                    datos[i*j] = Console.ReadLine();
                }
            }

            Console.WriteLine("");
            
            foreach (var i in datos)
            {
                
                bool successfullyParsed = int.TryParse(i, out int age);
                if (successfullyParsed)
                {
                    //Console.WriteLine(age);
                    
                    if(cont == 0)
                    {
                        Console.WriteLine(datos[actual]);
                        age_max = Convert.ToInt32(datos[actual]);
                        age_min = age_max;
                        cont++;
                    }
                    /*
                    age_avg += age;
                    if(age_max<age) 
                    {
                        age_max = age;
                    }
                    if (age_max < age)
                    {
                        age_max = age;
                    }
                    */

                }
            }
            Console.WriteLine(age_max);

            
             
             
            

        }
    }
}
