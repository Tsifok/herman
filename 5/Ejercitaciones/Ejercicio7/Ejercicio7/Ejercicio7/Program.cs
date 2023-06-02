using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    /*
    Ejercicio 1
    Desarrolle en un código que contenga una clase para crear un objeto y manejar información
    de Zooógicos donde cargara el nombre del lugar, la dirección y la provincia donde reside.
    Luego, utilizando arreglos, y por fuera de la clase cargar la información de los animales donde
    volcara nombre, color, peso y edad.
    Al finalizar la carga debe mostrar los datos del Zooógico y luego los datos de los animales
    ingresados, y al final debe informar:
    Peso promedio de los animales
    El peso mayor
    El peso menor
    Promedio de edades de los animales
    La edad mayor
    La edad menor
*/


    internal class Program
    {
        static void Main(string[] args)
        {

            const int NOMBRE = 0;
            const int COLOR = 1;
            const int PESO = 2;
            const int EDAD = 3;
            const int ZOO_ID = 4;

            // $ para meter variables dentro del string usando {}
            //Console.WriteLine($"hola{Environment.NewLine}");

            Console.WriteLine("Ingrese la cantidad de zooógico que quieras ingresar : ");
            int cant = Convert.ToInt32(Console.ReadLine()); 
            Zoo[] objZoo = new Zoo [cant];
            //Console.WriteLine(objZoo.Length);
            for (int i = 0; i < objZoo.Length; i++) objZoo[i] = new Zoo ();

            for (int i = 0;i < objZoo.Length; i++) {
                Console.WriteLine($"Zoo Nro {i+1}{Environment.NewLine}Ingrese el nombre del zooógico");
                objZoo[i].nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la direccion de zooógico");
                objZoo[i].direccion = Console.ReadLine();
                Console.WriteLine("Ingrese la provincia/estado de procedencia");
                objZoo[i].provincia = Console.ReadLine();

                Console.WriteLine("Ingrese la cantidad de animales a ingresar por : ");
                int cant_animales = Convert.ToInt32(Console.ReadLine());

                string[,] animales = new string[cant_animales, 5];

                for (int j = 0; j < cant_animales; j++)
                {
                    animales[j, ZOO_ID] = Convert.ToString(i); ;
                    Console.WriteLine($"Animal Nro {i + 1}{Environment.NewLine}Ingrese el nombre del animal");
                    animales[j, NOMBRE] = Console.ReadLine();
                    Console.WriteLine($"Ingresar el color predominante del {animales[j, 0]}");
                    animales[j, COLOR] = Console.ReadLine();
                    Console.WriteLine("Ingrese ahora su peso");
                    animales[j, PESO] = Console.ReadLine();
                    Console.WriteLine($"Finalmente ingrese la edad de {animales[j, 0]}");
                    animales[j, EDAD] = Console.ReadLine();
                }
            }





        }   
        public class Zoo {
            //CONSTRUCTOR
            public Zoo() { }

            //ATRIBUTOS
            public string nombre;
            public string direccion;
            public string provincia;


            //METODOS

        }
    }
}
