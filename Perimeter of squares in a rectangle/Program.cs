using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Perimeter_of_squares_in_a_rectangle
{
    public class SumFct
    {
        public static BigInteger perimeter(BigInteger n)
        {
            BigInteger a = 1, b = 1, per = 8*a;
            for (int i = 0; i < n-1; i++)
            {
                a += b;
                b = a - b;
                per += 4*a;
            }
            return per;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumFct.perimeter(7));
            Console.ReadLine();
        }
    }
}
