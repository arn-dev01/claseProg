int size = 5;
//string tree = "";

for (int i = 0; i <= size; i++)
{
    for (int j = 0; j <= i; j++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}
for (int i = size; i > 0; i--)
{
    for (int j = 1; j <= i; j++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}
