// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Modificar para incorporar las siguientes características:    
// Indicar el numero de intentos que le quedan
// Indicar si el número a adivinar es mayor o menor que el introducido

//Pedir al usuario que ingrese un número a adivinar
Console.WriteLine("Introduce un número para que otro jugador lo adivine");
int numeroAdivinar = int.Parse(Console.ReadLine());

//Limpiar la consola para que el segundo juguador no vea el número
Console.Clear();

//Dar tres oportunidades para adivinar el número
for (int i = 0; i < 2; i++)
    {
    Console.Write("Adivina el número:");
    int intento = int.Parse(Console.ReadLine());

    if (intento == numeroAdivinar) 
    {
        Console.WriteLine("¡Felicidades! Has adivinado el número.");
        return;
      }
    else
    {
        if (intento < numeroAdivinar) 
        {
            Console.WriteLine("El número a adivinar es mayor");
        }
        else
        {
            Console.WriteLine("El número a adivinar es menor.");
        }
            Console.WriteLine("Número incorrecto. Intenta de nuevo.");
        }
     }
   