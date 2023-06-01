using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio5.Program;

namespace Ejercicio5
{
/*
    Ejercicio 1
    Desarrolle una clase para la carga de información de personas contemplando los atributos
    nombre, apellido y edad.
    Instancie la clase y permita que el usuario cargue información para 3 persona mostrando la
    misma con un método de la clase.
    Al finalizar muestre el promedio de edad.
    El gordo trolo de proyecto me come los huevos 
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
            int promEdad = 0;
            //ejercicio 1            
            // Creo cantidad de objetos que deseo 
            Console.WriteLine("Ingrese cuantos personas quiere ingresar");
            int cantPers = Convert.ToInt32(Console.ReadLine());
            // Inicializo la cantidad de objetos
            personas[] objPersona = new personas[cantPers];
            for (int i = 0; i < cantPers; i++) objPersona[i] = new personas();
            // Ingreso los datos 
            for (int i = 0; i < cantPers; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona "+(i+1));
                objPersona[i].nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido de la persona " + (i + 1));
                objPersona[i].apellido = Console.ReadLine();
                Console.WriteLine("Ingrese la edad");
                objPersona[i].edad = Convert.ToInt32(Console.ReadLine());
            }
            // Promedio de edad
            for (int i = 0;i < cantPers; i++) 
            {
                objPersona[i].mostrarDatos();
                promEdad += objPersona[i].edad;             
            }
            Console.WriteLine("El promedio de edad es de : " + promEdad/cantPers + " años");

        }
        //ejercicio 1
        public class personas 
        { 
            //constructor
            public personas() { }

            //atributos
            public string nombre;
            public string apellido;
            public int edad;

            //metodos
            public void mostrarDatos()
            {
                Console.WriteLine("{0} {1} tiene {2} años", nombre, apellido, edad);
            }
        }
    }
}
