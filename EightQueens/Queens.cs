using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueens
{
    internal class Queens
    {
        public static int n;
        public static int[] queens;
        private int sloutions = 0;

        public Queens(int number)
        {
            n = number;
            queens = new int[n];
        }

        public int GetSolutions()
        {
            return this.sloutions;
        }
        public void GetEightQueens(int row)
        {
            if (row == n)
            {
                sloutions++;
                PrintSolution();
                return;
            }

            for (int col = 0; col < n; col++)
            {
                // 檢查位置
                if (SafeToPlaceQueen(row, col))
                {
                    // 放置Queen
                    queens[row] = col;
                    GetEightQueens(row + 1);
                }
            }
        }

        private bool SafeToPlaceQueen(int row, int col)
        {
            //往前檢查至當前row
            for (int prevRow = 0; prevRow < row; prevRow++)
            {
                // 取得prevCol的Queen位置
                int prevCol = queens[prevRow];

                // 和當前位置在同一欄 或 在對角線上
                if (prevCol == col || Math.Abs(prevRow - row) == Math.Abs(prevCol - col))
                {
                    return false;
                }
            }
            return true;
        }

        private void PrintSolution()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (queens[i] == j)
                    {
                        Console.Write("Q");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
