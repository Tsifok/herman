using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class functions
    {

        public static int FuncionNumeroI()
        {
            bool resultado;
            int salida;
            do
            {
                string entrada = Console.ReadLine();
                resultado = int.TryParse(entrada, out salida);
                if (!resultado) Console.Write($"Ingrese un numero ENTERO : ");

            } while (!resultado);

            return salida;
        }
    }
}
