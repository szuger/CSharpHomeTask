/*
Create a function that takes a positive integer and returns the next bigger number that can be formed by rearranging its digits.

Examples:

nextBigger(num: 12)    // returns 21
nextBigger(num : 513)  //  returns 531 
nextBigger(num : 2017  //  returns 2071

If the digits can't be rearranged to form a bigger number, return -1

 9  =>  -1
111 =>  -1
531 =>  -1
*/
using NUnit.Framework;

namespace CSharpHomeTask6
{
    public class HT6
    {
        [Test]
        public void Test1_BasicTest()
        {
            int number = 1239;
            int expectedResult = 1293;
            int result = NextBigger(number);

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Test2_CantRearrange()
        {
            int number = 3222;
            int expectedResult = -1;
            int result = NextBigger(number);

            Assert.AreEqual(expectedResult, result);
        }

        public static int NextBigger(int number)
        {
            return number;
        }
    }
}