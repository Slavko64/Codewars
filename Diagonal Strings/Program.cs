using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Strings
{
    public class Kata
    {
        public static string[] DiagonalsOfSquare(string[] array)
        {
            foreach (var item in array)
            {
                if (item.Length > array.Length || item.Length < array.Length)
                    return null;
            }
            var A = array.OrderBy(x => x).ToList();
            string[] Diagonals = new string[array.Length];
            List<int> IndexList = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (IndexList.IndexOf(j) != -1)
                        continue;
                    if (array[j] == A[i])
                        IndexList.Add(j);
                }
            }
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    Diagonals[i] += A[j][j];
                }
                A.Add(A[0]);
                A.Remove(A[0]);
            }
            string[] Out = new string[array.Length];
            for (int i = 0; i < IndexList.Count; i++)
            {
                Out[IndexList[i]] = Diagonals[i];
            }
            if(Out.Length > 0)
            return Out;
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string[] test1 = new string[] { "1a8er", "B36jh", "AiYe3", "B1t0a", "g47uj" };
            ////string[] test1 =  new string[] { "abcd", "kata", "1234", "qwer" };
            //string[] test1 = new string[] { "ab", "12" };
            //string[] test1 = new string[] { "xyz", "xyz", "xyz" };
            string[] test1 = new string[] { "abcdd", "kata", "abcd", "qwer" };
            var A = Kata.DiagonalsOfSquare(test1);
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
