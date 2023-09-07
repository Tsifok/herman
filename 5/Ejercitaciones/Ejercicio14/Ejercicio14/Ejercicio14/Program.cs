using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese a cuantos animales quiere ingresar : ");
            int lim;

            do 
            {                 
                lim = functions.FuncionNumeroI(); 
                if(lim == 0)
                {
                    Console.WriteLine("Ingrese un numero distinto de 0");
                }                       
            }while ( lim == 0 );

            animales[] objAnimales = new animales[lim];
            for (int i = 0; i < lim; i++) objAnimales[i] = new animales();

            for (int i = 0; i <= lim-1; i++)
            {                                                
                //setear nombre
                Console.Write("Ingrese nombre : ");
                objAnimales[i].Nombre = Console.ReadLine();
                //setear edad
                Console.Write("Ingrese edad : ");
                while (objAnimales[i].setEdad(Console.ReadLine()) != 1);
                Console.Write("");
            }


        }

        public class animales {
            //constructor
            public animales() { }

            //atributos
            private string nombre;
            private int edad;

            //propiedades : a continuacion las propiedades se combinan con las exepciones para tener una carga de datos segura 
            public string Nombre
            {
                get { return nombre; }
                set {
                    try { 
                        if (!(string.IsNullOrEmpty(value)))
                        {
                            nombre = value;
                        }
                        else
                        {
                            throw new ArgumentException("El nombre no puede estar vacío");
                        }
                    }
                    catch (ArgumentException ex) 
                    {
                        Console.WriteLine("Error de datos : " + ex.Message);
                    }
                }
            }

            //metodo 

            public int setEdad(string val)
            {
                int num;
                int flag = 0;

                try
                {
                    if (!(int.TryParse(val, out num)))
                    {
                        throw new InvalidCastException("El valor ingresado no es un valor NUMERICO ENTERO. Intente otra vez");
                    }
                    else if(num <= 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        edad = num;
                        flag = 1;
                    }                            
                }
                
                catch (InvalidCastException ex)
                {
                    Console.Write("Error de conversion : " + ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.Write("Error de rango : " + ex.Message);
                }
                return flag;
            }


            public void mostrarDatos()
            {
                if(edad != 0)
                {
                    Console.WriteLine($"La edad es {edad}");
                }
                else
                {
                    Console.WriteLine("err");
                }                
            }
        }
    }
}
