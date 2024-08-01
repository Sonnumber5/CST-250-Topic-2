using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board myBoard = new Board(8);
        public static void Main(String[] args)
        {
            // a) show the empty chessboard
            PrintGrid(myBoard);

            // b) get the location of the chess piece
            Cell myLocation = SetCurrentCell();

            // c) calculate and mark the cells where legal moves are possible
            MoveSelector(myLocation);
            

            // d) show the chess board. Use . for an empty sqaure, X for the piece location and + for a possible legal move
            PrintGrid(myBoard);

            // e) wait for another return key to end the program
            Console.ReadLine();
        }

        public static void MoveSelector(Cell myLocation){
            bool isValid = false;
            while (!isValid)
            {
                Console.Out.WriteLine("Which piece would you like to place?");
                Console.Out.WriteLine("1: Knight   2: King   3: Rook   4: Bishop   5: Queen");
                string pieceSelection = Console.ReadLine();
                switch (pieceSelection)
                {
                    case "1":
                        myBoard.MarkNextLegalMoves(myLocation, "Knight");
                        isValid = true;
                        break;
                    case "2":
                        myBoard.MarkNextLegalMoves(myLocation, "King");
                        isValid = true;
                        break;
                    case "3":
                        myBoard.MarkNextLegalMoves(myLocation, "Rook");
                        isValid = true;
                        break;
                    case "4":
                        myBoard.MarkNextLegalMoves(myLocation, "Bishop");
                        isValid = true;
                        break;
                    case "5":
                        myBoard.MarkNextLegalMoves(myLocation, "Queen");
                        isValid = true;
                        break;
                    default:
                        Console.Out.WriteLine("Please enter a valid piece");
                        break;
                }

            }
        }

        public static void PrintGrid(Board myBoard)
        {
            Console.Write("   ");
            for (int k = 0; k < myBoard.Size; k++)
            {
                Console.Write($"  {k} ");
            }
            Console.WriteLine();
            for (int i = 0; i < myBoard.Size; i++)
            {
                Console.Write("   ");
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Console.Write("+---");
                }
                Console.WriteLine("+");
                Console.Write($"{i}  ");
                for (int j = 0; j < myBoard.Size; j++)
                {
                    if (myBoard.TheGrid[i, j].CurrentlyOccupied)
                    {
                        Console.Write("| X ");
                    }
                    else if (myBoard.TheGrid[i, j].LegalNextMove)
                    {
                        Console.Write("| + ");
                    }
                    else
                    {
                        Console.Write("| . ");
                    }
                    
                }
                Console.WriteLine("|");
            }
            Console.Write("   ");
            for (int j = 0; j < myBoard.Size; j++)
            {
                Console.Write("+---");
            }
            Console.WriteLine("+");
            Console.WriteLine("   =================================");
        }

        public static Cell SetCurrentCell()
        {
           int currentRow = 0;
            int currentColumn = 0;
            bool isValid = false;

            isValid = false;
            while (!isValid){
                Console.Out.WriteLine("Enter your current row number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out currentRow) && currentRow < 8)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
           }

           isValid = false;
           while (!isValid)
           {
                Console.Out.WriteLine("Enter your current column number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out currentColumn) && currentColumn < 8)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
           }

            myBoard.TheGrid[currentRow, currentColumn].CurrentlyOccupied = true;

            return myBoard.TheGrid[currentRow, currentColumn];
        }
    }
}