using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class Questions
    {
        /* isPalindrome takes in a string and must return true if the string is a palindrome 
         * and return false if the string is not a palindrome
         * 
         * A Palidrome is a string that is read the same forwards and backwards
         * 
         * Examples: 
         *          "madam" is a palindrome 
         *          "david" is NOT a palidrome
         * 
         * Note: For this question assume empty strings and 1 character strings are palindromes  
         */
        public static bool isPalindrome(string candidate) 
        {    
            return true; 
        }

        /* nthFib takes in an integer n and must return the nth number of the fibonacci sequence
         * 
         * The fibonacci sequence is defined as the sum of the previous two terms in the series,
         * with the first two terms being fib(0) = 0 and fib(1) = 1
         * 
         * The first few numbers of the fibonacci sequence are
         * 0, 1, 1, 2, 3, 5, 8, ...
         * 
         */
        public static int nthFib(int n)
        {
            return 1; 
        }

        /* computeAngleBetweenNumbersOnClock takes in two integers which represent numbers
         * on a clock face and must return the degree value of the angle inbetween the two numbers
         * 
         * For example:
         *      computeAngleBetweenNumbersOnClock(12, 3) would return 90
         *      computeAngleBetweenNumbersOnClock(12, 6) would return 180 
         * 
         * Note: The angle should be measured clockwise from the first number. 
         *       If num1 equals num2 then the function should return 0 (not 360)
         *       0 will not be given as an input, this will be 12. 
         */
        public static int computeAngleBetweenNumbersOnClock(int num1, int num2)
        {
            return 1; 
        }

        /* calculateChange takes two integers, a dollar amount and a cents amount and must return
         * answer which is an array containing the minimal amount of coins that gives correct change. 
         * But there is a catch! Coin demonimations have been refactored and the only coins you have
         * available are 2 cent, 3 cent, and 4 cent coins. 
         * 
         * The answer array should be formatted so that the value at index 0 is the number
         * of 2 cent coins, the value at index 1 is the number of 3 cent coins, and the value at index
         * 2 is the number of 4 cent coins. 
         * 
         * For example:
         *      calculateChange(0, 40) would return an array [0][0][10]
         *      calculateChange(1, 10) would return an array [1][0][27]
         */ 
        public static int[] calculateChange(int dollars, int cents)
        {
            int[] answer = new int[3];
            return answer;
        }

        /* romanNumeraltoNumber takes in a string which represents a roman numeral and must return 
         * the corresponding decimal value of the number. 
         * 
         * Note: We are limiting values to < 150 and all inputs will be capitalized
         * 
         * Roman Numerals:
         *      I = 1
         *      V = 5
         *      X = 10
         *      L = 50
         *      C = 100
         * 
         *  The outputs must follow the following rules: 
         *  2. If one or more letters are placed after another letter of greater value, add that amount
         *     VI = 6 (5 + 1 = 6)
         *     LXX = 70 (50 + 10 + 10 = 70)
         *  3. If a letter is placed before another letter of greater value, subtract that amount
         *     IV = 4 (5 - 1 = 4)
         *     XC = 90 (100 - 10 = 90)
         *     
         *  The test inputs will be constrained to the following rules about Roman Numerals: 
         *  1. A letter repeats its value that many times (XXX = 30, III = 3, etc) and a letter can only
         *     be repeated 3 times
         *     
         *  2. There are 3 sub rules about subtracting roman numerals
         *      a. Only powers of 10 can be subtracted (I, X, or C but not V or L)
         *          95 = XCV ((100 - 10) + 5 = 95)  
         *          The input WILL NOT contain VC (100 - 5)  
         *      b.  At most, one number will be subtracted in a row 
         *          13 = XIII (10 + 1 + 1 + 1 = 13) 
         *          The input WILL NOT contain IIXV (15 - 1 - 1)
         *          The input WILL NOT contain IVX (15 - 5 - 1) or (15 - (5 - 1))
         *      c. A number will not be subtracted a number from one that is more than 10 times greater 
         *         That is you can subtract 1 from 10 but not 1 from 20
         *         99 = XCIX (90 + 9 = 99)
         *         The input WILL NOT contain IC (100 - 1) 
         * 
         */
        public static int romanNumeraltoNumber(string romanNumeral) 
        {
            return 1; 
        }

        /* This is the main function which you can use to test your functions. Run the program
         * and enter one of the following commands to test any one function.
         *      
         * Where function tag is one of the following:
         *      Palindrome for isPalindrome function 
         *      nthFib for nthFib function 
         *      Angle for computeAngleBetweenNumbersOnClock function
         *      Change for calculateChange function 
         *      RomanNumeral for romanNumeraltoNumber function
         */
      
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter which function you are testing, or 'Exit' to close: ");
            Console.WriteLine("Palindrome");
            Console.WriteLine("nthFib");
            Console.WriteLine("Angle");
            Console.WriteLine("Change");
            Console.WriteLine("RomanNumeral");
            string functionInput = Console.ReadLine().ToLowerInvariant().Trim();

            while(functionInput != "exit" && functionInput != "'exit'")
            {
                if (functionInput == "palindrome")
                {
                    Console.WriteLine("Please enter a test string for the isPalindrome function.");
                    var testPalindrome = Console.ReadLine();
                    Console.WriteLine(isPalindrome(testPalindrome));
                }
                else if (functionInput == "nthfib")
                {
                    Console.WriteLine("Please enter a test integer for the nthFib function.");
                    var testInt = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(nthFib(testInt));
                }
                else if (functionInput == "angle")
                {
                    Console.WriteLine("Please enter two test integers for the angle function (one per line).");
                    var hourOne = Int32.Parse(Console.ReadLine());
                    var hourTwo = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(computeAngleBetweenNumbersOnClock(hourOne, hourTwo));
                }
                else if (functionInput == "change")
                {
                    Console.WriteLine("Please enter a dollar amount, followed by a cents amount (line separated) for the change function.");
                    var dollars = Int32.Parse(Console.ReadLine());
                    var cents = Int32.Parse(Console.ReadLine());
                    var result = calculateChange(dollars, cents);
                    Console.WriteLine("2c: " + result[0]);
                    Console.WriteLine("3c: " + result[1]);
                    Console.WriteLine("4c: " + result[2]);
                }
                else if (functionInput == "romannumeral")
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
