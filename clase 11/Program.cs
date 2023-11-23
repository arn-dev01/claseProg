//// Calculadora


String[] menu = { "Sumar", "Restar", "Multiplicar", "Dividir" };
do
{
    Console.Clear();
    Console.WriteLine("-----Calculadora-----\n");
    Console.WriteLine("Ingrese la operacion que desea realizar");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");


    int selec = int.Parse(Console.ReadLine()!);
    Console.Clear();
    Console.WriteLine($"Seleccionaste {menu[selec - 1]}\n");


    Console.WriteLine("Ingrese numero 1");
    double numero1 = double.Parse(Console.ReadLine()!);

    Console.WriteLine("Ingrese numero 2");
    double numero2 = double.Parse(Console.ReadLine()!);




    switch (selec)
    {
        case 1:
            Console.WriteLine($"La suma de {numero1} + {numero2} es igual a {Suma(numero1, numero2)}\n");
            break;
        case 2:
            Console.WriteLine($"La resta de {numero1} - {numero2} es igual a {Resta(numero1, numero2)}\n");
            break;
        case 3:
            Console.WriteLine($"La multiplicacion de {numero1} x {numero2} es igual a {Mult(numero1, numero2)}");
            break;
        case 4:
            if(Div(numero1,numero2) == -1)
            {
                Console.WriteLine("Operacion no realizada. Intente con otro numero\n");
            } else
            {
                Console.WriteLine($"La division de {numero1} / {numero2} es igual a {Div(numero1, numero2)} \n");
            }
        break;

        default:
            Console.WriteLine("Instruccion no existe. Eliga una opcion valida del menu");
            break;


    }

    Console.WriteLine("Presione cualquier tecla para continuar");
    Console.WriteLine("Presione ESC para salir...");







} while (Console.ReadKey().Key != ConsoleKey.Escape);







//Console.WriteLine("Ingrese numero 1");
//double numero1 = double.Parse(Console.ReadLine()!);

//Console.WriteLine("Ingrese numero 2");
//double numero2 = double.Parse(Console.ReadLine()!);



//Console.WriteLine($"La resta de {numero1} - {numero2} es igual a {Resta(numero1, numero2)}");
//Console.WriteLine($"La multiplicacion de {numero1} x {numero2} es igual a {Mult(numero1, numero2)}");
//if(Div(numero1,numero2) == -1)
//{
//    Console.WriteLine("Operacion no realizada. Intente con otro numero\n");
//} else
//{
//    Console.WriteLine($"La division de {numero1} / {numero2} es igual a {Div(numero1, numero2)}");
//}

static double Suma(double num1, double num2)
{
    return num1 + num2;
}

static double Resta(double num1, double num2)
{
    return num1 - num2;
}

static double Mult(double num1, double num2)
{
    return num1 * num2;
}

static double Div(double num1, double num2)
{ 


    if (num2 == 0)
    {
        //Console.WriteLine("\nNo se puede realizar la operacion");
        return -1;
    } else
    {
  
        return num1 / num2;
   }

    
}