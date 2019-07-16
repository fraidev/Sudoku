using System;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {

            var sudoku = new Sudoku();

            
            for (int z = 0; z < 9; z++)
            {
                for (var y = 0; y < 3; y++)
                {
                    for (var x = 0; x < 3; x++)
                    {
                        sudoku.Board[x,y,z] = z;
                    }
                    Console.WriteLine();
                }
            }

            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    Console.Write(sudoku.BoardView[x, y] + "|");
                }
                Console.WriteLine();
            }
        }
    }
}
