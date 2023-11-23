bool keepRunning = true;




do
{



    System.Console.WriteLine("Ingrese la operacion que desee realizar.\n[1] F° a C°\n[2] C° a F°\n[0] Terminar sesion...");


    int tipoConv = int.Parse(Console.ReadLine()!);

    switch (tipoConv)
    {

        case (1):
            System.Console.WriteLine("\nIngrese la temperatura a convertir (F)");
            int tempF = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine($"Tu temperatura es {Math.Round(FtoC(tempF))} °C");
            break;


        case 2:

            System.Console.WriteLine("\nIngrese la temperatura a convertir (C)");
            int tempC = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine($"Tu temperatura es {Math.Round(CtoF(tempC))}°F");
            break;

        case 0:
            keepRunning = false;
            Console.WriteLine("Terminando sesion...");
            break;

        default:

            System.Console.WriteLine("\nOpcion invalida");
            break;


    }

} while (keepRunning);


static double FtoC(int F)
{


    double tempConv = (F - 32) / 1.8;
    return tempConv;

}

static double CtoF(int C)
{


    double tempConv = (C * 1.8) + 32;
    return tempConv;

}

