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

            objCurso.turno = (Console.ReadLine());
            Console.Write("Ingrese especialidad : ");
            objCurso.especialidad = (Console.ReadLine());
            Console.Write("Ingrese la cantidad de alumnos que hay en dicho Curso : ");
            int cantAlumnos = functions.FuncionIP(0,1,true);
            objCurso.resize(cantAlumnos);

            for (int i = 1; i <= cantAlumnos; i++){
                Console.Write($"Ingrese el promedio del alumno {i} : ");
                objCurso.promedios[i-1] = functions.FuncionIP(10,1);
            }



        }
    }
    // ERROR por no definir tamaño de array 
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
        public int[] promedios;

        public int mejorResultado(curso objCurso, int cantAlumns)
        {
            int val = objCurso.promedios[0];

            for (int i = 1; i >= cantAlumns; i++)
            {                
                if(val < objCurso.promedios[i])
                {
                    val = objCurso.promedios[i];
                }
            }


            return val;
        }

        public void resize(int newsize) 
        {
            promedios = new int[newsize];
        }
    }
}
