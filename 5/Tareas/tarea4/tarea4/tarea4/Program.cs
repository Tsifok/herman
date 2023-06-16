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
           /* int sucursales = 0;
            bool resultado;
            do
            {
                Console.WriteLine("Ingrese la cantidad de pentagonos");
                resultado = int.TryParse(Console.ReadLine(), out sucursales);
                if (!resultado) Console.WriteLine("Error, debe ingresar un numero");
            } while (!resultado);
           */
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
