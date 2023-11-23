Console.WriteLine("Ingrese una palabra");
string palabra = Console.ReadLine()!;

char[] characters = { 'a', 'e', 'i', 'o', 'u' };
int[] charCounter = new int[characters.Length];

string[] destructured = palabra.ToCharArray().Select(c => c.ToString()).ToArray();

foreach (var charac in destructured)
{
    switch (charac)
    {
        case "a":
            charCounter[0] += 1;
            break;
        case "e":
            charCounter[1] += 1;
            break;
        case "i":
            charCounter[2] += 1;
            break;
        case "o":
            charCounter[3] += 1;
            break;
        case "u":
            charCounter[4] += 1;
            break;
    }
}

for(int i =0; i <= charCounter.Length-1; i++)
{
    Console.WriteLine($"{characters[i]} = {charCounter[i]}");
}