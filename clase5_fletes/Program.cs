// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a ITExpress");
        Console.WriteLine("\nIngrese la cantidad en KG de su paquete");
        bool again = true;
        double pesoPaquete = 1000 * double.Parse(Console.ReadLine()!);
        if (pesoPaquete > 5000)
        {
            Console.WriteLine("Tu paquete excede los limites de peso estipulados. Maximo 5 KG");
        }
        else
        {
            do
            {
                ShowMenu();

                Console.WriteLine("\nPor favor seleccione una de las zonas destino");
                ConsoleKeyInfo zona = Console.ReadKey();

                switch (zona.Key)
                {
                    case ConsoleKey.D1:
                        calcAndShow(11, pesoPaquete);
                        break;
                    case ConsoleKey.D2:
                        calcAndShow(10, pesoPaquete);
                        break;
                    case ConsoleKey.D3:
                        calcAndShow(12, pesoPaquete);
                        break;
                    case ConsoleKey.D4:
                        calcAndShow(24, pesoPaquete);
                        break;
                    case ConsoleKey.D5:
                        calcAndShow(27, pesoPaquete);
                        break;
                    case ConsoleKey.D6:
                        again = false;
                        break;

                    default:
                        Console.WriteLine("La opcion que seleccionaste no es valida");
                        break;
                }
            } while (again);
        }
    }

    public static void ShowMenu()
    {
        Console.WriteLine("\n<<< Zonas de embarque y tarifa por destino>>>>\n");
        int[] zonas = { 1, 2, 3, 4, 5 };
        string[] ubicaciones =
        {
            "América del Norte",
            "América Central",
            "América del Sur",
            "Europa",
            "Asia"
        };
        int[] costos = { 11, 10, 12, 24, 27 };

        for (int counter = 0; counter < zonas.Length; counter++)
            Console.WriteLine(
                "{0,-5} {1,-18} {2,8}",
                $"[{zonas[counter]}]",
                ubicaciones[counter],
                $"$ {costos[counter]}.00"
            );

        System.Console.WriteLine("{0,-5} {1,-18}", "[5]", "Salir");
    }

    public static void calcAndShow(int precio, double pesoPaquete)
    {
        Console.Clear();
        Console.WriteLine($"\nEl costo de tu envio seria\n $ {pesoPaquete * precio}.00 mn");
    }
}
