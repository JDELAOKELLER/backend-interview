using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class Questions
    {
        /* Return true if candidate reads the same left-to-right and right-to-left.
         * Otherwise return false.
         *
         * Treat the string exactly as given. You do not need to ignore spaces,
         * punctuation, or letter casing.
         *
         * Examples:
         *      "madam" -> true
         *      "david" -> false
         *      "" -> true
         *      "a" -> true
         */
        public static bool isPalindrome(string candidate) 
        {    
            return true; 
        }

        /* Return the nth Fibonacci number.
         * The sequence is defined as the sum of the previous two terms in the series.
         *
         * Use this definition:
         *      fib(0) = 0
         *      fib(1) = 1
         *      fib(n) = fib(n - 1) + fib(n - 2) for n >= 2
         *
         * Examples:
         *      nthFib(0) -> 0
         *      nthFib(1) -> 1
         *      nthFib(2) -> 1
         *      nthFib(3) -> 2
         *      nthFib(7) -> 13
         */
        public static int nthFib(int n)
        {
            return 1; 
        }

        /* The inputs are two numbers on a standard clock face, from 1 to 12.
         *
         * Return the clockwise angle, in degrees, from num1 to num2.
         * Each step between adjacent numbers is 30 degrees.
         *
         * Rules:
         *      If num1 and num2 are the same, return 0.
         *      Measure only clockwise, not the smaller of the two angles.
         *      Treat 12 as the top of the clock. The input will never be 0.
         *
         * Examples:
         *      computeAngleBetweenNumbersOnClock(12, 3) -> 90
         *      computeAngleBetweenNumbersOnClock(12, 6) -> 180
         *      computeAngleBetweenNumbersOnClock(2, 1) -> 330
         */
        public static int computeAngleBetweenNumbersOnClock(int num1, int num2)
        {
            return 1; 
        }

        /* Convert the input amount into the fewest total number of coins using
         * only 2-cent, 3-cent, and 4-cent coins.
         *
         * The inputs are dollars and cents. First convert them to a total number
         * of cents.
         *
         * Return an array of length 3:
         *      index 0 = number of 2-cent coins
         *      index 1 = number of 3-cent coins
         *      index 2 = number of 4-cent coins
         *
         * If multiple combinations make the same amount, choose the one that
         * uses the fewest coins.
         *
         * Examples:
         *      calculateChange(0, 40) -> [0, 0, 10]
         *      calculateChange(1, 10) -> [1, 0, 27]
         *      calculateChange(0, 33) -> [1, 1, 7]
         */ 
        public static int[] calculateChange(int dollars, int cents)
        {
            int[] answer = new int[3];
            return answer;
        }

        /* Convert a valid Roman numeral into its integer value.
         *
         * The input will be uppercase and represent a value less than 150.
         *
         * Symbol values:
         *      I = 1
         *      V = 5
         *      X = 10
         *      L = 50
         *      C = 100
         *
         * Read the numeral from left to right:
         *      If a symbol is smaller than the symbol after it, subtract it.
         *      Otherwise, add it.
         *
         * You may assume the input is a valid Roman numeral under the rules
         * used in this exercise.
         *
         * Examples:
         *      "V" -> 5
         *      "XVII" -> 17
         *      "XCIV" -> 94
         *      "CXLIV" -> 144
         */
        public static int romanNumeraltoNumber(string romanNumeral) 
        {
            return 1; 
        }

        /* This is the main function you can use to test your work manually.
         * Run the program and enter one of the following numbers:
         *
         *      1 for isPalindrome
         *      2 for nthFib
         *      3 for computeAngleBetweenNumbersOnClock
         *      4 for calculateChange
         *      5 for romanNumeraltoNumber
         */
      
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number corresponding to which function you are testing, or 'Exit' to close: ");
            Console.WriteLine("1. Palindrome");
            Console.WriteLine("2. nthFib");
            Console.WriteLine("3. Angle");
            Console.WriteLine("4. Change");
            Console.WriteLine("5. RomanNumeral");
            string functionInput = Console.ReadLine().ToLowerInvariant().Trim();

            while(functionInput != "exit" && functionInput != "'exit'")
            {
                if (functionInput == "1")
                {
                    Console.WriteLine("Please enter a test string for the isPalindrome function.");
                    var testPalindrome = Console.ReadLine();
                    Console.WriteLine(isPalindrome(testPalindrome));
                }
                else if (functionInput == "2")
                {
                    Console.WriteLine("Please enter a test integer for the nthFib function.");
                    var testInt = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(nthFib(testInt));
                }
                else if (functionInput == "3")
                {
                    Console.WriteLine("Please enter two test integers for the angle function (one per line).");
                    var hourOne = Int32.Parse(Console.ReadLine());
                    var hourTwo = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(computeAngleBetweenNumbersOnClock(hourOne, hourTwo));
                }
                else if (functionInput == "4")
                {
                    Console.WriteLine("Please enter a dollar amount, followed by a cents amount (line separated) for the change function.");
                    var dollars = Int32.Parse(Console.ReadLine());
                    var cents = Int32.Parse(Console.ReadLine());
                    var result = calculateChange(dollars, cents);
                    Console.WriteLine("2c: " + result[0]);
                    Console.WriteLine("3c: " + result[1]);
                    Console.WriteLine("4c: " + result[2]);
                }
                else if (functionInput == "5")
                {
                    Console.WriteLine("Please enter a test string for the RomanNumeral function.");
                    var romanNumeral = Console.ReadLine();
                    Console.WriteLine(romanNumeraltoNumber(romanNumeral));
                }
                else
                {
                    Console.WriteLine("Invalid function input. Please try again.");
                }
                if (functionInput != "exit" && functionInput != "'exit")
                {
                    Console.WriteLine("Enter another function or 'Exit' to close.");
                    functionInput = Console.ReadLine().ToLowerInvariant().Trim();
                }
            }
        }

    }
}
