using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzExercise
{
    internal static class FizzBuzz
    {
        public static string CheckNumber(int number)
        {
            if (number == 0)
                return "You made a mistake!";
            else if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
            else
                return $"{number} is not divisible by 3 or 5!";
        }
    }
}
