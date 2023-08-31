using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hospital
            hospital objHospital = new hospital();
            objHospital.Nombre = "Roma";
            objHospital.Direccion = "Av. Jujuy 255";
            objHospital.RangoTecnologias = "medio";
            objHospital.NroCamas = 30;

            //clinica
            clinica objClinica = new clinica();
            objClinica.Nombre = "Cascabel";
            objClinica.Direccion = "Boedo 3000";
            objClinica.HorarioAtencion = "04-00";
            objClinica.NroConsultorios = 12;

            //mostrar
            objHospital.mostrarDatos();
            objClinica.mostrarDatos();
        }

        public abstract class centroMedico
        {
            //CONSTRUCTOR
            public centroMedico(){}

            //ATRIBUTOS
            private string nombre;
            private string direccion;

            //METODOS

            //Tomar valores para atributos privados
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public string Direccion
            {
                get { return direccion; }
                set { direccion = value; }
            }
        }

        public class hospital : centroMedico
        {
            //CONSTRUCTOR
            public hospital(){}

            //ATRIBUTOS
            private int nroCamas;
            private string rangoTecnologias;

            //METODOS

            public int NroCamas
            {
                get { return nroCamas; }
                set { nroCamas = value; }
            }

            public string RangoTecnologias
            {
                get { return rangoTecnologias; }    
                set { rangoTecnologias = value; }
            }

            public void mostrarDatos()
            {
                Console.WriteLine($"El nombre del hospital es {Nombre} y se encuetra en {Direccion}, este tiene {nroCamas} camas y su rango tecnologico es {rangoTecnologias}");
            }
        }

        public class clinica : centroMedico
        {
            //CONSTRUCTOR
            public clinica() { }

            //ATRIBUTOS
            private int nroConsultorios;
            private string horarioAtencion;

            //METODOS

            public int NroConsultorios
            {
                get { return nroConsultorios; }
                set { nroConsultorios = value; }
            }

            public string HorarioAtencion
            {
                get { return horarioAtencion; }
                set { horarioAtencion = value; }
            }

            public void mostrarDatos()
            {
                Console.WriteLine($"El nombre de la clinica es {Nombre} y se encuentra en {Direccion}, habierto {horarioAtencion} y tiene {nroConsultorios} consultorios");
            }

        }
    }
}