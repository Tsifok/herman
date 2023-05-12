using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4
{
    internal class Program
    {
        class constante
        {
            public const string color = "Blanco";
            public const string consumo = "F";
            public const double preciobase = 100;
            public const double peso = 5;
        

        }
        class Electrodomesticos
        {
            string color;
            string consumo;
            double preciob;
            double peso;

            public string Color
            {
                get
                {
                    return color;
                }
            }

            public string Consumo
            {
                get
                {
                    return consumo;
                }
            }

            public Double Preciob
            {
                get
                {
                    return preciob;
                }
            }

            public Double Peso
            {
                get
                {
                    return peso;
                }
            }

            public Electrodomesticos(string color , string consumo , double preciob , double peso)
            {
                this.color = color;
                this.consumo = consumo;
                this.preciob = preciob; 
                this.peso = peso;   
            }
       
            public Electrodomesticos() {}
        }
        class Lavadora:Electrodomesticos
        {
            double carga = 5;
            public Lavadora(string color, string consumo, double preciob, double peso) :base(color,consumo,preciob,peso) { }
            public double Carga
            {
                get { return carga; }
            }
        }

        class Licuadora:Electrodomesticos
        {
            public Licuadora(string color, string consumo, double preciob, double peso) :base(color,consumo,preciob,peso) { }
        }
        static void Main(string[] args)
        {
            Electrodomesticos e = new Electrodomesticos("Blanco", "F" , 100 , 5);

            Console.WriteLine("{0} {1} {2}€  {3}kg", e.Color , e.Consumo , e.Preciob , e.Peso);
            Console.ReadKey();

        }
    }
}
//Crearemos una superclase llamada Electrodoméstico con las siguientes características:
//Sus atributos son precio base, color, consumo energético (letras entre A y F) y peso. Indica que se podrán heredar.
//Por defecto, el color será blanco, el consumo energético será F, el precioBase es de 100 € y el peso de 5 kg. Usa constantes para ello.
//Los colores disponibles son blanco, negro, rojo, azul y gris. No importa si el nombre está en mayúsculas o en minúsculas.
//Los constructores que se implementarán serán
//Un constructor por defecto.
//Un constructor con el precio y peso. El resto por defecto.
//Un constructor con todos los atributos.

//Los métodos que implementara serán:
//Métodos get de todos los atributos.
//comprobarConsumoEnergetico(char letra): comprueba que la letra es correcta, sino es correcta usará la letra por defecto. Se invocará al crear el objeto y no será visible.
//comprobarColor(String color): comprueba que el color es correcto, sino lo es usa el color por defecto. Se invocará al crear el objeto y no será visible.
//precioFinal(): según el consumo energético, aumentará su precio, y según su tamaño, también. Esta es la lista de precios:

//Crearemos una subclase llamada Lavadora con las siguientes características:
//Su atributo es carga, además de los atributos heredados.
//Por defecto, la carga es de 5 kg. Usa una constante para ello.
//Los constructores que se implementarán serán:
//Un constructor por defecto.
//Un constructor con el precio y peso. El resto por defecto.
//Un constructor con la carga y el resto de atributos heredados. Recuerda que debes llamar al constructor de la clase padre.
//Los métodos que se implementara serán:
//Método get de carga.
//precioFinal():, si tiene una carga mayor de 30 kg, aumentará el precio 50 €, sino es así no se incrementará el precio. Llama al método padre y añade el código necesario. Recuerda que las condiciones que hemos visto en la clase Electrodoméstico también deben afectar al precio.

//Crearemos una subclase llamada Televisión con las siguientes características:
//Sus atributos son resolución (en pulgadas) y sintonizador TDT (booleano), además de los atributos heredados.
//Por defecto, la resolución será de 20 pulgadas y el sintonizador será false.
//Los constructores que se implementarán serán:
//Un constructor por defecto.
//Un constructor con el precio y peso. El resto por defecto.
//Un constructor con la resolución, sintonizador TDT y el resto de atributos heredados. Recuerda que debes llamar al constructor de la clase padre.
//Los métodos que se implementara serán:
//Método get de resolución y sintonizador TDT.
//precioFinal(): si tiene una resolución mayor de 40 pulgadas, se incrementará el precio un 30% y si tiene un sintonizador TDT incorporado, aumentará 50 €. Recuerda que las condiciones que hemos visto en la clase Electrodoméstico también deben afectar al precio.
//Ahora crea una clase ejecutable que realice lo siguiente:

//Crea un array de electrodomésticos de 10 posiciones.
//Asigna a cada posición un objeto de las clases anteriores con los valores que desees.
//Ahora, recorre este array y ejecuta el método precioFinal().
//Deberás mostrar el precio de cada clase, es decir, el precio de todas las televisiones por un lado, el de las lavadoras por otro y la suma de los electrodomésticos (puedes crear objetos Electrodomésticos, pero recuerda que Televisión y Lavadora también son electrodomésticos). Recuerda el uso operador instanceof.
//Por ejemplo, si tenemos un electrodoméstico con un precio final de 300, una lavadora de 200 y una televisión de 500, el resultado final será de 1000 (300+200+500) para electrodomésticos, 200 para lavadora y 500 para televisión.
