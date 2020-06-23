using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnet_particules_in_boxes
{
    public class Magnets
    {
        public static double Doubles(int maxk, int maxn)
        {
            double output = 0;
            for (int i = 1; i <= maxk; i++)
                for (int j = 1; j <= maxn; j++)
                    output += 1 / (i * Math.Pow((j + 1), i * 2));
            return output;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Magnets.Doubles(1, 10);
        }
    }
}
