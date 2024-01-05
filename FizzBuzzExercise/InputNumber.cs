using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzExercise
{
    internal static class InputNumber
    {
        public static string Input()
        {
            Console.WriteLine("What number do you want to check? (If wrong it will count as 0)");
            var input = Console.ReadLine();
            return input;
        }

        public static int InputToInt(string input)
        {
            var number = 0;
                try
                {
                    number = int.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You needed to input a number!");
                    number = 0;
                }
                catch (Exception e)
                {
                    number = 0;
                }
                return number;
            }
        }
    }
