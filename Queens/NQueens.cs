using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens
{
    class NQueens
    {
        private int n;
        public NQueens(int n)
        {
            this.n = n;
        }
        // checking if a queen can be placed in the received position ([r,c])
        private bool IsValid(int[,] mat, int r, int c)
        {
            for (int i = 0; i < r; i++)

                if (mat[i, c] == 1)
                    return false;

            for (int i = r, j = c; i >= 0 && j >= 0; i--, j--)
                if (mat[i, j] == 1)
                    return false;

            for (int i = r, j = c; i >= 0 && j <n; i--, j++)
                if (mat[i, j] == 1)
                    return false;
            return true;
        }
        //printing the chess (Q is queen)
        private void PrintMat(int[,] mat)
        {
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j <n; j++)
                {
                    if (mat[i, j] == 0)
                        Console.Write("x ");
                    else Console.Write("Q ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        //the recursive algorithm 
        private void AllOptionsRec(int[,] mat, int row)
        {
            if (row == n)
            {
                PrintMat(mat);
                return;
            }
            for (int i = 0; i <n; i++)
            {
                if (IsValid(mat, row, i))
                {
                    mat[row, i] = 1;
                    AllOptionsRec(mat, row + 1);
                    mat[row, i] = 0;
                }
            }
        }
        public  void AllOptions()
        {
            int[,] mat = new int[n, n];
            AllOptionsRec(mat, 0);
        }

    }
}
