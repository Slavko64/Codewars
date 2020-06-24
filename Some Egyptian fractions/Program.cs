using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Egyptian_fractions
{
    public class Decomp
    {
        static double eps = 1e+8;
        public static int Mod(int a, int n)
        {
            return a - (int)Math.Floor((double)a / n) * n;
        }
        public static string Decompose(string nrStr, string drStr)
        {
           if (nrStr == "0")
                return "[]";
            else if (int.Parse(nrStr) % double.Parse(drStr) == 0)
                return "[" + (int.Parse(nrStr) / double.Parse(drStr)).ToString() + "]";

            string output = "[";
            double x = int.Parse(nrStr);
            double y =  double.Parse(drStr);
            double x1 = -1;
            double y1;
            if(x > y)
            {
                output += (int)(x / y) + ", ";
                x = x - y;
            }
            while(x1 != 0 && Math.Ceiling(y / x) < eps)
            {
                output += "1/" + Math.Ceiling(y / x).ToString() + ", ";
                x1 = Mod((int)-y, (int)x);
                y1 = y * Math.Ceiling(y / x);
                x = x1;
                y = y1;
            }
            
            return output.Substring(0, output.Length-2) + "]";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Decomp.Decompose("5", "4");
            Console.Read();
        }
    }
}
