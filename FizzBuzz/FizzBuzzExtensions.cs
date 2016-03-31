using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class FizzBuzzExtensions
    {
        //elegant
        public static string FizzBuzz1(this int n)
            => (n % 5 == 0 ? "Fizz" : "") + (n % 3 == 0 ? "Buzz" : (n % 5 == 0 ? "" : "" + n));

        //fast & readable
        public static string FizzBuzz2(this int n)
        {
            if (n % 5 == 0)
            {
                if (n % 3 == 0)
                    return "FizzBuzz";
                return "Fizz";
            }
            if (n % 3 == 0)
                return "Buzz";
            return n.ToString();
        }
    }
}
