do
{

    Console.WriteLine("Ingrese un year a evaluar");

    int year = int.Parse(Console.ReadLine()!);


    if ((
        !Convert.ToBoolean(year % 4) && Convert.ToBoolean(year % 100))

         || ((!Convert.ToBoolean(year % 4)
            && !Convert.ToBoolean(year % 100)
            && !Convert.ToBoolean(year % 400))))
    {

        Console.WriteLine($"{year} es Bisiesto");
    }
    else
    {
        Console.WriteLine($"{year} no es Bisiesto");
    }

    Console.WriteLine("\nPresione cualquier tecla para continuar");
    Console.WriteLine("Presione tecla ESC para salir...\n");

} while (Console.ReadKey().Key != ConsoleKey.Escape);