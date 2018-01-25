using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEx
{
    public static class NumberAnalysisMethods
    {
        /// <summary>
        /// Indicates whether the specified string is divisible by 4
        /// </summary>
        /// <returns>Boolean</returns>
        public static bool DivisibleBy4(this string str)
        {
            if (!str.IsNumber())
                throw new System.ArgumentException("Provided string is not a number");

            var strint = str.ToString();
            if (((int)Char.GetNumericValue(strint[strint.Length - 1])
                + (int)Char.GetNumericValue(strint[strint.Length - 2])) % 4 != 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Indicates whether the specified string is divisible by 3
        /// </summary>
        /// <returns>Boolean</returns>
        public static bool DivisibleBy3(this string str)
        {
            if (!str.IsNumber())
                throw new System.ArgumentException("Provided string is not a number");

            var strint = str.ToString();
            long sum = 0;
            for (int i = strint.Length - 1; i >= 0; i--)
            {
                sum += (int)Char.GetNumericValue(strint[i]);
            }
            if (sum % 3 != 0)
            {
                return false;
            }

            return true;
        }

        //public static bool DivisibleBy(this string str)
        //{
        //    var strint = str.ToString();

        //    return true;
        //}
    }
}
