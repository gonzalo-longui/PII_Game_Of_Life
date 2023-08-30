using System;

namespace PII_Game_Of_Life
{
    public class Board
    {
        public bool[,] Matrix { get; set; }
        public Board(bool[,] matrix)
        {
            this.Matrix = matrix;
        }
    }
}