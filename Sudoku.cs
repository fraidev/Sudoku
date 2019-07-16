namespace Sudoku
{
    class Sudoku
    {
        public int[,,] Board { get; set; } = new int[3, 3, 9];

        public int[,] BoardView
        {
            get
            {
                var m = new int[9, 9];

                for (int y = 0; y < 9; y++)
                {
                    for (int x = 0; x < 9; x++)
                    {
                        var nx = x % 3;

                        var ny = y % 3;


                        var nz = getZ(nx, ny);

                        m[x, y] = Board[nx, ny, nz - 1];
                    }
                }


                return m;
            }
        }

        private int getZ(int x, int y)
        {
            x += 1;
            y += 1;
            if (x == 1)
            {
                if (y == 1)
                {
                    return 1;
                }

                if (y == 2)
                {
                    return 2;
                }

                if (y == 3)
                {
                    return 3;
                }
            }
            if (x == 2)
            {

                if (y == 1)
                {
                    return 4;
                }

                if (y == 2)
                {
                    return 5;
                }

                if (y == 3)
                {
                    return 6;
                }

            }

            if (x == 3)
            {

                if (y == 1)
                {
                    return 7;
                }

                if (y == 2)
                {
                    return 8;
                }

                if (y == 3)
                {
                    return 9;
                }
            }

            throw new System.Exception();
        }

        public Sudoku()
        {
        }
    }
}
