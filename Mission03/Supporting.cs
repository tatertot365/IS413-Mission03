using System;

namespace Mission3
{
    class Supporting
    {
        public void printBoard(char[] board)
        {
            Console.Write("\t" + board[0] + " | " + board[1] + " | " + board[2] + "\n");
            Console.Write("\t" + "----------\n");
            Console.Write("\t" + board[3] + " | " + board[4] + " | " + board[5] + "\n");
            Console.Write("\t" + "----------\n");
            Console.Write("\t" + board[6] + " | " + board[7] + " | " + board[8] + "\n");
        }
        public string checkWinner(char[] board)
        {
            string output = "No winner yet, keep playing!";
            //ROW options for winning
            //First row
            if ((board[0] == board[1]) && (board[1] == board[2]) && board[0] != '_')
            {
                output = board[0] + " is the winner";
            }
            //Second row
            else if ((board[3] == board[4]) && (board[4] == board[5]) && board[3] != '_')
            {
                output = board[3] + " is the winner!";
            }
            //Third row
            else if ((board[6] == board[7]) && (board[7] == board[8]) && board[6] != '_')
            {
                output = board[6] + " is the winner";
            }
            //COLUMNS
            //First column
            else if ((board[0] == board[3]) && (board[3] == board[6]) && board[0] != '_')
            {
                output = board[0] + " is the winner";
            }
            //Second column
            else if ((board[1] == board[4]) && (board[4] == board[7]) && board[1] != '_')
            {
                output = board[1] + " is the winner!";
            }
            //Third column
            else if ((board[2] == board[5]) && (board[5] == board[8]) && board[2] != '_')
            {
                output = board[2] + " is the winner";
            }
            //DIAGNALS
            //back diagnal
            else if ((board[0] == board[4]) && (board[4] == board[8]) && board[0] != '_')
            {
                output = board[0] + " is the winner!";
            }
            //forward diagnal
            else if ((board[2] == board[4]) && (board[4] == board[6]) && board[2] != '_')
            {
                output = board[2] + " is the winner";
            }
            return output;
        }
    }
}

