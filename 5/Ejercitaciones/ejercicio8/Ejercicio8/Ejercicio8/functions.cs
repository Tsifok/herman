using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class functions
    {
        //Funcion para verificar que un numero es un valor entre un rango de valroes
        public static int FuncionIP(int max = 0, int min= 0, bool cero = false)
        {
            bool resultado;
            int salida;
            do
            {
                string entrada = Console.ReadLine();
                resultado = int.TryParse(entrada, out salida);
                if (!resultado)
                {
                    Console.Write("Ingrese un NUMERO entero : ");
                }
                else if(max != 0 && salida > max && resultado)
                {
                    Console.Write($"Ingrese un numero menor a {max}");
                    if (min != 0 || cero)
                    {
                        Console.Write($" y mayor {min} : ");
                    }
                    else
                    {
                        Console.Write(" : ");
                    }
                    Console.WriteLine("mayor a ");
                    resultado = false;
                }
                else if (min != 0 || cero)
                {
                    if (salida < min && resultado)
                    {                                         
                        Console.Write($"Ingrese un numero menor a {min}");
                        if (max != 0)
                        {
                            Console.Write($" y mayor a {max} : ");
                        }
                        else
                        {
                            Console.Write(" : ");
                        }
                        resultado = false;
                    }                    
                }
                
            } while (!resultado);

            return salida;
        }
    }
}
