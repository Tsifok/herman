using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
Ejercicio 1
Desarrolle una de las clases que haya definido en la Tarea003. Luego de la definición,
corresponde instanciarla seguido de la carga de información, (dar valor a sus atributos), para un
objeto y luego mostrar dicha información.

Ejercicio 2
Modifique el ejercicio 1 del presente Ejer004 para el uso de 4 objetos.
*/

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cuantos objetos quiere ingresar");

            int cantObj = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(cantObj);
            int comparador = 1;
            for (int i = 1; i <= cantObj; i++)
            {
                
                if (comparador < i || i != cantObj){
                    Console.WriteLine("Ahora ingrese el siguinte objeto");
                    comparador  = i;
                }

                anteojos anteojo = new anteojos();
                Console.WriteLine("Ingrese el color de los antejos");
                anteojo.color = Console.ReadLine();
                Console.WriteLine("Ahora ingrese su ancho");
                anteojo.ancho = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ahora ingrese de que material lo desea");
                anteojo.material = Console.ReadLine();
                Console.WriteLine("Escriba el numero de aumento");
                anteojo.aumento = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ahora que precio tendra");
                anteojo.precio = Convert.ToInt32(Console.ReadLine());
                anteojo.mostrarDatos();
            }
            Console.ReadLine();
        }
                    
        public class anteojos 
        {
          
            //Constructor
            public anteojos() {
            }

            //atributos
            public string color;
            public int ancho;                
            public string material;
            public int aumento;
            public int precio;
                
            //metodos
            
            public void mostrarDatos()
            {
                Console.WriteLine("El anteojo es de color {0} , con un ancho de {1} , esta hecho de {2} , tiene un aumento de {3} puntos y vale {4}",color,ancho,material,aumento,precio);
            }
            
        }                
    }
}
