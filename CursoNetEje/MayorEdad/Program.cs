using System.ComponentModel.Design;

namespace MayorEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, Mundo");
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Por favor, ingresa tu edad");
            string  edadPersonaConsola = Console.ReadLine();

            // Convetir string a entero con Convert
            // Convertir (Convert) a entero (ToInt32)
            //      lo que has pedido por pantalla (edadPersonaConsola)
            int edadPersona = Convert.ToInt32(edadPersonaConsola);

            // int             int
            if (edadPersona >= 18) 
            {
                Console.WriteLine("Eres mayor de edad.");
        }
            else 
            {
                Console.WriteLine("Eres menor de edad.");

            //Determinar etapa de la vida

            if (edadPersona <= 12)
                {
                  
                    Console.WriteLine("Estas en la etapa: Niño");
                    }
            else if (edadPersona >= 12 && edadPersona <18) 
                {
                    Console.WriteLine("Estas en la etapa: adolescente");
                     }
            else if (edadPersona >= 18 && edadPersona <= 65)
                { 
                        Console.WriteLine("Estas en la etapa: Adulto");
                    }
            else if (edadPersona >= 65)
                    Console.WriteLine("Estas en la etapa: Aduto Mayor");

            
        } // Fin del else
     } //Fin del método Main
   } // Fin del método Program
} //Fin del namespace


