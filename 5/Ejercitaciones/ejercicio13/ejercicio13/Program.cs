using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            fibonacci objFibo = new fibonacci();
            Console.WriteLine("ingrese un numero entero positivo");
            objFibo.setNumero = objFibo.afirmarNumero(Console.ReadLine());
            Array.Resize(ref objFibo.valor, objFibo.mostrar());

            Console.WriteLine($"El valor fibonacci en el termino {objFibo.mostrar()} es {objFibo.serie(objFibo.mostrar())} con una sumatoria total de {objFibo.sumatoria}, con un promedio de {objFibo.promedio}. Este consta de {objFibo.impares} valores impares y de {objFibo.pares} valores pares");
        }

        public abstract class Base
        {
            //CONSTRUCTOR
            public Base() { }
            //ATRIBUTOS / PROPIEDADES
            private int numero;
            //METODOS

            public int afirmarNumero (string num){
                bool resultado;
                int salida;
                do
                {                    
                    resultado = int.TryParse(num, out salida);
                    if (!resultado)
                    {
                        Console.Write($"Ingrese un numero ENTERO : ");
                        num = Console.ReadLine();
                    }

                    if (salida == 0)
                    {
                        Console.Write($"Ingrese un numero ENTERO diferente de 0 : ");
                        num = Console.ReadLine();
                    }

                } while (!resultado || salida == 0);

                return salida;
            }

            public int mostrar()
            {
                return numero;
            }

            public int setNumero
            {
                get { return numero; }
                set { numero = value; }
            }
        }
        
        public class fibonacci : Base
        {
            //CONSTRUCTOR
            
            public fibonacci() { }

            //ATRIBUTOS

            public int[] valor;
            public int sumatoria;
            public int promedio;
            public int pares;
            public int impares;            

            //METODOS

            public int serie(int numero)
            {
                for (int i = 0; i < numero; i++)
                {
                    if (i == 0)
                    {
                        valor[0] = 0;
                    }
                    else if (i == 1)
                    {
                        valor[i] = 1;
                    }
                    else
                    {
                        valor[i] = valor[i - 1] + valor[i - 2];
                    }
                    sumatoria += valor[i];
                    promedio = sumatoria / numero;
                    if (valor[i] % 2 == 0)
                    {
                        pares++;
                    }else{
                        impares++;
                    }
                }                
                return valor[numero-1];
            }
        }
    }
}
