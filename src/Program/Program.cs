using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board1 = ReadFile.LoadBoard();
            while (true)
            {
                board1 = Printer.PrintBoard(board1);
            }
        }
    }
}
