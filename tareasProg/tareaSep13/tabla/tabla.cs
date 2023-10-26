

bool x, y, notX, eval2;

x = false;
y = false;
notX = !x;
eval2 = !x & y;

Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-10} | {3,-10}", "X", "Y", "!X", "!X&&Y"));
Console.WriteLine("------------------------------------------------------------");
x = true;
y = true;
notX = !x;
eval2 = !x & y;
Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-10} | {3,-10}", x, y, notX, eval2));
x = true;
y = false;
notX = !x;
eval2 = !x & y;
Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-10} | {3,-10}", x, y, notX, eval2));
x = false;
y = true;
notX = !x;
eval2 = !x & y;
Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-10} | {3,-10}", x, y, notX, eval2));
x = false;
y = false;
notX = !x;
eval2 = !x & y;
Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-10} | {3,-10}", x, y, notX, eval2));
Console.WriteLine("------------------------------------------------------------");

// Console.WriteLine("{1,-10} {1,-10} {1,-10} {1,-10}", x, y, evalFalse, eval2);

// The example displays the following output:
//      Name                 Hours
//      
//      Adam                  40.0
//      Bridgette              6.7
//      Carla                 40.4
//      Daniel                82.0
//      Ebenezer              40.3
//      Francine              80.0
//      George                16.8