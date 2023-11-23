

//var nums = new int[10];

 int[] nums = {33, 44, 54, 22, 12, 93, 7 ,56, 14, 37};
int sum = 0;

/* for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine($"Ingrese el numero {i}");
    int capture = int.Parse(Console.ReadLine()!);
    nums[i] = capture;

 */

Console.Clear();

foreach (int num in nums)
{
    Console.Write($"{num} ");
    sum += num;

}
Console.WriteLine("\n");
Console.WriteLine($"La sumatoria es {sum}\n");

//Array.Sort(nums);
static int[] sort(int[] array)
{
    int unsorted_until_index = array.Length - 1;
    bool sorted = false;

    while (!sorted)
    {
        sorted = true;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])

            {

                int tempCurrentValue = array[i];
                int tempCurrentNextValue = array[i + 1];
                array[i] = tempCurrentNextValue;
                array[i + 1] = tempCurrentValue;
                sorted = false;
            }

        }
        unsorted_until_index -= 1;
    }
    return array;
}

int[] sortedArray = sort(nums);



foreach (int num in sortedArray)
{
    Console.Write($"{num} ");

}

Console.WriteLine("\n");


do
{
    Console.WriteLine("\nIngrese la accion a realizar");
    Console.WriteLine("1. Buscar dato");
    Console.WriteLine("2. Mostrar dato segun index\n");

    int action = int.Parse(Console.ReadLine()!);

    switch (action)
    {
        case 1:
            Console.WriteLine("Ingrese el numero a buscar");
            int searchNum = int.Parse(Console.ReadLine()!);
            bool finded = false;

            for(int i=0; i <= sortedArray.Length -1; i++)
            {
                if (searchNum == sortedArray[i])
                {
                    Console.WriteLine($"El numero que buscas esta en el index {i}\n");
                    finded = true;
                    break;
                }
            }

            if (!finded)
            {
                Console.WriteLine("Numero no encontrado");
            }

            
            break;
        case 2:
            Console.WriteLine("Ingrese el index a buscar");
            int index = int.Parse(Console.ReadLine()!);
            if(index > sortedArray.Length - 1)
            {
                Console.WriteLine($"Numero no existe. Ingrese numero del 0 al {sortedArray.Length - 1}");
            } else
            {
                Console.WriteLine($"El numero que estas buscando es {sortedArray[index]}\n");
            }
            break;

    }


    


    Console.WriteLine("Presione cualquier tecla para continuar");
    Console.WriteLine("Presione ESC para salir...");

} while (Console.ReadKey().Key != ConsoleKey.Escape);