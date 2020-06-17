using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_letter_counting
{
    public class Kata
    {
        public static string StringLetterCount(string str)
        {
            str = str.ToLower();
            Dictionary<char, int> letters = new Dictionary<char, int>();
            
            string output = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                { 
                        if (letters.ContainsKey(str[i]))
                            letters[str[i]]++;
                        else letters.Add(str[i], 1);
                }
            }
           var SortedLetters = letters.OrderBy(u=>u.Key);
            foreach(KeyValuePair<char,int> i in SortedLetters)
            {
                output += i.Value;
                output += i.Key;
            }
            return output;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.StringLetterCount("The time you enjoy wasting is not wasted time."));
            Console.ReadLine();
        }
    }
}
