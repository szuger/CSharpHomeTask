﻿/*
 Den has invited some friends. His list is:

s = "Fired:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";

Could you make a program that
Ð’Â· makes this string uppercase
Ð’Â· gives it sorted in alphabetical order by last name.
When the last names are the same, sort them by first name. Last name and first name of a guest come in the result between parentheses separated by a comma.
So the result of function meeting(s) will be:
Examples:

"(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)"

It can happen that in two distinct families with the same family name two people have the same first name too.
*/
using NUnit.Framework;

namespace CSharpHomeTask5
{
    public class HT5
    {
        [Test]
        public void Test1_BasicTest()
        {
            string list = "Abba:SingerB;Abba:SingerA;Cold:Play;Bonny:M;Facebok:Meta;Almond:Milk;Apple:Gate;Peach:Gate;Lucky:Jhon"
            string expectedResult = "(GATE, APPLE)(GATE, PEACH)(JHON, LUCKY)(M, BONNY)(META, FACEBOK)(MILK, ALMOND)(SINGERA, ABBA)";
            var result = SortingName(list);

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Test2_EmptyList()
        {
            string list = " ";
            string expectedResult = " ";
            string result = SortingName(list);

            Assert.AreEqual(expectedResult, result);
        }

        public static string SortingName (string s)
        {
            return s;
        }
    }
}