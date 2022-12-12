﻿/*
 Digital root is the recursive sum of all the digits in a number.
Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced. The input will be a non-negative integer.
Examples:
digital_root(16)
=> 1 + 6
=> 7

digital_root(942)
=> 9 + 4 + 2
=> 15 ...
=> 1 + 5
=> 6

digital_root(132189)
=> 1 + 3 + 2 + 1 + 8 + 9
=> 24 ...
=> 2 + 4
=> 6

digital_root(493193)
=> 4 + 9 + 3 + 1 + 9 + 3
=> 29 ...
=> 2 + 9
=> 11 ...
=> 1 + 1
=> 2

 */
using NUnit.Framework;
using System;

namespace CSharpHomeTask3
{
    public class HT3
    {
        public int DigitalRoot(long n)
        {
            if (n == 0) return 0;
            long remainder = n % 9;
            if (remainder == 0)
            {
                return 9;
            }
            else
            {
                return Convert.ToInt32(n % 9);
            }
        }

        [Test]
        public void Test1_ZeroNumber()
        {
            long number = 0;
            int expectedResult = 0;
            int result = DigitalRoot(number);

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Test2_1To9()
        {
            long number = 123456789;
            int expectedResult = 9;
            int result = DigitalRoot(number);

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Test3_MixedNumbers()
        {
            long number = 18485155155;
            int expectedResult = 3;
            int result = DigitalRoot(number);

            Assert.AreEqual(expectedResult, result);
        }
    }
}