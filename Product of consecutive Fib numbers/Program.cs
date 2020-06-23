using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_of_consecutive_Fib_numbers
{
    public class ProdFib
    {
        public static ulong[] productFib(ulong prod)
        {
            ulong F0 = 0;
            ulong F1 = 1;
            ulong temp;
            ulong product = F0*F1;
            while(product < prod)
            {
                temp = F0;
                F0 = F1;
                F1 = F0 + temp;

                product = F0 * F1;
            }
            if (product == prod)
                return new ulong[] { F0, F1, 1 };
            else 
                return new ulong[] { F0, F1, 0 };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProdFib.productFib(4895);
        }
    }
}
