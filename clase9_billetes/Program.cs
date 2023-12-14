int[] billetes = { 20, 50, 100, 200, 500, 1000 };

do
{
    Console.WriteLine("Ingrese cantidado a feriar :P");

    int cantidad = int.Parse(Console.ReadLine()!);

    for (int i = billetes.Length - 1; i >= 0; i--)
    {
        if (cantidad >= billetes[i])
        {
            int numDeBilletes = cantidad / billetes[i];

            Console.WriteLine($"Entregue {numDeBilletes} de ${billetes[i]}");
            cantidad -= numDeBilletes * billetes[i];


        }

    }

    if (cantidad > 0)
    {
        Console.WriteLine($"Entregue ${cantidad} pesos de cambio");
    }


    Console.WriteLine("\nPresione cualquier tecla para continuar");
    Console.WriteLine("Presione tecla ESC para salir...\n");

} while (Console.ReadKey().Key != ConsoleKey.Escape);

