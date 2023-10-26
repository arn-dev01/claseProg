using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           /*  int n1,n2,r;
            
            System.Console.WriteLine("Ingresar Numero 1");
            n1 = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine("Ingress Numero 2");
            n2 = int.Parse(Console.ReadLine()!);

            if (n1 == n2) {
                r = n1 * n2;
            } else if (n1 > n2) {
                r = n1 - n2;
            } else {
                r = n1 + n2;
            }

            System.Console.WriteLine($"El valor es {r}"); */

            
            double tempC, tempF, tempConv;
             ConsoleKeyInfo tipoConv;

             

            System.Console.WriteLine("Ingrese la operacion que desee realizar.\n[1]F° a C°\n[2]C° a F°");
           
           do
           {
            tipoConv = Console.ReadKey();
            
            if(tipoConv.Key == ConsoleKey.D1) {
                System.Console.WriteLine("\nIngrese la temperatura a convertir (F)");
                tempF = int.Parse(Console.ReadLine()!);
                tempConv = (tempF - 32)/1.8;
                System.Console.WriteLine($"Tu temperatura es {Math.Round(tempConv)}°C");
            } else if (tipoConv.Key == ConsoleKey.D2){
                System.Console.WriteLine("\nIngrese la temperatura a convertir (C)");
                tempC = int.Parse(Console.ReadLine()!);
                tempConv = (tempC * 1.8 ) + 32;
                System.Console.WriteLine($"Tu temperatura es {Math.Round(tempConv)}°F");
            } else {
                System.Console.WriteLine("\nOpcion invalida");
            };

            


        }
    }
}