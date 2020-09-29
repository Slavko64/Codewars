using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_readable_duration_format
{
    public class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            if (seconds == 0)
                return "now";
            int years = 0, days = 0, hours = 0, minutes = 0;
            string timestring = "";
            while(seconds>=60)
            {
                minutes++;
                seconds -= 60;
            }
            while(minutes>=60)
            {
                hours++;
                minutes -= 60;
            }
            while(hours>=24)
            {
                days++;
                hours -= 24;
            }
            while(days>= 365)
            {
                years++;
                days -= 365;
            }
            if (seconds > 0)
            {
                if (seconds == 1)
                    timestring += seconds + " second";
                else
                {
                    timestring += seconds + " seconds";
                }
            }
            if(minutes > 0)
            {
                if (minutes == 1)
                {
                    if (timestring == "")
                        timestring += minutes + " minute";
                    else
                        timestring += minutes + " minute and ";
                }
                else
                {
                    if (timestring == "")
                        timestring += minutes + " minutes";
                    else
                        timestring += minutes + " minutes and ";
                }
            }
            if (days > 0)
            {
                if (days == 1)
                {
                    if (timestring == "")
                        timestring += days + " day";
                    else if (timestring.Contains("and"))
                        timestring += days + " day,";
                    else timestring += days + " day and ";
                }
                else
                {
                    if (timestring == "")
                        timestring += days + " days";
                    else if (timestring.Contains("and"))
                        timestring += days + " days,";
                    else timestring += days + " days and ";
                }
            }
            if (years > 0)
            {
                if (years == 1)
                {
                    if (timestring == "")
                        timestring += years + " year";
                    else if (timestring.Contains("and"))
                        timestring += years + " year,";
                    else timestring += years + " year and";
                }
                else
                {
                    if (timestring == "")
                        timestring += years + " years";
                    else if (timestring.Contains("and"))
                        timestring += years + " years,";
                    else timestring += years + " years and ";
                }
            }
            return timestring;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HumanTimeFormat.formatDuration(33243586));
            Console.ReadLine();
        }
    }
}
