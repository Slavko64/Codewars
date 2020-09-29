using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validate_Sudoku_with_size__NxN_
{
    class Sudoku
    {
        int[][] sudokuData;
        public Sudoku(int[][] sudokuData)
        {
            this.sudokuData = sudokuData;
        }

        public bool IsValid()
        {
            for (int i = 0; i < sudokuData.Length; i++)
                if (sudokuData[i].Length != sudokuData.Length)
                    return false;
            List<int> Row = new List<int>();
            for (int i = 0; i < sudokuData.Length; i++)
            {
                for (int j = 0; j < sudokuData.Length; j++)
                    Row.Add(sudokuData[i][j]);

                Row = Row.Distinct().ToList();
                
                if (Row.Count != sudokuData.Length || Row.Min() < 1 || Row.Max() > sudokuData.Length)
                    return false;
                
                Row.Clear();
            }
            for (int i = 0; i < sudokuData.Length; i++)
            {
                for (int j = 0; j < sudokuData.Length; j++)
                    Row.Add(sudokuData[j][i]);

                Row = Row.Distinct().ToList();
                
                if (Row.Count != sudokuData.Length || Row.Min() < 1 || Row.Max() > sudokuData.Length)
                    return false;
                
                Row.Clear();
            }
            int length = (int)Math.Sqrt(sudokuData.Length);
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    for (int m = i*length; m < i*length + length; m++)
                    {
                        for (int n = j * length; n < j * length + length; n++)
                        {
                            Row.Add(sudokuData[m][n]);
                        }
                    }
                    Row = Row.Distinct().ToList();
                    if (Row.Count != sudokuData.Length || Row.Min() < 1 || Row.Max() > sudokuData.Length)
                        return false;
                    Row.Clear();
                }
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var goodSudoku1 = new Sudoku(
              new int[][] {
              new int[] {7,9,4, 1,5,9, 3,2,6},
              new int[] {5,3,9, 6,7,2, 8,4,1},
              new int[] {6,1,2, 4,3,8, 7,5,9},

              new int[] {9,2,8, 7,1,5, 4,6,3},
              new int[] {3,5,7, 8,4,6, 1,9,2},
              new int[] {4,6,1, 9,2,3, 5,8,7},

              new int[] {8,7,6, 3,9,4, 2,1,5},
              new int[] {2,4,3, 5,6,1, 9,7,8},
              new int[] {1,9,5, 2,8,7, 6,3,4}
              });
            goodSudoku1.IsValid();
            Console.Read();
        }
    }
}
