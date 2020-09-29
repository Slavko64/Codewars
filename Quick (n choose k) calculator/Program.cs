using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Quick__n_choose_k__calculator
{
    class QuickCalc
    {
        private static BigInteger Fact(int n)
        {
            BigInteger x = 1;
            for (int i = 2; i <= n; i++)
                x *= i;
            return x;
        }
        public static BigInteger Choose(int n, int p)
        {
            if (n - p > 0)
                return Fact(n) / (Fact(p) * Fact((n-p)));
            else if (n - p == 0) return 1;
                return 0;
        }
    }

    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(QuickCalc.Choose(52, 5));
                Console.ReadLine();
            }
        }
    }