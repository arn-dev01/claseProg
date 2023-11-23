// Ingresas numero

int[] numRomanos = { 1, 4, 5, 6, 7, 8, 9, 10, 50, 100, 500, 1000 };
string[] letrasRomanas = {"I","IV", "V","VI", "VII", "VIII", "IX", "X","L", "C", "D", "M" };

int num = 444;
// deconstruirlo en 1 a 10, 
int acum = num;
int follower = numRomanos.Length - 1;
var numDestruct = new List<int>();


do
{
    if (acum >= numRomanos[follower])
        
    {
        int cantidadDeEsaLetra = acum / numRomanos[follower];
        if (cantidadDeEsaLetra  == 4)
        {
            
            switch (string.Concat(Enumerable.Repeat(letrasRomanas[follower], cantidadDeEsaLetra)))
            {
                case "CCCC":
                    Console.Write("CD");
                    break;
                case "XXXX":
                    Console.Write("XL");
                    break;
                case "IIII":
                    Console.Write("IV");
                    break;
            

            }
            
        }
        
        else
        {
            numDestruct.Add(cantidadDeEsaLetra);
            Console.Write(string.Concat(Enumerable.Repeat(letrasRomanas[follower], cantidadDeEsaLetra)));

        }
        
        acum -= cantidadDeEsaLetra * numRomanos[follower];
        
    
    }
    follower--;



} while (acum > 0);

