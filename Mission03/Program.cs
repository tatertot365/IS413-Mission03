using System;
using Mission3;

namespace Mission03
{
    class Program
    {
        static bool SpotsFilled(char[] gameBoard)
        {
            bool NineSpotsFill = true;

            for (int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] == '_')
                {
                    NineSpotsFill = false;
                }
            }

            return NineSpotsFill;
        }

        static int UserInputVal(char[] gameBoard, int UserInput)
        { 
            while( UserInput > 8 || UserInput < 0)
            {
                Console.WriteLine("That the number is not between 0 and 8, try again.");
                UserInput = int.Parse(Console.ReadLine());

            }

            while (gameBoard[UserInput] != '_')
            {
                Console.WriteLine("That spot is already taken, try again.");
                UserInput = int.Parse(Console.ReadLine());
            }

            return UserInput;
        }

        static void Main(string[] args)
        {
            // Welcome the users to the game
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("You may pick a position 0 through 8 to place an X or O");
            Console.WriteLine("Positions start in the top-left corner, and move from left to right, down to the bottom-right corner.");

            // The gameboard is initialized 
            char[] gameBoard = { '_', '_', '_', '_', '_', '_', '_', '_', '_'};

            // Empty gameboard is outputted to the console
            Console.WriteLine("\t | | ");
            Console.WriteLine("\t- - -");
            Console.WriteLine("\t | | ");
            Console.WriteLine("\t- - -");
            Console.WriteLine("\t | |");

            // Characters
            char O = 'O';
            char X = 'X';

            // Checks which player it is
            bool Player1 = true;

            while (SpotsFilled(gameBoard) == false)
            {
                if (Player1)
                {
                    Console.WriteLine("Please select your position player 1: ");

                    int Player1Position = int.Parse(Console.ReadLine());
                    int UserInput = UserInputVal(gameBoard, Player1Position);

                    Player1 = false;
                    gameBoard[UserInput] = O;
                }

                else if (Player1 == false)
                {
                    Console.WriteLine("Please select your position player 2: ");

                    int Player2Position = int.Parse(Console.ReadLine());
                    int UserInput = UserInputVal(gameBoard, Player2Position);

                    Player1 = true;
                    gameBoard[UserInput] = X;
                }

                /*foreach (char ele in gameBoard)
                {
                    Console.WriteLine(ele);
                }*/

                Supporting sp = new Supporting();
                sp.printBoard(gameBoard);
                Console.WriteLine(sp.checkWinner(gameBoard));

            }





        }
    }
}

