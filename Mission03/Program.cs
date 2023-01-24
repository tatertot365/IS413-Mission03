using System;
using Mission3;

// Group 3-12
// Tic Tac Toe game for Mission 03
namespace Mission03
{
    class Program
    {
        // Receiving an array of characters for gameboard
        static bool SpotsFilled(char[] gameBoard)
        {
            bool NineSpotsFill = true;

            // For loop to determine if positions are filled in gameboard
            for (int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] == '_')
                {
                    NineSpotsFill = false;
                }
            }

            return NineSpotsFill;
        }

        // This function checks to make sure the user inputs a number within the valid range
        // It also checks to make sure that the spot the user wants to place a character is not already taken
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
            Console.WriteLine("\t0|1|2");
            Console.WriteLine("\t- - -");
            Console.WriteLine("\t3|4|5");
            Console.WriteLine("\t- - -");
            Console.WriteLine("\t6|7|8");

            // Characters
            char O = 'O';
            char X = 'X';

            // Checks which player it is
            bool Player1 = true;

            // A while loop that allows the people to keep playing if all spots haven't been filled
            while (SpotsFilled(gameBoard) == false)
            {
                // If it's player one's turn then it asks him/her for where to place an O
                if (Player1)
                {
                    Console.WriteLine("Please select your position player 1: ");

                    // Parses the user's input and validates it
                    int Player1Position = int.Parse(Console.ReadLine());
                    int UserInput = UserInputVal(gameBoard, Player1Position);

                    // sets the player's turn to false and inputs the O character into the gameboard
                    Player1 = false;
                    gameBoard[UserInput] = O;
                }

                // Does the same thing if it's player 2's turn and places X's instead of O's
                else if (Player1 == false)
                {
                    Console.WriteLine("Please select your position player 2: ");

                    int Player2Position = int.Parse(Console.ReadLine());
                    int UserInput = UserInputVal(gameBoard, Player2Position);

                    Player1 = true;
                    gameBoard[UserInput] = X;
                }

                // new instance of the supporting class is created
                Supporting sp = new Supporting();

                // Updated gameboard is printed to the console using the supporting class 
                sp.printBoard(gameBoard);

                // The checkWinnner() function is called 
                string output = sp.checkWinner(gameBoard);

                // If the first letter of the output is an O then Player 1 wins
                if (output[0] == O)
                {
                    Console.WriteLine("Player 1 is the winner!");
                    break;
                }

                // If the first letter of the output is a 1 then Player 2 wins
                else if (output[0] == X)
                {
                    Console.WriteLine("Player 2 is the winner!");
                    break;
                }

                // If there is no winner then that is outputted to the console
                else
                {
                    Console.WriteLine(output);
                }

            }

            // Game is ended by saying thank you for the players
            Console.WriteLine("Thank you for playing!");





        }
    }
}

