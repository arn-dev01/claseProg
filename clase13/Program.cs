//int[] arr = { 8, 56, 45, 78, 96, 23, 44 };

//foreach (var item in arr)
//{
//    Console.Write($"{item} ");

//}
//Console.WriteLine("\n");
//static void incrementarReferencia(ref int[] args )
//{
//    for (int i = 0; i < args.Length; i++)
//    {
//        args[i] += 1;
//    }
//}

//incrementarReferencia(ref arr);

//foreach (var item in arr)
//{
//    Console.Write($"{item} ");

//}

//Console.WriteLine("\n");




int val1;
int val2;

static void intercambiarValores(out int val1, out int val2)
{
    Console.WriteLine("Ingrese valor A");
    val1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"El valor A es {val1} previo al intercambio\n");

    Console.WriteLine("Ingrese valor B");
    val2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"El valor B es {val2} previo al intercambio\n");

    int temp1 = val1;
    val1 = val2;    
    val2 = temp1;

    Console.WriteLine("Intercambio realizado\n");
}

intercambiarValores(out val1, out val2);

Console.WriteLine($"El valor A es {val1}");
Console.WriteLine($"El valor B es {val2}");



