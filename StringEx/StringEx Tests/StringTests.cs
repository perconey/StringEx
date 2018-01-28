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
            bool ids = s.IsDelimiterSeparated(false);
            //Assert
            Assert.IsTrue(ids);
        }

        [TestMethod]
        public void IsNotNumberTest()
        {
            //Arrange
            string s = "bigman";
            //Act
            bool isn = !s.IsInteger();
            //Assert
            Assert.IsTrue(isn);
        }

        [TestMethod]
        public void IsNumberTest()
        {
            //Arrange
            string s = "-123879812";
            //Act
            bool isn = s.IsInteger();
            //Assert
            Assert.IsTrue(isn);
        }

        [TestMethod]
        public void IsDivisibleByTest()
        {
            //Arrange 
            int i = 0;
            List<string> nums = new List<string>()
            {
                "43929499634849239426836750481580",//by 4
                "264195412830613048495518",//by 3
                "1553748446562909491908107",//by 9
                "868036385685563859740400964",//by 11
                "358527563247560",//by 20
                "32706554133313465074891707352594",//by 7
            };

            List<bool> bls = new List<bool>()
            {
                nums[0].DivisibleBy4(),
                nums[1].DivisibleBy3(),
                nums[2].DivisibleBy9(),
                nums[3].DivisibleBy11(),
                nums[4].DivisibleBy20(),
                nums[5].DivisibleBy7(),
            };

            //Act
            foreach(bool it in bls)
            {
                Debug.WriteLine($"Number {nums[i]} is {it} divisible by its given divisor");
                i++;
            }

            //Assert
            Assert.IsTrue(bls.TrueForAll(AllT));

        }
    }
}
