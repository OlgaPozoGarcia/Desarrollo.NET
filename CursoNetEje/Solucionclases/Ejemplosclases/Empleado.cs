using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploClases
{
    public class Empleado
    {
        public string Nombre { get; set; }



        public string Departamento { get; set; }


        public string Telefono { get; set; }

        public string NumeroEmpleado { get; set; }

        public string NSS { get; set; }

        public string IBAN { get; set; }

        //Metodo / (Funcion) MostarDatosEmpleado
        public void MostrarDatosEmpleado()
        {
            //Mediante interpolacion de cadenas ($)
            Console.WriteLine($"Nombre empleado:{Nombre} Departamento Empleado:{Departamento} Telefono Empleado:{Telefono}");



            }
        }
}

