using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weight_for_weight
{
    class Program
    {
        static void Main(string[] args)
        {
            WeightSort.orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123");
            Console.Read();
        }
    }
}
public class WeightSort
{

    public static string orderWeight(string strng) => strng.Split(' ').ToArray().OrderBy(x => x).OrderBy(x => x.ToArray().Sum(y => int.Parse(y.ToString()))).Aggregate((x, y) => x + " " + y).ToString();

}