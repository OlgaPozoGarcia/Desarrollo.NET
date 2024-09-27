using EjemploClases;

namespace Ejemplosclases
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


Coche BentleyBentayga   = new Coche();

Coche FerrariCalifornia = new Coche();

Coche SkodaFabia        = new Coche();

Coche AudiR8            = new Coche();

Coche Porsche911        = new Coche();

Coche BMWX6             = new Coche();

Coche JaguarXF          = new Coche();

Coche MaseratiLevante   = new Coche();

Coche HyundaiTucson     = new Coche();

Coche MercedesGLC       = new Coche();


BentleyBentayga.Marca = "Bentley";
BentleyBentayga.Modelo = "Bentayga";
BentleyBentayga.Color = "Negro";
BentleyBentayga.Consumo = "4.5";
BentleyBentayga.NumeroPuertas = "5";
BentleyBentayga.NumeroAsientos = "5";
BentleyBentayga.Cilindrada = "8";
BentleyBentayga.MotorCoche = new Motor();

BentleyBentayga.MotorCoche.Cilindrada = "8";
BentleyBentayga.MotorCoche.Consumo = "4.5";
BentleyBentayga.MotorCoche.Potencia = "110";
BentleyBentayga.MotorCoche.Combustible = "Diesel";




//Crear las instancias de los empleados: Pedro, Maria y Juan

Empleados empleado1 = new Empleados();

empleado1.Nombre = "Pedro";
empleado1.Departamento = "IT";

Empleados empleado2 = new Empleados();

empleado2.Nombre = "Maria";
empleado2.Departamento = "Desarrollo Apps";

Empleados empleado3 = new Empleados();

empleado3.Nombre = "Juan";
empleado3.Departamento = "Recursos Humanos";

Empleados empleado4 = new Empleados();

empleado4.Nombre = "Claudia";
empleado4.Departamento = "Ventas";

Empleados empleado5 = new Empleados();

empleado5.Nombre = "Olga";
empleado5.Departamento = "Marketing";
empleado5.Telefono = "697806648";
empleado5.NSS = "866515226655";
empleado5.IBAN = "562158126425";








        }
    }
}
