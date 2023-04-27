using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ejercicio 1
Realice un programa que ingrese los montos de ventas de los tres meses del año 2022 hasta
ahora recorridos, (enero, febrero y marzo) para dos sucursales de la empresa “La fabrica” y
ellas son:

Sucursal Parque Patricios
Sucursal Caballito

Al finalizar debe indicar la el monto total de ventas de cada sucursal y el promedio mensual de
cada mes.
También debe indicar el monto total de venta de ambas sucursales y el promedio entre
ambas.

Ejercicio 2
Modifique el ejercicio 1 para cargar n meses del año.

*/


namespace ejercitacion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sucursales = { "Parque Patricios", "Caballito" };
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Septiembre", "Octubre", "Nombiembre", "Septiembre" };
            int total1 = 0;
            int total2 = 0;
            //int nums = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Elija cuantos meses del año quiere ingresar <12");
            int mesT = Convert.ToInt32(Console.ReadLine());

            while (mesT > 12)
            {
                Console.WriteLine("Por favor un numero menor a 12");
                mesT = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Diga a que sucursal quiere ingresar ´Parque Patricios´ o ´Caballito´");
            string sucursal = Console.ReadLine();

            while (sucursales[0] != sucursal && sucursales[1] != sucursal) {

                Console.WriteLine("Por favor ingrese una de las opciones validas ´Parque Patricios´ o ´Caballito´");
                sucursal = Console.ReadLine();
            }
            
            if (sucursales[0] == sucursal)
            {
                int[] socur1 = new int[12];
                for (int i = 0; i <= mesT-1; i++)
                {
                    //Console.WriteLine(meses[i]);
                    Console.WriteLine("Escriba el monto de ventas de " + meses[i]+" a continuacion");
                    socur1[i] = Convert.ToInt32(Console.ReadLine());
                    total1 += socur1[i];
                }
                //Console.WriteLine(total1);    
                Console.WriteLine("Ahora ingrese el monto de Caballito");

                int[] socur2 = new int[12];
                for (int j = 0; j <= mesT - 1; j++)
                {
                    //Console.WriteLine(meses[j]);

                    Console.WriteLine("Escriba el monto de ventas de " + meses[j] + " a continuacion");
                    socur2[j] = Convert.ToInt32(Console.ReadLine());
                    total2 += socur2[j];
                }
            }
            else if (sucursales[1] == sucursal)
            {
                int[] socur2 = new int[12];
                for (int j = 0; j <= mesT - 1; j++)
                {
                    //Console.WriteLine(meses[j]);

                    Console.WriteLine("Escriba el monto de ventas de " + meses[j] + " a continuacion");
                    socur2[j] = Convert.ToInt32(Console.ReadLine());
                    total2 += socur2[j];
                }

                Console.WriteLine("Ahora ingrese el monto de Parque Patricios");

                int[] socur1 = new int[12];
                for (int i = 0; i <= mesT - 1; i++)
                {
                    //Console.WriteLine(meses[i]);
                    Console.WriteLine("Escriba el monto de ventas de " + meses[i] + " a continuacion");
                    socur1[i] = Convert.ToInt32(Console.ReadLine());
                    total1 += socur1[i];
                }
            }
            Console.WriteLine("El monto total de la socursal de " + sucursales[0] + " es de : " + total1 + " con un promedio de : " + total1 / 3);
            Console.WriteLine("El monto total de la socursal de " + sucursales[1] + " es de : " + total2 + " con un promedio de : " + total2 / 3);
            Console.WriteLine("El total entre ambas socursales es : "+(total1+total2)+" y con un promedio de : " + (total1 + total2)/2);
        
        }
    }
}
