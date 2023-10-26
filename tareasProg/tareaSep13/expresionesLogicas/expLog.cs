System.Console.WriteLine("Ingrese la primera variable:  ");
bool var1 = Boolean.Parse(Console.ReadLine());

System.Console.WriteLine("Ingrese la primera variable:  ");
bool var2 = Boolean.Parse(Console.ReadLine());

bool var3 = (var1 && var1) || (var1 && var2);
bool var4 = (var1 || var2) && (var1 || var1);
bool var5 = !(var1 && var2);

System.Console.WriteLine($"El resultado de la primera expresion logica es: {var3}");
System.Console.WriteLine($"El resultado de la segunda expresion logica es: {var4}");
System.Console.WriteLine($"El resultado de la tercera expresion logica es: {var5}");

