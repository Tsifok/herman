using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_2
{
/*
    Ejercicio 2
    Desarrolle una clase para la carga de información de lados de un rectángulo. Debe comprobar
    que los valores ingresados califiquen como rectángulo y al finalizar muestre información de la
    forma:

    “ha ingresado un rectángulo de lado1 por lado2”

    Donde los lado1 y lado2 serán las medidas de sus lados teniendo en cuenta que los cuatro
    lados no pueden ser iguales ya que en ese caso sería un cuadrado
*/


    internal class Program
    {
        static void Main(string[] args)
        {
            // Creo cantidad de objetos que deseo 
            Console.WriteLine("Ingrese cuantos rectangulos quiere ingresar");
            int cantRect = Convert.ToInt32(Console.ReadLine());            
            // Inicializo la cantidad de objetos
            rectangulos[] objRectangulo= new rectangulos[cantRect];
            for (int i = 0; i < cantRect; i++) objRectangulo[i] = new rectangulos();
            // Ingreso los datos 
            for (int i = 0; i < cantRect; i++)
            {
                Console.WriteLine("Ingrese el tamaño en cm de el lado 1 del rectangulo "+(i+1));
                objRectangulo[i].lado1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el tamaño en cm de el lado 2 del rectangulo " + (i + 1));
                objRectangulo[i].lado2 = Convert.ToInt32(Console.ReadLine());
                objRectangulo[i].ValidacionRectangulo();
            }

        }
        public class rectangulos
        {
            //constructor
            public rectangulos() { }

            //atributos
            public int lado1;
            public int lado2;

            //metodos
            public void ValidacionRectangulo()
            {
                if(lado1 == lado2)
                {
                    Console.WriteLine("Los datos ingresados con anterioridad corresponden a un cuadrado y no a un rectangulo");
                }
                else
                {
                    Console.WriteLine("ha ingresado un rectángulo de "+lado1+ " por " + lado2);
                }
            }
        }
    }
}
