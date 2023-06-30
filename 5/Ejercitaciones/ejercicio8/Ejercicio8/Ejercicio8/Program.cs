using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

    Desarrolle en un código que contenga una clase para crear un objeto y manejar información
    de un curso de la escuela técnica 26 Confederación Suiza donde cargara:
    Nombre del curso : (ejemplo: 5to 11)
    Turno
    Especialidad
    Cantidad de alumnos
    Edad de cada alumno
    Promedio general de cada alumno
 
*/

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año;
            string a;
            curso objCurso = new curso();
            // ---Nombre---
            // Año del curso
            Console.Write("Ingrese año : ");
            año = functions.FuncionIP(6,0,true);
            a = ((año).ToString()+" ");
            // Division del curso
            Console.Write("Ingrese division : ");
            año = functions.FuncionIP(15, 0, true);
            a += ((año).ToString());
            
            objCurso.division = a;
            // ---Turno---
            Console.Write($"Ingrese a que turno pertenece el curso {a} : mañana, tarde o noche ? : ");

            //functions.FuncionY();
            //archivo.nombre_dela_funcion
        }
    }

    public class curso
    {
        //Constructor
        public curso() { }

        //Atributos
        public string division;
        public string turno;
        public string especialidad;
        public int alumnos;
        public int[] edades;
    }
}
