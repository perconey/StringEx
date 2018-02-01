using System;
using System.Collections.Generic;
using System.Text;

namespace StringEx
{
    //      String transforming methods
    public static class TransformationMethods
    {

        //Function to get random number
        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        private static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }

        /// <summary>
        /// Transforms the value of specified string into new string in reversed order
        /// </summary>
        /// <returns>Shuffled string</returns>
        public static string Reverse(this string str)
        {
            char[] ca = str.ToCharArray();
            Array.Reverse(ca);
            return new string(ca);
        }

        /// <summary>
        /// Transforms the value of sepcified string into new string containing the same characters but in random order
        /// </summary>
        /// <returns>Shuffled string</returns>
        public static string ShuffleCharacters(this string str)
        {
            var li = new List<char>();
            foreach(char c in str)
            {
                li.Add(c);
            }
            StringBuilder sb = new StringBuilder();
            for(int i = li.Count;  i > 0; i--)
            {
                int index = GetRandomNumber(0, i);
                sb.Append(li[index]);
                li.RemoveAt(index);
            }
            return sb.ToString();
        }
    }
}
