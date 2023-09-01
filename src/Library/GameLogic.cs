using System;

namespace PII_Game_Of_Life
{
    public class GameLogic
    {
        
        public static Board ImplementGameLogic(Board board)
        {
        bool[,] b = board.Matrix; 
        int boardWidth = b.GetLength(0);
        int boardHeight = b.GetLength(1);

        bool[,] cloneboard = new bool[boardWidth, boardHeight];
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x-1; i<=x+1;i++)
                {
                    for (int j = y-1;j<=y+1;j++)
                    {
                        if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && b[i,j])
                        {
                            aliveNeighbors++;
                        }
                    }
                }
                if(b[x,y])
                {
                    aliveNeighbors--;
                }
                if (b[x,y] && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    cloneboard[x,y] = false;
                }
                else if (b[x,y] && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard[x,y] = false;
                }
                else if (!b[x,y] && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard[x,y] = true;
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneboard[x,y] = b[x,y];
                }
            }
        }
        Board newBoard = new Board(cloneboard);
        return newBoard;
        }
    }
}
