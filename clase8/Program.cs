      int num = 1;
      int sum = 0;

    while(num != 0) {
      Console.WriteLine("Ingrese un numero");
      num = int.Parse(Console.ReadLine());
      sum += num;
    }

    Console.WriteLine(sum);