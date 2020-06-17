using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_with_two_Strings
{
    public class Kata
    {
        public static string workOnStrings(string a, string b)
        {
            char[] a_charArr = a.ToCharArray();
            char[] b_charArr = b.ToCharArray();
            string output = "";
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b_charArr.Length; j++)
                {
                    if(a_charArr[i].ToString().ToLower() == b_charArr[j].ToString().ToLower())
                    {
                        if (b_charArr[j].ToString().ToLower() == b_charArr[j].ToString())
                            b_charArr[j] = char.Parse(b_charArr[j].ToString().ToUpper());
                        else b_charArr[j] = char.Parse(b_charArr[j].ToString().ToLower());
                    }
                }
            }
            for (int i = 0; i < b_charArr.Length; i++)
            {
                for (int j = 0; j < a_charArr.Length; j++)
                {
                    if (b_charArr[i].ToString().ToLower() == a_charArr[j].ToString().ToLower())
                    {
                        if (a_charArr[j].ToString().ToLower() == a_charArr[j].ToString())
                            a_charArr[j] = char.Parse(a_charArr[j].ToString().ToUpper());
                        else a_charArr[j] = char.Parse(a_charArr[j].ToString().ToLower());
                    }
                }
            }
            for (int i = 0; i < a_charArr.Length; i++)
            {
                output += a_charArr[i];
            }
            for (int i = 0; i < b_charArr.Length; i++)
            {
                output += b_charArr[i];
            }
            return output;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.workOnStrings("abab", "bababa"));
            Console.ReadLine();
        }
    }
}
