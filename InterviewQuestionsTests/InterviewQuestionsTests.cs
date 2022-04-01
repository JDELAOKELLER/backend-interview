using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class InterviewQuestionsTests
    {
        [TestMethod]
        public void PalindromeTests()
        {
            string empty = "";
            string one_letter = "a";
            string two_letter = "aa";
            string two_letter_false = "ab";
            string even_true = "abba";
            string even_false = "abbc";
            string odd_true = "racecar";
            string odd_false = "abbcbca";

            string unexpectedOutputString = "Unexpected output for input: ";

            Assert.AreEqual(true, Questions.isPalindrome(empty), unexpectedOutputString + empty);
            Assert.AreEqual(true, Questions.isPalindrome(one_letter), unexpectedOutputString + one_letter);
            Assert.AreEqual(true, Questions.isPalindrome(two_letter), unexpectedOutputString + two_letter);
            Assert.AreEqual(false, Questions.isPalindrome(two_letter_false), unexpectedOutputString + two_letter_false);
            Assert.AreEqual(true, Questions.isPalindrome(even_true), unexpectedOutputString + even_true);
            Assert.AreEqual(false, Questions.isPalindrome(even_false), unexpectedOutputString + even_false);
            Assert.AreEqual(true, Questions.isPalindrome(odd_true), unexpectedOutputString + odd_true);
            Assert.AreEqual(false, Questions.isPalindrome(odd_false), unexpectedOutputString + odd_false);
        }

        [TestMethod]
        public void FibonacciTests()
        {
            string unexpectedOutputString = "Unexpected output for input: ";

            Assert.AreEqual(0, Questions.nthFib(0), unexpectedOutputString + 0);
            Assert.AreEqual(1, Questions.nthFib(1), unexpectedOutputString + 1);
            Assert.AreEqual(1, Questions.nthFib(2), unexpectedOutputString + 2);
            Assert.AreEqual(2, Questions.nthFib(3), unexpectedOutputString + 3);
            Assert.AreEqual(13, Questions.nthFib(7), unexpectedOutputString + 7);
        }

        [TestMethod]
        public void AngleTests()
        {
            string unexpectedOutputString = "Unexpected output for inputs: ";

            Assert.AreEqual(0, Questions.computeAngleBetweenNumbersOnClock(12, 12), unexpectedOutputString + "num1=12, num2=12");
            Assert.AreEqual(120, Questions.computeAngleBetweenNumbersOnClock(1, 5), unexpectedOutputString + "num1=1, num2=5");
            Assert.AreEqual(30, Questions.computeAngleBetweenNumbersOnClock(1, 2), unexpectedOutputString + "num1=1, num2=2");
            Assert.AreEqual(330, Questions.computeAngleBetweenNumbersOnClock(2, 1), unexpectedOutputString + "num1=2, num2=1");
            Assert.AreEqual(270, Questions.computeAngleBetweenNumbersOnClock(6, 3), unexpectedOutputString + "num1=6, num2=3"); 
        }

        [TestMethod]
        public void ChangeTests()
        {
            string unexpected2cOutputString = "Unexpected 4c output for input: ";
            string unexpected3cOutputString = "Unexpected 3c output for input: ";
            string unexpected4cOutputString = "Unexpected 2c output for input: ";

            // $1.00 test
            Assert.AreEqual(0, Questions.calculateChange(1, 0)[0], unexpected2cOutputString + "1 dollar, 0 cents");
            Assert.AreEqual(0, Questions.calculateChange(1, 0)[1], unexpected3cOutputString + "1 dollar, 0 cents");
            Assert.AreEqual(25, Questions.calculateChange(1, 0)[2], unexpected4cOutputString + "1 dollar, 0 cents");

            // $0.30 test
            Assert.AreEqual(1, Questions.calculateChange(0, 30)[0], unexpected2cOutputString + "0 dollar, 30 cents");
            Assert.AreEqual(0, Questions.calculateChange(0, 30)[1], unexpected3cOutputString + "0 dollar, 30 cents");
            Assert.AreEqual(7, Questions.calculateChange(0, 30)[2], unexpected4cOutputString + "0 dollar, 30 cents");

            // $0.75 test
            Assert.AreEqual(0, Questions.calculateChange(0, 75)[0], unexpected2cOutputString + "0 dollars, 75 cents");
            Assert.AreEqual(1, Questions.calculateChange(0, 75)[1], unexpected3cOutputString + "0 dollars, 75 cents");
            Assert.AreEqual(18, Questions.calculateChange(0, 75)[2], unexpected4cOutputString + "0 dollars, 75 cents");

            // $0.33 test
            Assert.AreEqual(1, Questions.calculateChange(0, 33)[0], unexpected2cOutputString + "0 dollars, 33 cents");
            Assert.AreEqual(1, Questions.calculateChange(0, 33)[1], unexpected3cOutputString + "0 dollars, 33 cents");
            Assert.AreEqual(7, Questions.calculateChange(0, 33)[2], unexpected4cOutputString + "0 dollars, 33 cents");

            // $5.15 test
            Assert.AreEqual(0, Questions.calculateChange(5, 15)[0], unexpected2cOutputString + "5 dollars, 15 cents");
            Assert.AreEqual(1, Questions.calculateChange(5, 15)[1], unexpected3cOutputString + "5 dollars, 15 cents");
            Assert.AreEqual(128, Questions.calculateChange(5, 15)[2], unexpected4cOutputString + "5 dollars, 15 cents");
        }

        [TestMethod]
        public void RomanTests()
        {
            string unexpectedOutputString = "Unexpected output for input: ";

            Assert.AreEqual(5, Questions.romanNumeraltoNumber("V"), unexpectedOutputString + "V");
            Assert.AreEqual(103, Questions.romanNumeraltoNumber("CIII"), unexpectedOutputString + "CIII");
            Assert.AreEqual(17, Questions.romanNumeraltoNumber("XVII"), unexpectedOutputString + "XVII");
            Assert.AreEqual(94, Questions.romanNumeraltoNumber("XCIV"), unexpectedOutputString + "XCIV");
            Assert.AreEqual(144, Questions.romanNumeraltoNumber("CXLIV"), unexpectedOutputString + "CXLIV");
            Assert.AreEqual(88, Questions.romanNumeraltoNumber("LXXXVIII"), unexpectedOutputString + "LXXXVIII");
        }

    }
}
