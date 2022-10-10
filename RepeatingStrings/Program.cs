using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepeatingStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Calling the RepeatStr method, passing in our 6 & hello (OR WHATEVER YOU WANT PASSED IN)
            var example = RepeatStr(6, "hello");
            //This displays our 6 & hello to the console (OR whatever you have passed in)
            Console.WriteLine(example);
        }

        //Method called RepeatStr passing in an INTEGER n & a STRING s
        public static string RepeatStr(int n, string s)
        {
            //StringBuilder allows you to manipulate strings
            StringBuilder builder = new StringBuilder();
            //For loop using INT i which equals 0 in this case, i is less than n in this case, so i will INCREMENT (++)
            for (int i = 0; i < n; i++)
            {   //builder.Append(s) telling the STRING BUILDER to APPEND TO ITSELF
                builder.Append(s);
            }
            //returning the builder as a string (OR COULD BE ANYTHING YOU PASS IN THE CALLED METHOD)
            return builder.ToString();
        }

    }
}
