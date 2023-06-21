using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
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
            bool bandera = true;

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
                Console.Write("Ingrese el numero de sucursal (1 - 4) : ");
                do
                {
                    sucursales = FuncionNumeroI();                    
                    if (sucursales < 1 && sucursales != 100  || sucursales > 4 && sucursales != 100) Console.Write("Ingrese un numero entre 1 y 4 : ");
                    if (sucursales == 100) Console.Write("Ingrese un numero de sucursal que no hayas ingresado antes : ");

                    for (int j = 0; j < objSucursales.Length; j++)
                    {
                        if (objSucursales[j].numSucursal == sucursales)
                        {
                            Console.Write($"Ya se han ingresado datos a la sucursal a la que quiere ingresar ¿ Desea editarla ? {Environment.NewLine}SI para continuar : ");
                            // .Ecuals es para comparar cadenas 
                            // StringComparison.OrdinalIgnoreCase para evitar que cuando se iguela los string Min = May no haya problemas 
                            // Break termina la secuencia siguinte 
                            if ( (Console.ReadLine()).Equals("SI", StringComparison.OrdinalIgnoreCase) ) { break; }
                            else
                            {
                                Console.Write("Por favor ingrese otro número : ");
                                sucursales = 100;
                            }                                                        
                        }
                    }
                }while (sucursales < 1 || sucursales > 4);
                
                // cargo el numero ingresado al obj.atrib
                objSucursales[i].numSucursal = sucursales;
                // dependiendo del numero de sucursal es el nombre de esta 
                switch (sucursales)
                {
                    case 1:
                        objSucursales[i].nombreSucursal = "Once";
                    break;
                    case 2:
                        objSucursales[i].nombreSucursal = "San Nicolas";
                    break;
                    case 3:
                        objSucursales[i].nombreSucursal = "Almagro";
                    break;
                    case 4:
                        objSucursales[i].nombreSucursal = "Microcentro";
                    break;
                }

                Console.Write($"Ingrese el monto de venta de la socursal de {objSucursales[i].nombreSucursal} : ");
                objSucursales[i].montoVenta = FuncionNumeroI();
                Console.Write("Ingrese el numero de clinetes que tuvo esta sucursal durante este mes : ");
                objSucursales[i].cantClientes = FuncionNumeroI();

                do
                {
                    if (!bandera)
                    {
                        Console.WriteLine("Ingrese un numero distinto de 0");
                    }
                    Console.Write("Ahora ingrese el numero de empleados de esta sucursal : ");
                    objSucursales[i].cantEmpleados = FuncionNumeroI();
                    bandera = (objSucursales[i].cantEmpleados == 0) ? false : true;
                } while (!bandera);
                // defino el espacio del array que contendra los nombres 
                objSucursales[i].definirArreglo(objSucursales[i].cantEmpleados);

                Console.Write($"Ahora por favor, ingrese el nombre de cada uno de los empleados : {Environment.NewLine}");                
                do
                {
                    for (int j = 0; j < objSucursales[i].cantEmpleados; j++)
                    {
                        Console.Write($"Nombre de empleado : ");
                        objSucursales[i].nombreEmpleado[j] = Console.ReadLine();

                    }
                    Console.WriteLine("Si no esta conforme con el ingreso de nombres escriba a continuacion NO : ");
                    if ((Console.ReadLine()).Equals("NO", StringComparison.OrdinalIgnoreCase))
                    {
                        bandera = false;
                    }
                    else
                    {
                        bandera = true;
                    }
                } while (!bandera);              
            }

            //Se empieza a mostrar los datos 
            for (int i = 0; i < objSucursales.Length; i++) 
            {

                Console.WriteLine($"{Environment.NewLine}Sucursal de {objSucursales[i].nombreSucursal} : ");
                Console.Write("Los empleados de esta sucursal son : ");
                for (int j = 0; j < objSucursales[i].cantEmpleados; j++)
                {
                    Console.Write($"{Environment.NewLine} \t {objSucursales[i].nombreEmpleado[j]}");
                }
                
            }
            objSucursales[0].calcPromVentas(objSucursales);
            objSucursales[0].ventaMax(objSucursales);
            objSucursales[0].ventaMin(objSucursales);
            objSucursales[0].calcPromEmpleados(objSucursales);
            objSucursales[0].calcVentaTotal(objSucursales);
            Console.ReadLine();
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
        public sucursales() { }
        
        //atributos
        public string nombreSucursal;
        public int numSucursal;
        public int montoVenta;
        public int cantEmpleados;
        public int cantClientes;
        public string[] nombreEmpleado;
        
        //metodos
        public void calcPromVentas(sucursales[] objSucursales)
        {
            int lim = 4;
            int sum = 0;
            float prom = 0;

            // calculo del promedio de ventas
            for (int i = 0; i < lim; i++)
{
                sum = sum + objSucursales[i].montoVenta;
            }
            prom = sum / lim;
      
            Console.Write($"{Environment.NewLine}");
            Console.Write("El promedio de ventas es de {0} ventas.",prom);


        }
        public void calcPromEmpleados(sucursales[] objSucursales)
        {
            int lim = 4;
            int sum = 0;
            float prom = 0;

            // calculo del promedio de empleados
            for (int i = 0; i < lim; i++)
            {
                sum = sum + objSucursales[i].cantEmpleados;
            }
            prom = sum / lim;

            Console.Write($"{Environment.NewLine}");
            Console.Write("El promedio de empleados es de {0} empleados.", prom);

        }
        public void calcVentaTotal(sucursales[] objSucursales)
        {
            int sum = 0;
            int lim = 4;

            // calculo la venta total
            for (int i = 0; i < lim; i++)
            {
                sum = sum + objSucursales[i].montoVenta;
            }
 
            Console.Write($"{Environment.NewLine}");
            Console.Write("La suma total de las ventas es de {0} ventas.", sum);
        }
        public void ventaMax(sucursales[] objSucursales)
        {
            int comp = objSucursales[0].montoVenta;
            string nomb = objSucursales[0].nombreSucursal;
            int lim = 4;

            for (int i = 0; i < lim; i++)
            {
                if(objSucursales[i].montoVenta  > comp)
                {
                    comp = objSucursales[i].montoVenta;
                    nomb = objSucursales[i].nombreSucursal;
                }
            }

            Console.Write($"{Environment.NewLine}El monto maximo es de {comp} y le pertenece a la sucursal de {nomb}");
        }
        public void ventaMin(sucursales[] objSucursales)
        {
            int comp = objSucursales[0].montoVenta;
            string nomb = objSucursales[0].nombreSucursal;
            int lim = 4;

            for (int i = 0; i < lim; i++)
            {
                if (objSucursales[i].montoVenta < comp)
                {
                    comp = objSucursales[i].montoVenta;
                    nomb = objSucursales[i].nombreSucursal;
                }
            }

            Console.Write($"{Environment.NewLine}El monto minimo es de {comp} y le pertenece a la sucursal de {nomb}");
        }
        public void definirArreglo(int cant)
        {
            nombreEmpleado = new string[cant];
        }

    }    
}
