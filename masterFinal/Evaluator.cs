using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masterFinal
{
    static class Evaluator

    {


        public static string? winner(string win)
        {
            string _winner = win;
            return _winner;
        }

        public static string? _guinner;


        public static bool searchForWinner(string[] gameState)
        {
            int[,] winningStates =
{
    { 2, 4, 6 },
    { 0, 3, 6 },
    { 1, 4, 7 },
    { 2, 5, 8 },
    { 0, 1, 2 },
    { 3, 4, 5 },
    { 6, 7, 8 },
    { 0, 4, 8 }

};
            bool isThereAWinner = false;
            while (!isThereAWinner)
            {
                List<string> playerAstate = new List<string>();
                List<string> playerBstate = new List<string>();

                for (int i = 0; i < winningStates.GetLength(0); i++)
                {
                    for (int j = 0; j < winningStates.GetLength(1); j++)
                    {
                        if (!String.IsNullOrEmpty(gameState[winningStates[i, j]]))
                        {
                            switch (gameState[winningStates[i, j]])
                            {
                                case "X":
                                    playerAstate.Add("Jugador X ha realizado una movida");
                                    break;
                                case "O":
                                    playerBstate.Add("Jugador O ha realizado una movida");
                                    break;

                            }
                        }

                    }

                    if (playerAstate.Count == 3)
                    {
                        _guinner = winner("Player X");
                        isThereAWinner = true;
                        
                    } else
                    {
                        playerAstate.Clear();
                    }
                    
                    
                    if (playerBstate.Count == 3)
                    {
                        _guinner = winner("Player O");
                        isThereAWinner = true;

                    }

                    else
                    {
                        
                        playerBstate.Clear();
                   
                    }

     
                    

                }

                break;

            }

            return isThereAWinner;

        }



    }
}
