var rand = new Random();

Console.WriteLine("10 numeros aleatorios entre 0 a 100");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("{0,8:N0}", rand.Next(101));

}

