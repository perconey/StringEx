using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringEx;

namespace StringEx_Tests
{
    [TestClass]
    public class StringTests
    {
        //not being used , nts!!
        private bool IsTrueCollection(List<bool> list)
        {
            foreach(bool el in list)
            {
                if (el != true)
                    return false;
            }
            return true;
        }

        private static string ts1 = "Hello and welcome to my code";
        private static string ts2 = "Octahedron";
        private static string ts3 = "I'm okay, and you're not";
        private static string ts4 = "perconey@gmail.com";
        private static string ts5 = "746582294";
        private static string ts6 = "Hello! My phone number is 827112333 and email example@web.net";
        private static string ts7 = "Mess,!jo@)!n04n0N!@)9ncala)()(@@[};'[].]]";
        private static string ts8 = "You WILL be noticed by ME, or HIM!";

        private List<String> nonCamelCWords = new List<string>()
        {
            ts1,ts2,ts3,ts6,ts7,ts8,
        };

        [TestMethod]
        public void CamelCaseTest()
        {
            //Arrange
            string s1 = ts1.ToCamelCase();

            //Act
            bool icc = s1.IsCamelCase();

            //Assert
            Assert.IsTrue(icc);
        }

        [TestMethod]
        public void CheckOneSentenceIsNotCamel()
        {
            //Arrange
            string s = ts1;

            //Act
            bool check = ts1.IsCamelCase();

            //Assert
            Assert.IsTrue(!check);

        }

        [TestMethod]
        public void NotCamelCaseCheck()
        {
            //Arrange
            var bl = new List<bool>();

            //Act
            foreach(var el in nonCamelCWords)
            {
                Debug.WriteLine(el.IsCamelCase()+ " For :" + el);
                bl.Add(el.IsCamelCase());
            }

            //Assert
            Assert.IsTrue(!bl.TrueForAll(AllT));
        }
        private bool AllT(bool b)
        {
            return b;
        }

        [TestMethod]
        public void DelimiterSeparatedTest()
        {
            //Arrange
            string s = ts1;
            //Act
            s = s.ToDelimiterSeparated('$',true);
            Debug.WriteLine(s);
            //Assert
            Assert.IsTrue(true);

        }
    }
}
