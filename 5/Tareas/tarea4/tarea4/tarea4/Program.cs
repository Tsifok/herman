using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea4
{
    /* El ejercicio ya tiene que tener una estructura predefinida para que el usuario ponga el numero de la sucursal que quiere ingresar los datos 
     y ya pueda ingresarlo, osea tiene que estar el array de objeto con el numero de la sucursal y su nombre predefinidos
     */
    internal class Program
    {
        static void Main(string[] args)
        {   
            // variables a utilizar luego
            int sucursales;

            // inicialiso el array de objs 
            sucursales[] objSucursales = new sucursales[4];
            for (int i = 0 ; i < objSucursales.Length ; i++) objSucursales[i] = new sucursales();
            
            // el siguinte for es para el ingreso de datos a los objs
            for (int i = 0 ; i < objSucursales.Length ; i++)
            {
                /*  
                    verifico que los numero de sucursales ingresados cumplan con las siguientes codiciones :
                    Que sean enteros
                    Que esten dentro del rango
                    Que no esten repetidos
                 */
                Console.WriteLine("Ingrese el numero de sucursal (1 - 4) : ");
                do
                {
                    sucursales = FuncionNumeroI();                    
                    if (sucursales < 1 && sucursales != 100  || sucursales > 4 && sucursales != 100) Console.Write("Ingrese un numero entre 1 y 4 : ");
                    if (sucursales == 100) Console.Write("Ingrese un numero de sucursal que no hayas ingresado antes : ");

                    for (int j = 0; j < objSucursales.Length; j++)
                    {
                        if (objSucursales[j].numSucursal == sucursales)
                        {                         
                            Console.Write("El número de sucursal ya ha sido ingresado, por favor ingrese otro número : ");
                            sucursales = 100;
                        }
                    }
                }while (sucursales < 1 || sucursales > 4);
                
                
                objSucursales[i].numSucursal = sucursales;






            }

        }

        // valida el tipo de dato ( que sea int )  
        public static int FuncionNumeroI()
        {
            bool resultado;
            int salida;            
            do
            {
                string entrada = Console.ReadLine();
                resultado = int.TryParse(entrada, out salida);
                if(!resultado) Console.Write($"Ingrese un numero ENTERO : ");

            } while (!resultado);
            
            return salida;
        }
    }


    public class sucursales
    {
        //constructor
        public sucursales() 
        { 
        }
        //atributos
        public string nombreSucursal;
        public int numSucursal;
        public int montoVenta;
        public int cantEmpleados;
        public int cantClientes;
        public string nombreEmpleado;
        //metodos
        public void calcPromVentas()
        {

        }
        public void calcPromEmpleados()
        {

        }
        public void calcVentaTotal()
        {

        }
        public void ventaMax()
        {

        }
        public void ventaMin()
        {

        }
    
    }    
}
