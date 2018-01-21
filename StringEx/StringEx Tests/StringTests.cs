using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringEx;

namespace StringEx_Tests
{
    [TestClass]
    public class StringTests
    {
        private static string ts1 = "Hello and welcome to my code";
        private static string ts2 = "Octahedron";
        private static string ts3 = "I'm okay, and you're not";
        private static string ts4 = "perconey@gmail.com";
        private static string ts5 = "746582294";
        private static string ts6 = "Hello! My phone number is 827112333 and email example@web.net";
        private static string ts7 = "Mess,!jo@)!n04n0N!@)9ncala)()(@@[};'[].]]";
        private static string ts8 = "You WILL be noticed by ME, or HIM!";

        [TestMethod]
        public void TestMethod1()
        {
            Debug.WriteLine(ts1.ToCamelCase());
            Debug.WriteLine("hello");
        }
    }
}
