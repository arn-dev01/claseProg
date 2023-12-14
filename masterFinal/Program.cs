/* int[] win1 = new int[] { 2, 4, 6 };
//
int[] win2 = new int[] { 0, 3, 6 };
int[] win3 = new int[] { 1, 4, 7 };
int[] win4 = new int[] { 2, 5, 8 };
//
int[] win5 = new int[] { 0, 1, 2 };
int[] win6 = new int[] { 3, 4, 5 };
int[] win7 = new int[] { 6, 7, 8 };
int[] win8 = new int[] { 0, 4, 8 }; */

/* int[,] winningStates =
{
    { 2, 4, 6 },
    { 0, 3, 6 },
    { 1, 4, 7 },
    { 2, 5, 8 },
    { 0, 1, 2 },
    { 3, 4, 5 },
    { 6, 7, 8 },
    { 0, 4, 8 }

}; */









using masterFinal;




int place;



/* for(int i = 0; i < game.Length; i++)
{
    Console.WriteLine(game[i]);
} */
do
{

    Console.Clear();
    string[] game = { " ", " ", " ", " ", " ", " ", " ", " ", " ", };
    //while (!winningState || game.Length != 9)
    //{
    for (int i = 0; i < game.Length; i++)
    {
        if (i % 2 == 0)
        {
            bool emptyCell = false;
            printState(game);
            Console.WriteLine($"Turno {i + 1} (X)");
            printMap();

            while (!emptyCell)
            {
                Console.WriteLine("Seleccione donde desea agregar X\n");
                place = int.Parse(Console.ReadLine()!);
                if (game[place] == "O" || game[place] == "X")
                {
                    Console.WriteLine("Posicion ya fue utilizada. Intente en otra casilla");
                }
                else
                {
                    game[place] = "X";
                    emptyCell = true;

                }





            }
            Console.Clear();

        }
        else
        {
            bool emptyCell = false;

            printState(game);
            Console.WriteLine($"Turno {i + 1} (O)");
            printMap();
            while (!emptyCell)
            {
                Console.WriteLine("Seleccione donde desea agregar O\n");
                place = int.Parse(Console.ReadLine()!);
                if (game[place] == "O" || game[place] == "X")
                {
                    Console.WriteLine("Posicion ya fue utilizada. Intente en otra casilla");
                }
                else
                {
                    game[place] = "O";
                    emptyCell = true;

                }





            }


            Console.Clear();

        }

            if (i >= 4)
            {

                if (Evaluator.searchForWinner(game))
                {
                    Console.WriteLine($"Winner is {Evaluator._guinner}");
                    Console.WriteLine("Juego finalizado");
                    break;
                }
            }
        }



        if (!Evaluator.searchForWinner(game))
            Console.WriteLine("Empate");
        //break;




        //}

        Console.WriteLine("Desea jugar otra partida? Y/N");

    
    } while (Console.ReadKey().Key != ConsoleKey.N) ;

    void printMap()
    {
        Console.WriteLine(String.Format("\n{0,-3}{1,-3}{2,-3}\n{3, -3}\n{4,-3}{5,-3}{6,-3}\n{7, -3}\n{8,-3}{9,-3}{10,-3}\n", $" {0} |", $" {1} |", $" {2}", "------------", $" {3} |", $" {4} |", $" {5} ", "------------", $" {6} |", $" {7} |", $" {8}"));
    }

    void printState(string[] game)
    {
        Console.WriteLine(String.Format("\n{0,-3}{1,-3}{2,-3}\n{3, -3}\n{4,-3}{5,-3}{6,-3}\n{7, -3}\n{8,-3}{9,-3}{10,-3}\n", $" {game[0]} |", $" {game[1]} |", $" {game[2]}", "------------", $" {game[3]} |", $" {game[4]} |", $" {game[5]} ", "------------", $" {game[6]} |", $" {game[7]} |", $" {game[8]}"));
    }