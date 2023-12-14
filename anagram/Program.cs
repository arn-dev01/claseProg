using System;

static string[]? anagrams_of(string str)
{
    if (str.Length == 1)
    {
        Console.WriteLine("Llegaste al base case");
        Console.WriteLine(str[0].ToString());
        return new string[] { str[0].ToString() };
    }
   
    Console.WriteLine(str);
    string[] collections = { };
    Console.WriteLine("Recursionamos");
    Console.WriteLine(str.Substring(1, str.Length - 1));
    string[]? substring_anagrams = anagrams_of(str.Substring(1, str.Length - 1));
    Console.WriteLine("Resultado de la recursion");
    Console.WriteLine(string.Join("", substring_anagrams!));

    foreach(var substring_anagram in substring_anagrams!)
    {
        for(int i = 0; i <= substring_anagram.ToString().Length ; i++) 

        {
            Console.WriteLine("Como se ve str");
            Console.WriteLine(str);
            Console.WriteLine("cada elementos /supuestamente/ de lo que retono la recursion");
            Console.WriteLine(substring_anagram);
            Console.WriteLine("Que es el copy");
            string copy = substring_anagram;
            Console.WriteLine(copy);

           Console.WriteLine("Que agregaremos al copy");
           Console.WriteLine(str[0].ToString());

            Console.WriteLine("Que es el index");
            Console.WriteLine(i);

            collections = collections.Append(copy.Insert(i, str[0].ToString())).ToArray();
           Console.WriteLine("Como queda collection");
            Console.WriteLine(string.Join("\n", collections));



        }
    }


    return collections;
}



Console.WriteLine($"\n{string.Join("\n",anagrams_of("abcd")!)}");