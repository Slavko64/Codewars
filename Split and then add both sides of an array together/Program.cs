using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_and_then_add_both_sides_of_an_array_together
{
    public class Kata
    {
        public static int[] SplitAndAdd(int[] numbers, int n)
        {
            var A = numbers.ToList();
            for (int i = 0; i < n; i++)
            {
                if (A.Count % 2 != 0)
                {
                    A = A.Select(x => x).Reverse().ToList();
                    A.Add(0);
                    A = A.Select(x => x).Reverse().ToList();
                }
               A = A.Select(x => x).Reverse().Skip((int)Math.Ceiling(A.Count / 2d)).Select(x => x).ToArray().Zip(A.Select(x => x).Reverse().Take((int)Math.Ceiling(numbers.Length / 2d)).Select(x => x).ToArray(), (x, y) => x + y).Reverse().ToList();
            }
            return A.ToArray();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kata.SplitAndAdd(new int[] { 1, 2, 3, 4, 5 }, 2);
        }
    }
}
